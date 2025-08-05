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
            List < DiagramNodeAnnotation > Node3 = new List < DiagramNodeAnnotation > ();
            Node3.Add(new DiagramNodeAnnotation() {
                Content = "node3", Style = new DiagramTextStyle() {
                    Color = "White", StrokeColor = "None"
                }
            });
             nodes.Add(new DiagramNode() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 150,
                    OffsetY = 150,
                    Annotations = Node1
            });
            nodes.Add(new DiagramNode() {
                Id = "node2",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 650,
                    OffsetY = 150,
                    Annotations = Node2
            });
            nodes.Add(new DiagramNode() {
                Id = "node3",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 490,
                    OffsetY = 290,
                    Annotations = Node3
            });
            ViewBag.nodes = nodes;

            List < DiagramConnector > Connectors = new List < DiagramConnector > ();
            Connectors.Add(new DiagramConnector() {
                Id = "connector", SourceID = "node1", TargetID = "node2", Type = Segments.Straight,
                Constraints = ConnectorConstraints.Default & ~ConnectorConstraints.AllowDrop
            });
            return View();
        }
    }
}