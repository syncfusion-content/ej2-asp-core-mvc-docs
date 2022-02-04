using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
namespace sample1.Controllers
{
    public class NodeController : Controller
    {
        // GET: Node
        public ActionResult Node()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            List<UMLProperty> patientProperty = new List<UMLProperty>();
            patientProperty.Add(CreateUMLProperty("accepted", "Date"));

            List<UMLMethods> patientMethods = new List<UMLMethods>();
            patientMethods.Add(CreateUMLMethod("getHistory", "History"));

             nodes.Add(
                new DiagramNode()
                {
                    Id = "Patient",
                    OffsetX = 200,
                    OffsetY = 250,
                    Shape = new UmlClassifierShapeModel()
                    {
                        Type = "UMLClassifier",
                        Interface = new Interface()
                        {
                            Name = "Patient",
                            Attributes = patientProperty,
                            Methods = patientMethods
                        },
                    },
                }
            );
            ViewBag.Nodes =  Nodes
            return View();
        }
         public UMLProperty CreateUMLProperty(string name, string type)
        {
            UMLProperty property = new UMLProperty();
            property.Name = name;
            property.Type = type;
            return property;
        }
        public UMLMethods CreateUMLMethod(string name, string type)
        {
            UMLMethods method = new UMLMethods();
            method.Name = name;
            method.Type = type;
            return method;
        }
    }
     public class UmlClassifierShapeModel
    {
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("class")]
        [JsonProperty("class")]
        public Class Class
        {
            get;
            set;
        }
    }
     public class Interface
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("attributes")]
        [JsonProperty("attributes")]
        public List<UMLProperty> Attributes
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("methods")]
        [JsonProperty("methods")]
        public List<UMLMethods> Methods
        {
            get;
            set;
        }
    }

    public class UMLProperty
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
    public class UMLMethods
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
}