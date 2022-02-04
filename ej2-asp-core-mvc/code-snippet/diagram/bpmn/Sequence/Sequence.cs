using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.ComponentModel;
using Syncfusion.EJ2;
using Newtonsoft.Json;

namespace sample1.Controllers
{
    public class NodeController : Controller
    {
        // GET: Node
        public ActionResult Node()
        {
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector1",
                SourcePoint = new DiagramPoint() { X=100,Y=100},
                TargetPoint = new DiagramPoint() { X = 200, Y = 200 },
                Type= Segments.Orthogonal,
                Shape=new BpmnShapes()
                {
                    Type="Bpmn",
                    Flow= "Sequence",
                    Sequence = "Conditional"

                }
            });
            ViewBag.connectors = Connectors;

            return View();
        }
        public class BpmnShapes
        {

            [HtmlAttributeName("type")]
            [JsonProperty("type")]
            public string Type
            {
                get;
                set;
            }

            [HtmlAttributeName("shape")]
            [JsonProperty("shape")]
            public string Shape
            {
                get;
                set;
            }

            [HtmlAttributeName("flow")]
            [JsonProperty("flow")]
            public string Flow
            {
                get;
                set;
            }

            [HtmlAttributeName("sequence")]
            [JsonProperty("sequence")]
            public string Sequence
            {
                get;
                set;
            }
        }
    }
}