using Data.Repository.Abstract;
using Store.Model.Entities.dbml;
using System.Linq;

namespace Store.Model.Abstract.Service
{
    public interface IProductService : IBaseService<Product>
    {
        IQueryable<Product> GetProductsByCategoryId(int categoryId);
    }
}
