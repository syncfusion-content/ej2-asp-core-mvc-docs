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
                OffsetY = 200,
                Shape = new EREntityShapeModel() {
                    Type = "Er",
                    Header = new ERHeader() {
                        Annotation = new DiagramNodeAnnotation() {
                            Content = "CUSTOMER TABLE",
                            Style = new DiagramTextStyle() {
                                Color = "white",
                                FontSize = 13,
                                Bold = true,
                                FontFamily = "Arial"
                            }
                        },
                        Height = 35,
                        Style = new DiagramShapeStyle() {
                            Fill = "#2E75B6"
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
                            Id = "cust_name",
                            Name = "FirstName",
                            DataType = "VARCHAR(50)"
                        },
                        new ERField() {
                            Id = "cust_email",
                            Name = "Email",
                            DataType = "VARCHAR(100)"
                        }
                    }
                }
            });

            ViewBag.nodes = nodes;
            return View();
        }
    }
}