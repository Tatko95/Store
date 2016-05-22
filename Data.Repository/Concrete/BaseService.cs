using Data.Repository.Abstract;
using System;
using System.Linq;
using System.Linq.Dynamic;

namespace Data.Repository.Concrete
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected IBaseRepository repository;

        public BaseService(IBaseRepository repository)
        {
            this.repository = repository;
        }

        public T GetById(int id)
        {
            return repository.Table<T>().Where("id" + " == @0", id).FirstOrDefault();
        }

        public T GetByColumn(string columnName, string value)
        {
            // если значение можно привести к int, то приводим, иначе - передаём string
            int idInt;
            object idObject;
            if (int.TryParse(value, out idInt))
                idObject = idInt;
            else
                idObject = value;

            T result = repository.Table<T>().Where(columnName + " == @0", idObject).FirstOrDefault();
            return result;
        }

        public T Insert(T entity)
        {
            return repository.Insert(entity);
        }

        public void Update(T entity)
        {
            repository.Update(entity);
        }

        public void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public IQueryable<T> GetAll()
        {
            return repository.Table<T>();
        }
    }
}
