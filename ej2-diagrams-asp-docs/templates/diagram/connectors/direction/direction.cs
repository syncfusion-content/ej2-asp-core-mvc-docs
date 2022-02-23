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
                }, Type = Segments.Orthogonal, Segments = new Segments() {
                    Type = "Orthogonal",
                        Direction = "Bottom",
                        Length = 150
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
            [HtmlAttributeName("direction")]
            [JsonProperty("direction")]
            public string Direction {
                get;
                set;
            }
            [DefaultValue(null)]
            [HtmlAttributeName("length")]
            [JsonProperty("length")]
            public number Length {
                get;
                set;
            }
        }
    }
}