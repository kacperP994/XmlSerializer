using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using DbUp;


namespace TestProject.Helpers
{
    public class DbMigrator
    {
        public void StartUp(string connectionString)
        {
            var upgrader = DeployChanges.To
                        .SqlDatabase(connectionString)
                        .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                        .LogToConsole()
                        .WithTransaction()
                        .Build();

            var result = upgrader.PerformUpgrade();

        }
    }
}