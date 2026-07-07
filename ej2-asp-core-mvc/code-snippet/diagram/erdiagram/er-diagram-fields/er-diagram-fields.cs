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
                Id = "Product",
                OffsetX = 300,
                OffsetY = 200,
                Shape = new EREntityShapeModel() {
                    Type = "Er",
                    Header = new ERHeader() {
                        Annotation = new DiagramNodeAnnotation() { Content = "Product" }
                    },
                    Fields = new List<ERField>() {
                        new ERField() {
                            Id = "prod_id",
                            Name = "ProductID",
                            DataType = "INT",
                            IsPrimaryKey = true,
                            Constraints = new List<string>() { "NotNull" }
                        },
                        new ERField() {
                            Id = "prod_code",
                            Name = "ProductCode",
                            DataType = "VARCHAR(50)",
                            Constraints = new List<string>() { "NotNull", "Unique" }
                        },
                        new ERField() {
                            Id = "prod_name",
                            Name = "ProductName",
                            DataType = "VARCHAR(150)",
                            Constraints = new List<string>() { "NotNull" }
                        },
                        new ERField() {
                            Id = "prod_price",
                            Name = "Price",
                            DataType = "DECIMAL(10,2)",
                            Constraints = new List<string>() { "NotNull" }
                        },
                        new ERField() {
                            Id = "prod_desc",
                            Name = "Description",
                            DataType = "TEXT"
                        },
                        new ERField() {
                            Id = "prod_catid",
                            Name = "CategoryID",
                            DataType = "INT",
                            IsForeignKey = true
                        }
                    }
                }
            });

            ViewBag.nodes = nodes;
            return View();
        }
    }
}