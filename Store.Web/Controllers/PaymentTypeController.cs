using Store.Model.Abstract.Service;
using Store.Model.Concrete.Service;
using Store.Model.Entities.dbml;
using Store.Web.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
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

        public JsonResult GetList(JQGridPostData jsonHeader)
        {
            IQueryable<PaymentType> data = service.GetAll();

            int totalRecords = data.Count();
            int totalPages = (int)Math.Ceiling(totalRecords / (double)jsonHeader.Rows);
            jsonHeader.SetCorrectPage(totalRecords);
            IQueryable<PaymentType> query = data
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
                                            null
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

        #region AddEdit
        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            PaymentType model;
            if (!id.HasValue)
                model = new PaymentType();
            else
                model = service.GetById(id.Value);

            return View(model);
        }

        [HttpPost]
        public ActionResult AddEdit(int? id, string name)
        {
            ((PaymentTypeService)service).UpsertRecord(id, name);
            return Content("Good");
        }
        #endregion

        #region Delete
        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
                ((PaymentTypeService)service).DeleteRecord(id.Value);
            return Content("Good");
        }
        #endregion
    }
}