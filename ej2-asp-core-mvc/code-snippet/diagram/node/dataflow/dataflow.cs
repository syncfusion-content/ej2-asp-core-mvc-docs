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
                Content = "Node2"
            });
            List < DiagramNodeAnnotation > Node3 = new List < DiagramNodeAnnotation > ();
            Node3.Add(new DiagramNodeAnnotation() {
                Content = "Node3"
            });
            List < DiagramNodeAnnotation > Node4 = new List < DiagramNodeAnnotation > ();
            Node4.Add(new DiagramNodeAnnotation() {
                Content = "Node4"
            });
            nodes.Add(new Node() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        fill = "#6BA5D7",
                            strokeColor = "White"
                    },
                    text = "node1",
                    OffsetX = 100,
                    OffsetY = 100,
                    Annotations = Node1,
            });
            nodes.Add(new Node() {
                Id = "node2", OffsetX = 100, OffsetY = 300, Annotations = Node2
            });
            nodes.Add(new Node() {
                Id = "node3", OffsetX = 100, OffsetY = 300, Annotations = Node3
            });
            nodes.Add(new Node() {
                Id = "node4", OffsetX = 100, OffsetY = 300, Annotations = Node4
            });
            ViewBag.nodes = nodes;
            List < DiagramConnector > Connectors = new List < DiagramConnector > ();
            Connectors.Add(new DiagramConnector() {
                Id = "connector1", SourceID = "node1", TargetID = "node2"
            });
            Connectors.Add(new DiagramConnector() {
                Id = "connector2", SourceID = "node1", TargetID = "node3"
            });
            Connectors.Add(new DiagramConnector() {
                Id = "connector3", SourceID = "node1", TargetID = "node4"
            });

            ViewBag.Connectors = Connectors;

            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}