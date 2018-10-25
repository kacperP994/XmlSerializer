using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using TestProject.Models;

namespace TestProject.Models
{
    [XmlRootAttribute("request", Namespace = "")]
    public class RequestModelForXML
    {
        public int ix { get; set; }

        public RequestModelContent content { get; set; }

        public RequestModelForXML()
        {

        }

        public RequestModelForXML(RequestModel model)
        {
            ix = model.Index;

            content = new RequestModelContent
            {
                name = model.Name,
                visits = model.Visits,
                dateRequested = model.Date.ToString("yyyy-MM-dd")
            };
        }

    }

    
    public class RequestModelContent
    {
        public string name { get; set; }

        public int? visits { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool visitsSpecified { get { return this.visits != null; } }

        public string dateRequested { get; set; }
    }

}