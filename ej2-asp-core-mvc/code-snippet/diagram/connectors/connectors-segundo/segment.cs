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
        public ActionResult Nodes()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> annotation1 = new List<DiagramNodeAnnotation>();
            annotation1.Add(new DiagramNodeAnnotation()
            {
                Content = "node1",
            });
            List<DiagramNodeAnnotation> annotation2 = new List<DiagramNodeAnnotation>();
            annotation2.Add(new DiagramNodeAnnotation()
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
                Annotations = annotation1,
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
                Annotations = annotation2,
            });
            ViewBag.nodes = nodes;
            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector()
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
            ViewBag.connectors = connectors;
            return View();
        }
    }
}