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
            string position = "TopLeft";
            ViewBag.position = position;
            ViewBag.getContent = "getContent";
            return View();
        }
    }
}