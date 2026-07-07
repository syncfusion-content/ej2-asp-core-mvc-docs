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
                OffsetX = 300,
                OffsetY = 300,
                Style = new NodeStyleNodes() {
                    Fill = "#ffffff",
                    StrokeColor = "#2E75B6",
                    StrokeWidth = 1
                },
                Shape = new EREntityShapeModel() {
                    Type = "Er",
                    Header = new ERHeader() {
                        Annotation = new DiagramNodeAnnotation() {
                            Content = "CUSTOMER TABLE",
                            Style = new DiagramTextStyle() {
                                Bold = true,
                                Color = "white"
                            }
                        },
                        Height = 35,
                        Style = new DiagramShapeStyle() {
                            Fill = "#2E75B6",
                            Bold = true,
                            Color = "white",
                            FontSize = 12
                        }
                    },
                    Fields = new List<ERField>() {
                        new ERField() {
                            Id = "cust_id",
                            Name = "CustomerID",
                            DataType = "INT",
                            IsPrimaryKey = true
                        },
                        new ERField() {
                            Id = "cust_firstname",
                            Name = "FirstName",
                            DataType = "VARCHAR(50)"
                        },
                        new ERField() {
                            Id = "cust_email",
                            Name = "Email",
                            DataType = "VARCHAR(100)"
                        }
                    },
                    FieldDefaults = new ERFieldDefaults() {
                        AlternateRowColors = new List<string>() { "#ffffff", "#E7F0F7" }
                    }
                }
            });

            nodes.Add(new DiagramNode() {
                Id = "Product",
                OffsetX = 600,
                OffsetY = 200,
                Style = new NodeStyleNodes() {
                    Fill = "#ffffff",
                    StrokeColor = "#70AD47",
                    StrokeWidth = 1.5
                },
                Shape = new EREntityShapeModel() {
                    Type = "Er",
                    Header = new ERHeader() {
                        Annotation = new DiagramNodeAnnotation() {
                            Content = "PRODUCT CATALOG",
                            Style = new DiagramTextStyle() {
                                Bold = true,
                                Color = "white"
                            }
                        },
                        Height = 35,
                        Style = new DiagramShapeStyle() {
                            Fill = "#70AD47",
                            Bold = true,
                            Color = "white",
                            FontSize = 12
                        }
                    },
                    Fields = new List<ERField>() {
                        new ERField() {
                            Id = "prod_id",
                            Name = "ProductID",
                            DataType = "INT",
                            IsPrimaryKey = true,
                            Style = new DiagramShapeStyle() { Fill = "#FFE699" }
                        },
                        new ERField() {
                            Id = "prod_name",
                            Name = "ProductName",
                            DataType = "VARCHAR(150)"
                        },
                        new ERField() {
                            Id = "prod_price",
                            Name = "Price",
                            DataType = "DECIMAL(10,2)",
                            Style = new DiagramShapeStyle() { Fill = "#C6E0B4" }
                        }
                    },
                    FieldDefaults = new ERFieldDefaults() {
                        AlternateRowColors = new List<string>() { "#ffffff", "#F2F2F2" }
                    }
                }
            });

            ViewBag.nodes = nodes;
            return View();
        }
    }
}