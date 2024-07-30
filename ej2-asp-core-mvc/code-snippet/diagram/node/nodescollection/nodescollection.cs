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
            Node1.Add(new DiagramNodeAnnotation() {
                Content = "node1", Style = new DiagramTextStyle() {
                    Color = "White", StrokeColor = "None"
                }
            });
             nodes.Add(new Node() [
             { id: 'node16', offsetX: 35, offsetY: 260 },
             { id: 'node17', offsetX: 140, offsetY: 260 },
             { id: 'node18', offsetX: 240, offsetY: 260 }
             ]);
             ViewBag.nodes = nodes;


            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}