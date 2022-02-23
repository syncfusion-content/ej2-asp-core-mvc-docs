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
             List<Lane> Lanes = new List<Lane>();
             Lanes.Add(new Lane()
            {
                Id = "stackCanvas1",
                Height = 100,
                Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "Consumer" },
                    Width = 50,
                },                
            });
             List<Phase> Phases = new List<Phase>();
            swimlane.Shape  =  new SwimLane(){
                Type = "SwimLane",
                PhaseSize = 20,
                    Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "ONLINE PURCHASE STATUS" },
                    Height = 50,
                    Orientation = "Horizontal",
                    Style = new DiagramTextStyle() { FontSize = 11 ,fill ="red"}
                },
                Lanes = Lanes,
                Phases = Phases
            };
            nodes.Add(swimlane);
            ViewBag.nodes = nodes;
            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}