using System;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using Data.Repository.Concrete;
using Store.Model.Abstract;

namespace Store.Model.Concrete.Service
{
    public class FirstService : BaseService<DiliveryType>, IFirstService
    {
        public FirstService(IStoreRepository repository) : base(repository)
        {

        }
    }
}
