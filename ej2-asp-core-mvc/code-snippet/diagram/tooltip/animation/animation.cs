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
            nodes.Add(new DiagramNode() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "#6BA5D7",
                            StrokeColor = "White"
                    },
                    OffsetX = 100,
                    OffsetY = 100,
                    Constraints = NodeConstraints.Default | NodeConstraints.Tooltip,
                    Tooltip = new DiagramDiagramTooltip() { Content = "Nodes", Position = "TopLeft",  RelativeMode= TooltipRelativeMode.Object}
            });
            ViewBag.nodes = nodes;
            string position = "TopLeft";
            ViewBag.position = position;


            return View();
        }
    }
}