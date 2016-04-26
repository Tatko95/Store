using Store.Model.Abstract.Service;
using Store.Model.Entities.dbml;
using System.Linq;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class ProductCategoryController : BaseController<ProductCategory>
    {
        #region ctor
        public ProductCategoryController(IProductCategoryService service) : base(service) { }
        #endregion

        public ActionResult CategoryMenu(int? categoryId)
        {
            IQueryable<ProductCategory> model = service.GetAll().Where(x => x.Products.Any());

            ViewBag.SelectedCategoryId = categoryId;

            return PartialView(model);
        }
    }
}