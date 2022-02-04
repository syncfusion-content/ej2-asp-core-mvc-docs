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
            List<DiagramNode> nodes = new List<DiagramNode>();
            DiagramBpmnSubProcess SubProcess = new DiagramBpmnSubProcess();
            SubProcess.Boundary = BpmnBoundary.Call;

            nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Width = 100,
                Height = 100,
                OffsetX = 100,
                OffsetY = 100,
                Shape = new BpmnShapes()
                {
                    Type = "Bpmn",
                    Shape = "Activity",
                    Activity = new DiagramBpmnActivity()
                    {
                        Activity = BpmnActivities.SubProcess,
                        SubProcess = SubProcess
                    }
                }
            });

            ViewBag.nodes = nodes;

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

            [HtmlAttributeName("activity")]
            [JsonProperty("activity")]
            public DiagramBpmnActivity Activity
            {
                get;
                set;
            }
        }
    }
}