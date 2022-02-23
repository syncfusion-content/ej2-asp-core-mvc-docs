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
            List < DiagramPort > ports1 = new List < DiagramPort > ();
            ports1.Add(new CustomPort() {
                Id = "port1", Shape = PortShapes.Circle, Offset = new DiagramPoint() {
                    X = 0, Y = 0.5
                }, Visibility = PortVisibility.Visible
            });
            ports1.Add(new CustomPort() {
                Id = "port2", Shape = PortShapes.Circle, Offset = new DiagramPoint() {
                    X = 1, Y = 0.5
                }, Visibility = PortVisibility.Visible
            });
            ports1.Add(new CustomPort() {
                Id = "port3", Shape = PortShapes.Circle, Offset = new DiagramPoint() {
                    X = 0.5, Y = 1
                }, Visibility = PortVisibility.Visible
            });
            ports1.Add(new CustomPort() {
                Id = "port4", Shape = PortShapes.Circle, Offset = new DiagramPoint() {
                    X = 1, Y = 1
                }, Visibility = PortVisibility.Visible
            });

            List < DiagramNode > nodes = new List < DiagramNode > ();
            nodes.Add(new Node() {
                Id = "node1",
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() {
                        Fill = "#6BA5D7",
                            StrokeColor = "White"
                    },
                    text = "node1",
                    OffsetX = 100,
                    OffsetY = 100,
                    Ports = ports1
            });
            ViewBag.nodes = nodes;


            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}