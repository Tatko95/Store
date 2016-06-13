using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using Store.Model.Entities.Helpers;
using Store.Web.Utils;
using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class OrderController : BaseController<Order>
    {
        public OrderController(IOrderService service) : base(service) { }

        [HttpGet]
        public ActionResult Index()
        {
            //var test = (Cart)Session["Cart"];
            ViewData["Cart"] = (Cart)Session["Cart"] ?? new Cart();
            ViewData["DiliveryType"] = ((IOrderService)service).GetDiliveryTypes();
            ViewData["PaymentType"] = ((IOrderService)service).GetPaymentTypes();
            return View(new Order());
        }

        [HttpPost]
        public ActionResult Index(Order model)
        {
            ((IOrderService)service).Insert(model);
            Session["Cart"] = new Cart();
            return Redirect("~/Home");
        }

        public ActionResult List()
        {
            return View();
        }

        public JsonResult GetList(JQGridPostData jsonHeader)
        {
            IQueryable<Order> data = service.GetAll();

            int totalRecords = data.Count();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)jsonHeader.Rows);
            jsonHeader.SetCorrectPage(totalRecords);
            IQueryable<Order> query = data
                .OrderBy(jsonHeader.Sidx + " " + jsonHeader.Sord)
                .Skip((jsonHeader.Page - 1) * jsonHeader.Rows).Take(jsonHeader.Rows);

            var result = (from item in query
                          select new
                          {
                              i = item.Id,
                              cell = new IComparable[]
                                        {
                                            item.Id,
                                            item.Name,
                                            item.Adress,
                                            item.DiliveryType.Name,
                                            item.PaymentType.Name
                                        }
                          }).ToArray();

            var jsondata = new
            {
                total = totalPages,
                page = jsonHeader.Page,
                records = totalRecords,
                rows = result
            };

            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }
    }
}