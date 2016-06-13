using System;
using System.Linq;
using Data.Repository.Concrete;
using Store.Model.Abstract;
using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Store.Model.Concrete.Service
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        public OrderService(IStoreRepository repository) : base(repository) { }

        public IEnumerable<SelectListItem> GetDiliveryTypes()
        {
            var result = repository.Table<DiliveryType>().Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() });

            return result;
        }

        public IEnumerable<SelectListItem> GetPaymentTypes()
        {
            var result = repository.Table<PaymentType>().Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() });

            return result;
        }

        public string GetProductNamesById(int id)
        {
            var result = string.Join(",", (from lnk in repository.Table<Link_ConcreteProduct_Order>().Where(x => x.OrderId == id)
                                           from prod in repository.Table<Product>().Where(x => x.Id == lnk.ProductId)
                                           select prod.Name).ToList());
            return result;
        }
    }
}
