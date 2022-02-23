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
            nodes.Add(new DiagramNode() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    OffsetX = 100,
                    OffsetY = 100,
            });
            ViewBag.nodes = nodes;
            return View();
        }
    }
}