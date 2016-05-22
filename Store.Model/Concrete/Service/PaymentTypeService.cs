using Data.Repository.Concrete;
using Store.Model.Abstract;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;

namespace Store.Model.Concrete.Service
{
    public class PaymentTypeService : BaseService<PaymentType>, IPaymentTypeService
    {
        public PaymentTypeService(IStoreRepository repository) : base(repository) { }
    }
}
