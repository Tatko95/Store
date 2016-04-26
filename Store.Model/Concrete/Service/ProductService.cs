using System;
using System.Linq;
using Data.Repository.Concrete;
using Store.Model.Abstract;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;

namespace Store.Model.Concrete.Service
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IStoreRepository repository) : base(repository) { }

        public IQueryable<Product> GetProductsByCategoryId(int categoryId)
        {
            var result = repository.Table<Product>().Where(x => x.ProductCategoryId == categoryId);
            return result;
        }
    }
}
