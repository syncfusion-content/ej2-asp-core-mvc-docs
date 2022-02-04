using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
    public partial class DiagramController: Controller {
        // GET: Nodes
        public ActionResult Nodes() {

            List < DiagramNode > nodes = new List < DiagramNode > ();
            List < DiagramNodeAnnotation > Node1 = new List < DiagramNodeAnnotation > ();
            Node1.Add(new DiagramNodeAnnotation() {
                Content = "node1", Style = new DiagramTextStyle() {
                    Color = "White", StrokeColor = "None"
                }
            });
            List < DiagramNodeAnnotation > Node2 = new List < DiagramNodeAnnotation > ();
            Node2.Add(new DiagramNodeAnnotation() {
                Content = "node2", Style = new DiagramTextStyle() {
                    Color = "White", StrokeColor = "None"
                }
            });
            List<DiagramPort> ports1 = new List<DiagramPort>();
            ports1.Add(new CustomPort() { Id = "port1", Shape = PortShapes.Circle, Offset = new DiagramPoint() { X = 1, Y = 0.5 }, Visibility = PortVisibility.Visible });
            List<DiagramPort> ports2 = new List<DiagramPort>();
            ports2.Add(new CustomPort() { Id = "port2", Shape = PortShapes.Circle, Offset = new DiagramPoint() { X = 0, Y = 0.5 }, Visibility = PortVisibility.Visible });
            nodes.Add(new DiagramNode() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 100,
                    OffsetY = 100,
                    Annotations = Node1,
                    Ports = ports1
            });
           nodes.Add(new DiagramNode() {
                Id = "node2",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 300,
                    OffsetY = 300,
                    Annotations = Node2,
                    Ports = port2
            });
            ViewBag.nodes = nodes;

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector", SourceID="node1", TargetID="node2", SourcePortID = "port1", TargetPortID = "port2"  });
            ViewBag.connectors = Connectors;


            return View();
        }
    }
}