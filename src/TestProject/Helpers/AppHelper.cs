using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace TestProject.Helpers
{
    public static class AppHelper
    {

        public static string GetConnectionString()
        {
            return WebConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
        }

    }
}