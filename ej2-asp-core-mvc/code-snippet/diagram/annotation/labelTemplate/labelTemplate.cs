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
            // Sets the Annotation for the Node
            List<DiagramNode> Nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() {
                //Sets the offset for the content
                Content = "Node1",
                Style = new DiagramTextStyle() {
                    Color = "black",
                    Fill = "transparent"
                },
                    //Set an template for Node annotation
                 Template = "<div><input type="button" value="Submit"></div>"
            });

            Nodes.Add(new DefaultNode()
            {
                Id = "Node1",
                OffsetY = 100,
                OffsetX = 100,
                Height = 100,
                Width =100,
                // add the Annotation for the Node
                Annotations = Node1,
            });

             // Sets the Annotation for the Connector
            List<DiagramConnectorAnnotation> Connector1 = new List<DiagramConnectorAnnotation>();
            Connector1.Add(new DiagramConnectorAnnotation() {
                Content = "Connector1",
                // Sets the offset for the content
                Offset = 0,
                //Set an template for Connector annotation
                Template = "<div><input type="button" value="Submit"></div>"
             });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector1",
                SourcePoint = new DiagramPoint() { X = 100, Y = 100 },
                TargetPoint = new DiagramPoint() { X = 200, Y = 200 },
                // add the Annotation for the Connector
                Annotations = Connector1
            });

            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;
            return View();
        }
    }
}