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
            nodes.Add(new Node() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "#6BA5D7",
                            StrokeColor = "White"
                    },
                    text = "node1",
                    OffsetX = 100,
                    OffsetY = 100,
            });
            ViewBag.nodes = nodes;
            DiagramGridlines gridLines = new DiagramGridlines() {
                LineColor = "#e0e0e0", LineDashArray = "2,2"
            };
            ViewBag.gridLines = gridLines;


            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}