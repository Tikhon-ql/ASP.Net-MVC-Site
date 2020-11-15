using Comment.BLL.Utils;
using Ninject;
using Ninject.Web.Mvc;
using SelfWork_1.Utils;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SelfWork_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string commentConnectionString = ConfigurationManager.ConnectionStrings["CommentsContext"].ConnectionString;
            string playerConnectionString = ConfigurationManager.ConnectionStrings["TeamPlayersContext"].ConnectionString;
            IKernel kernel = new StandardKernel(new CommentModule(),new ServiceModule(commentConnectionString,playerConnectionString));
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
