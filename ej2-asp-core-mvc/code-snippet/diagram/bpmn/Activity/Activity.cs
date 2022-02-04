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
                        Activity = BpmnActivities.Task
                    }
                }
            });

            ViewBag.nodes = nodes;

            return View();
        }
        public class BpmnShapes
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
            [HtmlAttributeName("shape")]
            [JsonProperty("shape")]
            public string Shape
            {
                get;
                set;
            }
            [DefaultValue(null)]
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