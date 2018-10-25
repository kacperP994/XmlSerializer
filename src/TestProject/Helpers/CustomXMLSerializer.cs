using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using TestProject.Models;


namespace TestProject.Helpers
{
    public class CustomXMLSerializer : ISerializer
    {
        public void Serialize(IEnumerable<RequestModel> items)
        {
            var serializer = new XmlSerializer(typeof(RequestModelForXML));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var provider = new StreamProvider();

            foreach (var item in items)
            {
                var stream = provider.ProvideDateBasedPath(item.Date, item.Index.ToString());

                serializer.Serialize(stream, new RequestModelForXML(item), ns);
            }
           
        }
    }
}