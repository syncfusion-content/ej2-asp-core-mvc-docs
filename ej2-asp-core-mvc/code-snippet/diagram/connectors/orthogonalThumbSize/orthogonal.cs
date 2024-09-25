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
            // Create nodes
            List<DiagramNode> nodes = new List<DiagramNode>
            {
                new DiagramNode { Id = "node1", Width = 100, Height = 100, OffsetX = 200, OffsetY = 200 },
                new DiagramNode { Id = "node2", Width = 100, Height = 100, OffsetX = 400, OffsetY = 400 },
                new DiagramNode { Id = "node3", Width = 100, Height = 100, OffsetX = 600, OffsetY = 200 },
                new DiagramNode { Id = "node4", Width = 100, Height = 100, OffsetX = 800, OffsetY = 400 }
            };

            ViewBag.Nodes = nodes;

            // Create connectors
            List<DiagramConnector> connectors = new List<DiagramConnector>
            {
                new DiagramConnector
                {
                    Id = "connector1",
                    SourceID = "node1",
                    TargetID = "node2",
                    Type = Segments.Orthogonal,
                    Segments = new List<ConnectorSegment>
                    {
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Right", Length = 70 },
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Bottom", Length = 50 }
                    },
                    Constraints = ConnectorConstraints.Default | ConnectorConstraints.DragSegmentThumb
                },
                new DiagramConnector
                {
                    Id = "connector2",
                    SourceID = "node3",
                    TargetID = "node4",
                    Type = Segments.Orthogonal,
                    Segments = new List<ConnectorSegment>
                    {
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Right", Length = 70 },
                        new ConnectorSegment { Type = Segments.Orthogonal, Direction = "Bottom", Length = 50 }
                    },
                    Constraints = ConnectorConstraints.Default & ~(ConnectorConstraints.InheritSegmentThumbSize) | ConnectorConstraints.DragSegmentThumb,
                    SegmentThumbSize = 20
                }
            };

            ViewBag.Connectors = connectors;

            return View();
        }
    }
}