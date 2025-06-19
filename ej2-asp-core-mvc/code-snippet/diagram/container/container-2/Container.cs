using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Nodes
        public ActionResult Nodes()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1Annots = new List<DiagramNodeAnnotation>();
            Node1Annots.Add(new DiagramNodeAnnotation()
            {
                Content = "Node 1",
                Style = new DiagramTextStyle() { Color = "white", FontFamily = "Arial" }
            });
            nodes.Add(new Node()
            {
                Id = "node1",
                Width = 100,
                Height = 100,
                text = "node1",
                Margin = new DiagramMargin()
                {
                    Left = 50,
                    Top = 30
                },
                Style = new NodeStyleNodes()
                {
                    Fill = "#357BD2",
                    StrokeColor = "white"
                },
                Annotations = Node1Annots
            });
            List<DiagramNodeAnnotation> Node2Annots = new List<DiagramNodeAnnotation>();
            Node2Annots.Add(new DiagramNodeAnnotation()
            {
                Content = "Node 2",
                Style = new DiagramTextStyle() { Color = "white", FontFamily = "Arial" }
            });
            nodes.Add(new Node()
            {
                Id = "node2",
                Width = 100,
                Height = 100,
                text = "node1",
                Margin = new DiagramMargin()
                {
                    Left = 200,
                    Top = 130
                },
                Style = new NodeStyleNodes()
                {
                    Fill = "357BD2",
                    StrokeColor = "white"
                },
                Annotations = Node2Annots
            });
            // Container Node
            nodes.Add(new Node()
            {
                Id = "container",
                Width = 350,
                Height = 300,
                OffsetX = 250,
                OffsetY = 250,
                Shape = new DiagramShapeStyle()
                {
                    Type = "Container",
                    Header = new DiagramHeader()
                    {
                        Annotation = new DiagramNodeAnnotation()
                        {
                            Content = "Container Title",
                            Style = new DiagramTextStyle()
                            {
                                FontSize = 18,
                                Bold = true,
                                Color = "white",
                            }
                        },
                        Style = new DiagramTextStyle()
                        {
                            Fill = "#3c63ac",
                            StrokeColor = "30518f"
                        }
                    },
                    Children = ["node1", "node2"],
                },
                Style = new NodeStyleNodes()
                {
                    Fill = "white",
                    StrokeColor = "#30518f",
                    StrokeDashArray = "4 4"
                },
            });
            ViewData.nodes = nodes;
            return View();
        }
    }
    public class Node : DiagramNode
    {
        public string text;
    }
}