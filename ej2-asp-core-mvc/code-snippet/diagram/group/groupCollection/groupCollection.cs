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
             Node1.Add(new DiagramNodeAnnotation() {
                Content = "node1", Style = new DiagramTextStyle() {
                    Color = "White", StrokeColor = "None"
                }
            });
             nodes.addElements(new Node() [{ id: "rectangle1", offsetX: 100, offsetY: 100, width: 100, height: 100, annotations: [{ content: 'node1' }] },
                { id: "rectangle2", offsetX: 200, offsetY: 200, width: 100, height: 100, annotations: [{ content: 'node2' }] },
                { id: 'group', children: ['rectangle1', 'rectangle2'] },
                { id: "rectangle3", offsetX: 400, offsetY: 400, width: 100, height: 100, annotations: [{ content: 'node1' }] },
                { id: "rectangle4", offsetX: 500, offsetY: 500, width: 100, height: 100, annotations: [{ content: 'node2' }] },
                { id: 'group', children: ['rectangle3', 'rectangle4'], padding: { left: 10, right: 10, top: 10, bottom: 10 } }
                ]);
               ViewBag.nodes = nodes;  
            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}