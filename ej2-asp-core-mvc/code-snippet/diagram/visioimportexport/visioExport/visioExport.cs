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
        public ActionResult Nodes()
        {
            var nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode()
            {
                Id = "Start",
                Width = 100,
                Height = 100,
                OffsetX = 300,
                OffsetY = 200,
                Annotations = new List<DiagramNodeAnnotation>()
                {
                    new DiagramNodeAnnotation() { Content = "Start" }
                },
                Ports = new List<DiagramPort>()
                {
                    new DiagramPort()
                    {
                        Id = "port1",
                        Offset = new DiagramPoint() { X = 1, Y = 0.5 }
                    }
                },
                Style = new NodeStyleNodes() { Fill = "#2AA8D9", StrokeColor = "grey" }
            });

            nodes.Add(new DiagramNode()
            {
                Id = "End",
                Width = 100,
                Height = 100,
                OffsetX = 600,
                OffsetY = 200,
                Annotations = new List<DiagramNodeAnnotation>()
                {
                    new DiagramNodeAnnotation() { Content = "End" }
                },
                Style = new NodeStyleNodes() { Fill = "#2AA8D9", StrokeColor = "grey" }
            });

            // Create connectors similar to your JS sample
            var connectors = new List<DiagramConnector>();

            connectors.Add(new DiagramConnector()
            {
                Id = "connector1",
                SourceID = "Start",
                SourcePortID = "port1",
                TargetID = "End",
                Annotations = new List<DiagramConnectorAnnotation>()
                {
                    new DiagramConnectorAnnotation()
                    {
                        Content = "Connect",
                        Alignment = AnnotationAlignment.Before,
                        Displacement = new DiagramPoint() { X = 0, Y = 15 }
                    }
                }
            });

            // Put the data into ViewBag to be consumed by the Razor view
            ViewBag.nodes = nodes;
            ViewBag.connectors = connectors;

            return View();
        }
    }
}