using Data.Repository.Abstract;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class BaseController<T> : Controller where T : class
    {
        protected IBaseService<T> service;
        // GET: Base
        public BaseController(IBaseService<T> service)
        {
            this.service = service;
        }
    }
}