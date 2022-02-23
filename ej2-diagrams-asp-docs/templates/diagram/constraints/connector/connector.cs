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
            List < DiagramConnector > connectors = new List < DiagramConnector > ();
            connectors.Add(new DiagramConnector() {
                Id = "connector1",
                    SourcePoint = new DiagramPoint() { X = 100, Y = 100},
                    TargetPoint = new DiagramPoint() { X = 300, Y = 200},
                    Type = Segments.Orthogonal,
                   // Set constraints for the connector
                    constraints = ConnectorConstraints.Default & ~ConnectorConstraints.Select
            });
            ViewBag.Connectors = connectors;


            return View();
        }
    }
}