using Data.Repository.Abstract;
using Store.Model.Entities.dbml;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Store.Model.Abstract.Service
{
    public interface IOrderService : IBaseService<Order>
    {
        IEnumerable<SelectListItem> GetPaymentTypes();

        IEnumerable<SelectListItem> GetDiliveryTypes();

        string GetProductNamesById(int id);
    }
}
