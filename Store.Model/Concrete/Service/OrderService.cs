using Data.Repository.Concrete;
using Store.Model.Abstract;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;

namespace Store.Model.Concrete.Service
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        public OrderService(IStoreRepository repository) : base(repository) { }
    }
}
