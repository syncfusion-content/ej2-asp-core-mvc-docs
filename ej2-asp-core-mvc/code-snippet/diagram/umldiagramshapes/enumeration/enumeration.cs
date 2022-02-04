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

            List<UMLMembers> patientMembers = new List<UMLMembers>();
            patientMembers.Add(CreateUMLMembers("Checking Account"));
            patientMembers.Add(CreateUMLMembers("Savings Account"));
            patientMembers.Add(CreateUMLMembers("Credit Account"));

             nodes.Add(
                new DiagramNode()
                {
                    Id = "Patient",
                    OffsetX = 200,
                    OffsetY = 250,
                    Shape = new UmlClassifierShapeModel()
                    {
                        Type = "UMLClassifier",
                        Enumeration = new Enumeration()
                        {
                            Name = "AccountType",
                            Members = patientMembers
                        },
                    },
                }
            );
            ViewBag.Nodes =  Nodes
            return View();
        }

        public UMLMembers CreateUMLMembers(string name)
        {
            UMLMembers members = new UMLMembers();
            members.Name = name;
            return members;
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
     public class Enumeration
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
        [HtmlAttributeName("members")]
        [JsonProperty("members")]
        public List<UMLMembers> Members
        {
            get;
            set;
        }
    }

    public class UMLMembers
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}