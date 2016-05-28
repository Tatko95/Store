using System;
using Data.Repository.Concrete;
using Store.Model.Abstract;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using System.Linq;

namespace Store.Model.Concrete.Service
{
    public class PaymentTypeService : BaseService<PaymentType>, IPaymentTypeService
    {
        public PaymentTypeService(IStoreRepository repository) : base(repository) { }

        public void DeleteRecord(int id)
        {
            repository.BeginTransaction();
            var model = GetById(id);
            Delete(model);
            repository.Commit();
        }

        public void UpsertRecord(int? id, string name)
        {
            repository.BeginTransaction();

            if (id.HasValue && id != 0)
            {
                var model = GetById(id.Value);
                model.Name = name;
                repository.SubmitChange();
            }
            else
            {
                PaymentType model = new PaymentType() { Id = repository.Table<PaymentType>().Select(x => x.Id).Max() + 1, Name = name };
                repository.Insert(model);
            }

            repository.Commit();
        }
        
    }
}
