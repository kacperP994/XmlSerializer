using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProject.Db;
using TestProject.Helpers;
using TestProject.Models;

namespace TestProject.Controllers
{
    [RoutePrefix("api/data")]
    public class DataController : ApiController
    {
        private IDbContext _Context;

        public DataController(IDbContext context)
        {
            _Context = context;
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody]List<RequestModel> input)
        {
            HttpStatusCode returnCode = HttpStatusCode.OK;

            if (input.All(x=> x.Index != 0))
            {
                _Context.RequestModels.AddRange(input);
                _Context.SaveChanges();

            }
            else
            {
                returnCode = (HttpStatusCode)400;
            }

            var message = new HttpResponseMessage(returnCode);
            return message;
        }


    }
}
