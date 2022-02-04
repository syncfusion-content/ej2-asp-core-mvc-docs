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
                }, Type = Segments.Straight, SourceDecorator = new DiagramDecorator() {
                    Shape = DecoratorShapes.Circle, Style = new DiagramShapeStyle() {
                        StrokeColor = "Red", StrokeWidth = 3
                    }
                }, TargetDecorator = new DiagramDecorator() {
                    Shape = DecoratorShapes.Custom,
                    PathData = "M80.5,12.5 C80.5,19.127417 62.59139,24.5 40.5,24.5 C18.40861,24.5 0.5,19.127417 0.5,12.5 C0.5,5.872583 18.40861,0.5 40.5,0.5 C62.59139,0.5 80.5,5.872583 80.5,12.5 z",
                    Style = new DiagramShapeStyle() {
                        StrokeColor = "Red", StrokeWidth = 3, opacity = 0.8
                    }
                }
            });
            Connectors.Add(new DiagramConnector() {
                Id = "connector", SourcePoint = new DiagramPoint() {
                    X = 400, Y = 100
                }, TargetPoint = new DiagramPoint() {
                    X = 600, Y = 300
                }, Type = Segments.Straight, SourceDecorator = new DiagramDecorator() {
                     Shape = DecoratorShapes.IndentedArrow, Style = new DiagramShapeStyle() {
                        StrokeColor = "Blue", StrokeWidth = 3
                    }
                },
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