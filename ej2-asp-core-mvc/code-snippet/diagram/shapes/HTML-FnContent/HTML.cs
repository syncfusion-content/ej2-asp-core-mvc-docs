using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
    public partial class DiagramController: Controller {
        private string CreateNodeContent(string nodeId)
        {
            return $"<div style='background:#6BA5D7;height:100%;width:100%;'><button type='button' style='width:100px'>Button</button></div>";
        }

        public ActionResult Nodes()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Width = 100,
                Height = 100,
                OffsetX = 100,
                OffsetY = 100,
                Shape = new DiagramHtml() { Type = Syncfusion.EJ2.Diagrams.Shapes.HTML , content = CreateNodeContent("node1") }
            });
            ViewBag.nodes = nodes;
            return View();
        }
    };
};