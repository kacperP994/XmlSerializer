using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TestProject.Models;

namespace TestProject.Helpers
{
    public class StreamProvider
    {
        public StreamProvider()
        {
            BasePath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/");
        }

        private string BasePath;



        private static void EnsureDirectoryExists(string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            if (!info.Directory.Exists)
            {
                Directory.CreateDirectory(info.DirectoryName);
            }
        }


        public StreamWriter ProvideDateBasedPath(DateTime date, string name)
        {
            var dateFormated = date.ToString("yyyy-MM-dd");
            var path = $"{BasePath}xml\\{dateFormated}\\{name}.xml";

            EnsureDirectoryExists(path);
            return new StreamWriter(path, false);
        }


    }
}