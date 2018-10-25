using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace TestProject.Models
{
    [XmlRootAttribute("request", Namespace = "")]
    public class RequestModel : IDateModel
    {
        [JsonProperty(PropertyName = "ix")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [XmlElement(ElementName = "ix")]

        public int Index { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        public int? Visits { get; set; }
        public DateTime Date { get; set; }
    }
}