using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using BusinessLayer.cs;

namespace IOC_DependencyInjuction
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IBusinessLayer, BusinessAccessLayer>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}