using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;
using System.Net.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Net;

namespace ConsoleApp1
{
    public class HttpSender : IModelSender
    {
        public HttpSender()
        {
            Client = new HttpClient();
        }

        private HttpClient Client;


        public async Task<bool> SendModels(IEnumerable<RequestModel> models)
        {
            string address = ConfigurationManager.AppSettings["httpAddress"];
            var serializedObject = JsonConvert.SerializeObject(models);

            var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");

            var response = await Client.PostAsync(address, content);
            var result = response.StatusCode == HttpStatusCode.OK;


            Console.Write(result ? "Wysłano poprawnie" : "Błąd podczas wysyłania");

            return result;
         }


        }
    }
}
