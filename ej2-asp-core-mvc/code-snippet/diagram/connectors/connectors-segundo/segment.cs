using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Nodes
        public ActionResult Nodes()
        {

            List<DiagramNode> nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation()
            {
                Content = "node1",
            });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation()
            {
                Content = "node2",
            });
            nodes.Add(new DiagramNode()
            {
                Id = "sourcenode",
                Width = 150,
                Height = 50,
                Style = new NodeStyleNodes()
                {
                    Fill = "#6BA5D7",
                    StrokeColor = "white",
                },
                OffsetX = 350,
                OffsetY = 50,
                Annotations = Node1,
            });
            nodes.Add(new DiagramNode()
            {
                Id = "targetnode",
                Width = 150,
                Height = 50,
                Style = new NodeStyleNodes()
                {
                    Fill = "#6BA5D7",
                    StrokeColor = "white",
                },
                OffsetX = 200,
                OffsetY = 250,
                Annotations = Node2,

            });
            ViewBag.nodes = nodes;
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector1",
                SourceID = "sourcenode",
                TargetID = "targetnode",
                Type = Segments.Orthogonal,
                Segments = new List<ConnectorSegment>
                    {
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Left", Length = 100 },
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Bottom", Length = 100 },
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Right", Length = 100 },
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Bottom", Length = 50 },
                    },
            });
            ViewBag.connectors = Connectors;
            return View();
        }
    }
}

