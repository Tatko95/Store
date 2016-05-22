using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class PaymentTypeController : BaseController<PaymentType>
    {
        #region ctor
        public PaymentTypeController(IPaymentTypeService service) : base(service) { }
        #endregion

        public ActionResult List()
        {
            return View();
        }

        public JsonResult GetList()
        {
            var result = service.GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}