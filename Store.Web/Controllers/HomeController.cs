using Store.Model.Abstract.Service;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class HomeController : Controller
    {
        private IFirstService service;
        public HomeController(IFirstService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            //var t = ((FirstService)service).Insert(new Model.Entities.dbml.DiliveryType() { Name = "FirstTest" });
            return View();
        }
    }
}