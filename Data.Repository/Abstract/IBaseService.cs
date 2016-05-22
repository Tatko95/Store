using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Abstract
{
    public interface IBaseService<T> where T: class
    {
        IQueryable<T> GetAll();
        T GetByColumn(string columnName, string value);
        T GetById(int id);
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
