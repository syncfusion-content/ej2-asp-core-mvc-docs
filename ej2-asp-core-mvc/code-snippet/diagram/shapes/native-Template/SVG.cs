using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
    public partial class DiagramController : Controller {
        public ActionResult Nodes() {
            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode() {
                Id = "node1",
                Width = 100,
                Height = 100,
                OffsetX = 100,
                OffsetY = 100,
                Shape = new DiagramNative() { Type = Syncfusion.EJ2.Diagrams.Shapes.Native, Scale = Stretch.Stretch }
            });
            ViewBag.nodes = nodes;
            return View();
        }
    };
};
