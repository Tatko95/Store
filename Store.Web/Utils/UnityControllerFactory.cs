using Microsoft.Practices.Unity;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Store.Web.Utils
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        IUnityContainer container;

        public IUnityContainer Container
        {
            get
            {
                return container;
            }
        }

        public UnityControllerFactory(IUnityContainer container)
        {
            this.container = container;
        }

        protected override IController GetControllerInstance(RequestContext reqContext, Type controllerType)
        {
            IController controller;
            if (controllerType == null)
                throw new HttpException(
                        404, String.Format(
                            "The controller for path '{0}' could not be found" +
                        "or it does not implement IController.",
                        reqContext.HttpContext.Request.Path));

            if (!typeof(IController).IsAssignableFrom(controllerType))
                throw new ArgumentException(
                        string.Format(
                            "Type requested is not a controller: {0}",
                            controllerType.Name),
                            "controllerType");

            try
            {
                controller = container.Resolve(controllerType)
                                as IController;
                (controller as Controller).ActionInvoker = new UnityActionInvoker(container);
            }

            catch (Exception ex)
            {
                throw new InvalidOperationException(String.Format(
                                        "Error resolving controller {0}",
                                        controllerType.Name), ex);
            }

            return controller;
        }
    }

    public class UnityActionInvoker : ControllerActionInvoker
    {
        IUnityContainer container;

        public IUnityContainer Container
        {
            get
            {
                return container;
            }
        }

        public UnityActionInvoker(IUnityContainer container)
        {
            this.container = container;
        }

        protected override FilterInfo GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {
            var filters = base.GetFilters(controllerContext, actionDescriptor);

            foreach (var filter in filters.AuthorizationFilters)
            {
                container.BuildUp(filter.GetType(), filter);
            }
            return filters;
        }
    }

    public class HttpContextLifetimeManager<T> : LifetimeManager, IDisposable
    {

        public override object GetValue()
        {
            return HttpContext.Current.Items[typeof(T).AssemblyQualifiedName];
        }

        public override void RemoveValue()
        {
            HttpContext.Current.Items.Remove(typeof(T).AssemblyQualifiedName);
        }

        public override void SetValue(object newValue)
        {
            HttpContext.Current.Items[typeof(T).AssemblyQualifiedName] = newValue;
        }

        public void Dispose()
        {
            RemoveValue();
        }
    }

    public class HttpContextLifetimeManager : LifetimeManager, IDisposable
    {
        private string typeName = null;

        public override object GetValue()
        {
            if (typeName != null)
                return HttpContext.Current.Items[typeName];
            else
                return null;
        }

        public override void RemoveValue()
        {
            if (typeName != null)
                HttpContext.Current.Items.Remove(typeName);
        }

        public override void SetValue(object newValue)
        {
            typeName = newValue.GetType().AssemblyQualifiedName;
            HttpContext.Current.Items[typeName] = newValue;
        }

        public void Dispose()
        {
            RemoveValue();
        }
    }

    public class SessionLifetimeManager<T> : LifetimeManager, IDisposable
    {

        public override object GetValue()
        {
            return HttpContext.Current.Session[typeof(T).AssemblyQualifiedName];
        }

        public override void RemoveValue()
        {
            HttpContext.Current.Session.Remove(typeof(T).AssemblyQualifiedName);
        }

        public override void SetValue(object newValue)
        {
            HttpContext.Current.Session[typeof(T).AssemblyQualifiedName] = newValue;
        }

        public void Dispose()
        {
            RemoveValue();
        }
    }

    public class SessionLifetimeManager : LifetimeManager, IDisposable
    {
        private string typeName = null;

        public override object GetValue()
        {
            return HttpContext.Current.Session[typeName];
        }

        public override void RemoveValue()
        {
            HttpContext.Current.Session.Remove(typeName);
        }

        public override void SetValue(object newValue)
        {
            typeName = newValue.GetType().AssemblyQualifiedName;
            HttpContext.Current.Session[typeName] = newValue;
        }

        public void Dispose()
        {
            RemoveValue();
        }
    }
}