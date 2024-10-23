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
         // Create nodes
            List<DiagramNode> nodes = new List<DiagramNode>
            {
                new DiagramNode { Id = "node1", Width = 100, Height = 100, OffsetX = 150, OffsetY = 150 },
                new DiagramNode { Id = "node2", Width = 100, Height = 100, OffsetX = 350, OffsetY = 400 },
                new DiagramNode { Id = "node3", Width = 100, Height = 100, OffsetX = 550, OffsetY = 150 },
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
                    Type = Segments.Bezier,
                    Segments = new List<ConnectorSegment>
                    {
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 200, Y = 300 } },
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 320, Y = 400 } }
                    },
                    Constraints = ConnectorConstraints.Default | ConnectorConstraints.DragSegmentThumb
                },
                new DiagramConnector
                {
                    Id = "connector2",
                    SourceID = "node3",
                    TargetID = "node4",
                    Type = Segments.Bezier,
                    Segments = new List<ConnectorSegment>
                    {
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 600, Y = 300 } },
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 320, Y = 400 } }
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



using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace YourNamespace.Controllers
{
    public partial class DiagramController : Controller
    {
        public ActionResult Nodes()
        {
            // Create nodes
            List<DiagramNode> nodes = new List<DiagramNode>
            {
                new DiagramNode { Id = "node1", Width = 100, Height = 100, OffsetX = 150, OffsetY = 150 },
                new DiagramNode { Id = "node2", Width = 100, Height = 100, OffsetX = 350, OffsetY = 400 },
                new DiagramNode { Id = "node3", Width = 100, Height = 100, OffsetX = 550, OffsetY = 150 },
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
                    Type = Segments.Bezier,
                    Segments = new List<ConnectorSegment>
                    {
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 200, Y = 300 } },
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 320, Y = 400 } }
                    },
                    Constraints = ConnectorConstraints.Default | ConnectorConstraints.DragSegmentThumb
                },
                new DiagramConnector
                {
                    Id = "connector2",
                    SourceID = "node3",
                    TargetID = "node4",
                    Type = Segments.Bezier,
                    Segments = new List<ConnectorSegment>
                    {
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 600, Y = 300 } },
                        new ConnectorSegment { Type = Segments.Bezier, Point = new DiagramPoint { X = 320, Y = 400 } }
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
