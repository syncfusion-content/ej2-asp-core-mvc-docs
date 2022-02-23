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
            List<DiagramMargin> margin = new List<DiagramMargin>();
            margin.Add(new DiagramMargin() { Left = 100, Right = 100, Top = 100, Bottom = 100 });
            ViewBag.margin = margin;


            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}