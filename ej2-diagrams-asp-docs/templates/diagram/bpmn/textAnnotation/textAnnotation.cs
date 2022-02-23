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
            DiagramBpmnDataObject dataObject = new DiagramBpmnDataObject();
            dataObject.Collection = true;
            dataObject.Type = BpmnDataObjects.Input;

            List<DiagramBpmnAnnotation> annotation = new List<DiagramBpmnAnnotation>();
            DiagramBpmnAnnotation label = new DiagramBpmnAnnotation();
            label.Angle = 45;
            label.Length = 150;
            label.Text = "Left";
            label.Id = "left";
            annotation.Add(label);

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
                    Shape = "DataObject",
                    DataObject = dataObject,
                    Annotations = annotation
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

            [HtmlAttributeName("annotations")]
            [JsonProperty("annotations")]
            public List<DiagramBpmnAnnotation> Annotations
            {
                get;
                set;
            }

            [HtmlAttributeName("dataObject")]
            [JsonProperty("dataObject")]
            public DiagramBpmnDataObject DataObject
            {
                get;
                set;
            }
        }
    }
}