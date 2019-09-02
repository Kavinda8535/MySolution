using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using MySolution.MyCompany.Bussiness.Interface;
using MySolution.MyCompany.Bussiness.Service;
using MySolution.MyCompany.Repository.Base.Repository;
using MySolution.MyCompany.Repository.Base.IRepository;

namespace MySolution.MyCompany.WebUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            //container.RegisterType<ITestService, TestService>();
            container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPersonRepository, PersonRepository>();
        }
    }
}