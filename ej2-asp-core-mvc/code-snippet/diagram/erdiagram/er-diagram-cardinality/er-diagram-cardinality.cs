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
            List<DiagramNode> nodes = new List<DiagramNode>();

            nodes.Add(new DiagramNode() {
                Id = "Customer",
                OffsetX = 250,
                OffsetY = 100,
                Shape = new EREntityShapeModel() {
                    Type = "Er",
                    Header = new ERHeader() {
                        Annotation = new DiagramNodeAnnotation() { Content = "Customer" }
                    },
                    Fields = new List<ERField>() {
                        new ERField() {
                            Id = "customer_id",
                            Name = "CustomerID",
                            DataType = "INT",
                            IsPrimaryKey = true
                        }
                    }
                },
                Style = new NodeStyleNodes() {
                    Fill = "#ffffff",
                    StrokeColor = "#7c3aed",
                    StrokeWidth = 1.5
                }
            });

            nodes.Add(new DiagramNode() {
                Id = "Order",
                OffsetX = 400,
                OffsetY = 250,
                Shape = new EREntityShapeModel() {
                    Type = "Er",
                    Header = new ERHeader() {
                        Annotation = new DiagramNodeAnnotation() { Content = "Order" }
                    },
                    Fields = new List<ERField>() {
                        new ERField() {
                            Id = "order_id",
                            Name = "OrderID",
                            DataType = "INT",
                            IsPrimaryKey = true
                        },
                        new ERField() {
                            Id = "customer_id_fk",
                            Name = "CustomerID",
                            DataType = "INT",
                            IsForeignKey = true
                        }
                    }
                },
                Style = new NodeStyleNodes() {
                    Fill = "#ffffff",
                    StrokeColor = "#7c3aed",
                    StrokeWidth = 1.5
                }
            });

            ViewBag.nodes = nodes;

            List<DiagramConnector> connectors = new List<DiagramConnector>();
            connectors.Add(new DiagramConnector() {
                Id = "customer_order",
                SourceID = "Customer",
                TargetID = "Order",
                Shape = new ERConnectorShapeModel() {
                    Type = "Er",
                    SourceMultiplicity = new ERMultiplicity() { Type = "One" },
                    TargetMultiplicity = new ERMultiplicity() { Type = "ZeroOrMany" }
                },
                Style = new DiagramShapeStyle() {
                    StrokeColor = "#7c3aed",
                    StrokeWidth = 1.5
                },
                Type = Segments.Orthogonal,
                SourceDecorator = new DiagramDecorator() {
                    Style = new DiagramShapeStyle() {
                        StrokeColor = '#7c3aed', StrokeWidth = 1.5
                    }
                },
                TargetDecorator = new DiagramDecorator() {
                    Style = new DiagramShapeStyle() {
                        StrokeColor = '#7c3aed', StrokeWidth = 1.5
                    }
                },
                CornerRadius = 10
            });

            ViewBag.Connectors = connectors;

            return View();
        }
    }
}