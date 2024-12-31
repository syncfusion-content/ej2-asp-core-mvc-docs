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
            // Define nodes
            List<DiagramNode> nodes = new List<DiagramNode>
            {
                new DiagramNode
                {
                    Id = "node1",
                    OffsetX = 250,
                    OffsetY = 250,
                    Width = 100,
                    Height = 100,
                    Style = new DiagramShapeStyle { Fill = "#6BA5D7", StrokeColor = "White" },
                    Annotations = new List<DiagramNodeAnnotation>
                    {
                        new DiagramNodeAnnotation
                        {
                            Content = "Node",
                            Style = new DiagramTextStyle { Color = "White", StrokeColor = "None" }
                        }
                    }
                }
            };

            // Assign nodes to ViewBag
            ViewBag.nodes = nodes;

            // Script for client-side logic
            ViewBag.Script = @"
                document.addEventListener('DOMContentLoaded', function () {
                    var diagram = document.getElementById('diagram').ej2_instances[0];

                    // Undo/Redo button event handlers
                    document.getElementById('undo').addEventListener('click', function () {
                        diagram.undo();
                    });
                    document.getElementById('redo').addEventListener('click', function () {
                        diagram.redo();
                    });

                    // Enable/Disable Undo and Redo buttons based on history state
                    diagram.historyChange = function (args) {
                        document.getElementById('undo').disabled = !diagram.historyManager.canUndo;
                        document.getElementById('redo').disabled = !diagram.historyManager.canRedo;
                    };
                });
            ";

            return View();
        }
    }
}