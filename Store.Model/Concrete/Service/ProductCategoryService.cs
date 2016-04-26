using System;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using Data.Repository.Concrete;
using Store.Model.Abstract;

namespace Store.Model.Concrete.Service
{
    public class ProductCategoryService : BaseService<ProductCategory>, IProductCategoryService
    {
        public ProductCategoryService(IStoreRepository repository) : base(repository) { }
    }
}