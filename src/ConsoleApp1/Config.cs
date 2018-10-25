using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Config
    {

        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BogusModelGenerator>().As<IModelGenerator>();
            builder.RegisterType<HttpSender>().As<IModelSender>();

            return builder.Build();
        }



    }
}
