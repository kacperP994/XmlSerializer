using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using TestProject.Db;
using TestProject.Helpers;

namespace TestProject
{
    public static class ContainerHelper
    {

        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); 
            builder.RegisterType<DataBaseContext>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<CustomXMLSerializer>().AsImplementedInterfaces().SingleInstance();

            var container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }



    }
}