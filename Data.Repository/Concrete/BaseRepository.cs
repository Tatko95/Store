using System;
using System.Collections.Generic;
using System.Linq;
using Data.Repository.Abstract;
using System.Data.Common;
using System.Data;
using System.Data.Linq;

namespace Data.Repository.Concrete
{
    public abstract class BaseRepository : IBaseRepository
    {
        #region fields
        protected DataContext dataContext;
        protected string connectionString;
        #endregion

        #region Basic
        public void BeginTransaction()
        {
            if (dataContext.Connection.State != ConnectionState.Open)
                dataContext.Connection.Open();
            DbTransaction trans = dataContext.Connection.BeginTransaction();
            dataContext.Transaction = trans;
        }

        public void SubmitChange()
        {
            dataContext.SubmitChanges();
        }

        public void Rollback()
        {
            if (dataContext.Transaction != null)
                try
                {
                    dataContext.Transaction.Rollback();
                }
                catch
                {
                    ///
                    /// Тут надо разобраться, почему правильно не происходит откат транзакции
                    ///
                }
                finally
                {
                    if (dataContext.Connection.State == ConnectionState.Open)
                        dataContext.Connection.Close();
                }
        }

        public void Commit()
        {
            if (dataContext.Transaction != null)
                try
                {
                    dataContext.Transaction.Commit();
                }
                catch
                {
                    dataContext.Transaction.Rollback();
                    throw;
                }
                finally
                {
                    if (dataContext.Connection.State == ConnectionState.Open)
                        dataContext.Connection.Close();
                }
        }
        #endregion

        #region Log
        public IDictionary<string, string> GetCommitParams(params string[] keyThenValueArray)
        {
            throw new NotImplementedException();
        }

        public void Commit(int funcId, IDictionary<string, string> addParams)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CRUD
        public IQueryable<T> Table<T>() where T : class
        {
            return dataContext.GetTable<T>();
        }

        public T Insert<T>(T entity) where T : class
        {
            InsertOperation<T> operation = new InsertOperation<T>(this);
            operation.Execute(entity);
            return entity;
        }

        public void Update<T>(T entity) where T : class
        {
            UpdateOperation<T> operation = new UpdateOperation<T>(this);
            operation.Execute(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            DeleteOperation<T> operation = new DeleteOperation<T>(this);
            operation.Execute(entity);
        }
        #endregion

        #region Operation
        abstract class BaseOperation<K> where K : class
        {
            protected BaseRepository repository;

            public BaseOperation(BaseRepository repository)
            {
                this.repository = repository;
            }

            public void Execute(K entity)
            {
                DataContext dataContext = repository.dataContext;
                DbTransaction trans = dataContext.Transaction;
                bool isTrans = trans != null ? true : false;
                try
                {
                    if (!isTrans)   // если открытой транзакции не было, то создаём новую
                    {
                        if (dataContext.Connection.State != ConnectionState.Open)
                            dataContext.Connection.Open();
                        trans = dataContext.Connection.BeginTransaction();
                        dataContext.Transaction = trans;
                    }

                    Operation(entity);
                    dataContext.SubmitChanges();
                    if (!isTrans) repository.Commit(); // если открытой транзакции не было, то сохраняем изменения в базе
                }
                catch
                {
                    if (trans != null)
                        trans.Rollback();
                    throw;
                }
                finally
                {
                    if (!isTrans)
                        if (dataContext.Connection.State == ConnectionState.Open)
                            dataContext.Connection.Close();
                }
            }

            public abstract void Operation(K entity);
        }

        class InsertOperation<K> : BaseOperation<K> where K : class
        {
            public InsertOperation(BaseRepository repository)
                : base(repository)
            {
            }

            public override void Operation(K entity)
            {
                repository.dataContext.GetTable<K>().InsertOnSubmit(entity);
            }
        }

        class UpdateOperation<K> : BaseOperation<K> where K : class
        {
            public UpdateOperation(BaseRepository repository)
                : base(repository)
            {
            }

            public override void Operation(K entity)
            {
                // если объект не присоединём к dataContext, то присоединяем
                if (repository.dataContext.GetTable<K>().GetOriginalEntityState(entity) == null)
                    repository.dataContext.GetTable<K>().Attach(entity);
                repository.dataContext.Refresh(RefreshMode.KeepCurrentValues, entity);
            }
        }

        class DeleteOperation<K> : BaseOperation<K> where K : class
        {
            public DeleteOperation(BaseRepository repository)
                : base(repository)
            {
            }

            public override void Operation(K entity)
            {
                repository.dataContext.GetTable<K>().DeleteOnSubmit(entity);
            }
        }
        #endregion
    }
}
