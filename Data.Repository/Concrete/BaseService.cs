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

        public T GetById(string idName, string idValue)
        {
            // если значение можно привести к int, то приводим, иначе - передаём string
            int idInt;
            object idObject;
            if (int.TryParse(idValue, out idInt))
                idObject = idInt;
            else
                idObject = idValue;

            T result = repository.Table<T>().Where(idName + " == @0", idObject).FirstOrDefault();
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
