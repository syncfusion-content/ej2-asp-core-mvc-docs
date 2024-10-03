using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
    public partial class DiagramController: Controller {
        public ActionResult Nodes() {
              List<DiagramNode> nodes = new List<DiagramNode>
            {
                new DiagramNode
                {
                    Id = "node1",
                    OffsetX = 250,
                    OffsetY = 250,
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyle { Fill = "#6BA5D7", StrokeColor = "white" },
                    FixedUserHandles = new List<DiagramNodeFixedUserHandle>
                    {
                        new DiagramNodeFixedUserHandle
                        {
                            Offset = new { x = 0, y = 0 },
                            Margin = new { right = 20 },
                            Width = 50,
                            Height = 20,
                            Id = "usercon1"
                        }
                    }
                }
            };

            // Create connectors
            List<DiagramConnector> connectors = new List<DiagramConnector>
            {
                new DiagramConnector
                {
                    Id = "connector1",
                    Style = new ConnectorStyle
                    {
                        StrokeColor = "#6BA5D7",
                        Fill = "#6BA5D7",
                        StrokeWidth = 2
                    },
                    TargetDecorator = new Decorator
                    {
                        Style = new DecoratorStyle
                        {
                            Fill = "#6BA5D7",
                            StrokeColor = "#6BA5D7"
                        }
                    },
                    SourcePoint = new DiagramPoint { X = 400, Y = 200 },
                    TargetPoint = new DiagramPoint { X = 500, Y = 300 },
                    Type = Segments.Orthogonal,
                    FixedUserHandles = new List<DiagramConnectorFixedUserHandle>
                    {
                        new DiagramConnectorFixedUserHandle
                        {
                            Offset = 0.5,
                            Width = 120,
                            Alignment = "Before",
                            Height = 20,
                            Id = "usercon2",
                            Displacement = new { x = 10, y = 10 }
                        }
                    }
                }
            };

            ViewBag.Nodes = nodes;
            ViewBag.Connectors = connectors;

            return View();
        }
    }
}
    

