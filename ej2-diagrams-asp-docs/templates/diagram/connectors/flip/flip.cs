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

            List < DiagramConnector > Connectors = new List < DiagramConnector > ();
            Connectors.Add(new DiagramConnector() {
                Id = "connector", SourcePoint = new DiagramPoint() {
                        X = 100, Y = 100
                    }, TargetPoint = new DiagramPoint() {
                        X = 300, Y = 300
                    },flip = FilpDirection.Horizontal,
                    TargetDecorator = new DiagramDecorator() {
                        Shape = DecoratorShapes.OutdentedArrow, Style = new DiagramShapeStyle() {
                            StrokeColor = "Yellow", StrokeWidth = 3
                        }
                    }
            });
            ViewBag.connectors = Connectors;

            return View();
        }
    }
}