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
            nodes.Add(new DiagramNode() {
                Id = "node1",
                    Width = 150,
                    Height = 60,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 300,
                    OffsetY = 60,
                    Annotations = Node1
            });
            nodes.Add(new DiagramNode() {
                Id = "node2",
                    Width = 150,
                    Height = 60,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 300,
                    OffsetY = 250,
                    Annotations = Node2
            });
            ViewBag.nodes = nodes;

            List < DiagramConnector > Connectors = new List < DiagramConnector > ();
            Connectors.Add(new DiagramConnector() {
                Id = "connector", SourceID = "node1", TargetID = "node2", Type = Segments.Straight
            });
            Connectors.Add(new DiagramConnector() {
                Id = "connector", SourcePoint = new DiagramPoint() {
                    X = 200, Y = 130
                }, TargetPoint = new DiagramPoint() {
                    X = 400, Y = 130
                }, Type = Segments.Straight
            });
            Connectors.Add(new DiagramConnector() {
                Id = "connector", SourcePoint = new DiagramPoint() {
                    X = 200, Y = 170
                }, TargetPoint = new DiagramPoint() {
                    X = 400, Y = 170
                }, Type = Segments.Straight
            });
            ViewBag.connectors = Connectors;


            return View();
        }
    }
}