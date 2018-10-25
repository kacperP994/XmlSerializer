using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace ConsoleApp1
{
    public class SendingProgram
    {
        private static IContainer Container;


        static void Main(string[] args)
        {
            Task task = MainAsync(args);
            task.Wait();
        }


        static async Task MainAsync(string[] args)
        {
            Container = Config.GetContainer();

            int num;

            if (args.Count() == 1 && Int32.TryParse(args[0], out num))
            {

                using (var scope = Container.BeginLifetimeScope())
                {
                    var generator = scope.Resolve<IModelGenerator>();
                    var sender = scope.Resolve<IModelSender>();


                    var models = generator.GetRandomRequests(num);
                    await sender.SendModels(models);

                }

            }
        }
    }
}
