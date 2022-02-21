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
            List<DiagramNode> Nodes = new List<DiagramNode>();
             //Create lanes
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
                Children = firstLaneChildren
            });

            Lanes.Add(new Lane()
            {
                Id = "stackCanvas2",
                Height = 100,
                Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "Marketing" },
                    Width = 50,
                },
                Children = secondLaneChildren
            });

            Lanes.Add(new Lane()
            {
                Id = "stackCanvas3",
                Height = 100,
                Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "Sales" },
                    Width = 50,
                },
                Children = thirdLaneChildren
            });

            Lanes.Add(new Lane()
            {
                Id = "stackCanvas4",
                Height = 100,
                Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "Success" },
                    Width = 50,
                },
                Children = fourthLaneChildren
            });

            //Create phases
            List<Phase> Phases = new List<Phase>();
            Phases.Add(new Phase()
            {
                Id = "phase1",
                Offset = 170,
                Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "Phase" },
                },
            });

            swimlane.Shape = new SwimLane()
            {
                Type = "SwimLane",
                PhaseSize = 20,
                Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "SALES PROCESS FLOW CHART" },
                    Height = 50,
                    Orientation = "Horizontal",
                    Style = new DiagramTextStyle() { FontSize = 11 }
                },
                Lanes = Lanes,
                Phases = Phases
            };
            Nodes.Add(swimlane);        
            return View();
        }
    }
    public class Node: DiagramNode {
        public string text;
    }
}