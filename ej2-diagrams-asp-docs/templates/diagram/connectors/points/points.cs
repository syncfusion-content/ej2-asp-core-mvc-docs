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
                
            List<point> Stop = new List<vector>();
            Stop.Add(new point() { X = 100, Y = 100 });
            Stop.Add(new point() { X = 200, Y = 200 });

            List < DiagramConnector > Connectors = new List < DiagramConnector > ();
            Connectors.Add(new DiagramConnector() {
                Id = "connector", SourcePoint = new DiagramPoint() {
                    X = 100, Y = 100
                }, TargetPoint = new DiagramPoint() {
                    X = 300, Y = 300
                }, Type = Segments.Besizer, Segments = new Segments() {
                    Type = "Besizer",
                    Vector = Stop
                }
            });
            ViewBag.connectors = Connectors;


            return View();
        }
        public class Segments {
            [DefaultValue(null)]
            [HtmlAttributeName("type")]
            [JsonProperty("type")]
            public string Type {
                get;
                set;
            }
             [DefaultValue(null)]
            [HtmlAttributeName("points")]
            [JsonProperty("points")]
            public List<point> Point {
                get;
                set;
            }
            
        }
      public class point {
            [DefaultValue(null)]
            [HtmlAttributeName("x")]
            [JsonProperty("x")]
            public double X {
                get;
                set;
            }
            [DefaultValue(null)]
            [HtmlAttributeName("y")]
            [JsonProperty("y")]
            public double Y {
                get;
                set;
            }
        }
    }
}