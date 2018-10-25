using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Serialization;
using TestProject.Db;
using TestProject.Helpers;
using TestProject.Models;


namespace TestProject.Controllers
{
    [RoutePrefix("api/jobs")]
    public class JobsController : ApiController
    {
        private ISerializer _Serializer;
        private IDbContext _Context;

        public JobsController(IDbContext context, ISerializer serializer)
        {
            _Serializer = serializer;
            _Context = context;
        }


        [HttpGet]
        [Route("saveFiles")]
        public void SaveFiles()
        {
            _Serializer.Serialize(_Context.RequestModels);
        }


    }
}
