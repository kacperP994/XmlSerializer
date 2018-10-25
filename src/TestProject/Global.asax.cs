using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using TestProject.Helpers;

namespace TestProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            new DbMigrator().StartUp(AppHelper.GetConnectionString());

            ContainerHelper.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
