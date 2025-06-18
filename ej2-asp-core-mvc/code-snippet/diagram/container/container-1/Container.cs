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
            List<DiagramNodeAnnotation> Node1Annots = new List<DiagramNodeAnnotation>();
            Node1Annots.Add(new DiagramNodeAnnotation() { 
                Content = "Node 1", 
                Style = new DiagramTextStyle() { Color = "#343434" } 
            });
            nodes.Add(new Node() {
                Id = "node1",
                Width = 100,
                Height = 100,
                text = "node1",
                Margin = new DiagramMargin() {
                    Left = 50, Top = 30
                },
                Shape = new DiagramShapeStyle(){
                    Type = "Basic",
                    Shape = "Rectangle",
                    CornerRadius = 4
                },
                Style = new NodeStyleNodes() {
                    Fill = "white", StrokeColor = "#2546BB", StrokeWidth = 1
                },
                Annotations = Node1Annots
            });
            List<DiagramNodeAnnotation> Node2Annots = new List<DiagramNodeAnnotation>();
            Node2Annots.Add(new DiagramNodeAnnotation() { 
                Content = "Node 2",
                 Style = new DiagramTextStyle() { Color = "#343434" } 
            });
            nodes.Add(new Node() {
                Id = "node2",
                Width = 100,
                Height = 100,
                text = "node1",
                Margin = new DiagramMargin() {
                    Left = 200, Top = 130
                },
                Shape = new DiagramShapeStyle(){
                    Type = "Basic",
                    Shape = "Rectangle",
                    CornerRadius = 4
                },
                Style = new NodeStyleNodes() {
                    Fill = "white", StrokeColor = "#2546BB", StrokeWidth = 1
                },
                Annotations = Node2Annots
            });
            // Container Node
            nodes.Add(new Node() {
                Id = "container",
                Width = 350,
                Height = 280,
                OffsetX = 250,
                OffsetY = 250,
                Shape = new DiagramShapeStyle(){
                    Type = "Container",
                    Children = ["node1", "node2"]
                },
                Style = new NodeStyleNodes() {
                    Fill = "#E9EEFF", StrokeColor = "#2546BB", StrokeWidth = 1
                },
            });
            ViewBag.nodes = nodes;
            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}