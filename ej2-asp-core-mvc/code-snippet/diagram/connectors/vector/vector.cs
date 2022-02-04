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
                
            List<vector> Stop = new List<vector>();
            Stop.Add(new vector() { Distance = 100,  Angle = 90 });
            Stop.Add(new vector() { Distance = 90, Angle = 270 });

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
            [HtmlAttributeName("vectors")]
            [JsonProperty("vectors")]
            public List<vector> Vector {
                get;
                set;
            }
            
        }
      public class vector {
            [DefaultValue(null)]
            [HtmlAttributeName("distance")]
            [JsonProperty("distance")]
            public number Distance {
                get;
                set;
            }
            [DefaultValue(null)]
            [HtmlAttributeName("angle")]
            [JsonProperty("angle")]
            public number Angle {
                get;
                set;
            }
        }
    }
}