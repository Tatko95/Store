using Microsoft.Practices.Unity;
using Store.Model.Abstract;
using Store.Model.Abstract.Service;
using Store.Model.Concrete;
using Store.Model.Concrete.Service;
using Store.Web.Utils;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Store.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureUnityContainer();
        }

        public static void ConfigureUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IStoreRepository, StoreRepository>
                (new HttpContextLifetimeManager<IStoreRepository>(), new InjectionConstructor(WebConfigurationManager.ConnectionStrings["Store"].ConnectionString));

            container.RegisterType<IProductCategoryService, ProductCategoryService>(new HttpContextLifetimeManager<IProductCategoryService>());
            container.RegisterType<IProductService, ProductService>(new HttpContextLifetimeManager<IProductService>());

            ControllerBuilder.Current.SetControllerFactory(new UnityControllerFactory(container));
        }
    }
}
