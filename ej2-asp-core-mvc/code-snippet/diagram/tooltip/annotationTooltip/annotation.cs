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
         public ActionResult Node()
        {
            // Create a list for the nodes
            List<DiagramNode> nodes = new List<DiagramNode>
            {
                new DefaultNode
                {
                    Id = "node1",
                    OffsetX = 250, // Center position
                    OffsetY = 150,
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyle
                    {
                        Fill = "#6BA5D7",
                        StrokeColor = "white"
                    },
                    Annotations = new List<DiagramNodeAnnotation>
                    {
                        new DiagramNodeAnnotation
                        {
                            Id = "label1",
                            Content = "Rectangle", // Displayed label on the node
                            Tooltip = new DiagramTooltip
                            {
                                Content = "This is a Rectangle", // Tooltip content
                                Position = TooltipPosition.TopRight, // Tooltip position
                                RelativeMode = RelativeMode.Object // Positioning mode
                            },
                            Constraints = AnnotationConstraints.Tooltip // Enable tooltip
                        }
                    }
                }
            };

          

            ViewBag.nodes = nodes;
         
            return View();
        }
    }
}

