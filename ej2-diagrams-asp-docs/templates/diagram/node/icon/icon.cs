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
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Node2" });
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
                    ExpandIcon=new DiagramIconShape() { Shape=IconShapes.ArrowDown, Height=10, Width= 10},
CollapseIcon=new DiagramIconShape() { Shape=IconShapes.ArrowUp, Height=10, Width= 10}
            });
 nodes.Add(new Node() { Id = "node2", OffsetX = 100, OffsetY = 300, Annotations = Node2 });
            ViewBag.nodes = nodes;
 List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "node1", TargetID = "node2" });

 ViewBag.Connectors = Connectors;

            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}