using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using Store.Model.Entities.Helpers;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class OrderController : BaseController<Order>
    {
        public OrderController(IOrderService service) : base(service) { }

        public ActionResult Index()
        {
            ViewData["Cart"] = (Cart)Session["Cart"] ?? new Cart();
            ViewData["DiliveryType"] = null;
            ViewData["PaymentType"] = null;
            return View(new Order());
        }
    }
}