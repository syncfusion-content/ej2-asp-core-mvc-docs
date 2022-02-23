using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
    public partial class DiagramController: Controller {
        public ActionResult Nodes() {
            List < DiagramNode > nodes = new List < DiagramNode > ();
            // A fixed user handle is created and stored in fixed user handle collection of Node.
            List<DiagramNodeFixedUserHandle> handle = new List<DiagramNodeFixedUserHandle>();
            handle.Add(new DiagramNodeFixedUserHandle() { Margin = new DiagramMargin() {Right=20 },Width=20,Height=20, PathData = "M60.3,18H27.5c-3,0-5.5,2.4-5.5,5.5v38.2h5.5V23.5h32.7V18z M68.5,28.9h-30c-3,0-5.5,2.4-5.5,5.5v38.2c0,3,2.4,5.5,5.5,5.5h30c3,0,5.5-2.4,5.5-5.5V34.4C73.9,31.4,71.5,28.9,68.5,28.9z M68.5,72.5h-30V34.4h30V72.5z" });
            nodes.Add(new DiagramNode() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "darkcyan"
                    },
                    OffsetX = 100,
                    OffsetY = 100,
                   FixedUserHandles = handle
            });
            ViewBag.nodes = nodes;
            return View();
        }
    }
   
}