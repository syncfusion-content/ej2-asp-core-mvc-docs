using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public ActionResult AutoPort()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new Node()
            {
                Id = "node1",
                Width = 100,
                Height = 100,
                Style = new NodeStyleNodes()
                {
                    Fill = "cornflowerblue",
                },
                text = "node1",
                OffsetX = 150,
                OffsetY = 200,
                Constraints = NodeConstraints.Default & ~(NodeConstraints.InConnect | NodeConstraints.OutConnect)
            });
            nodes.Add(new Node()
            {
                Id = "node2",
                Width = 100,
                Height = 100,
                Style = new NodeStyleNodes()
                {
                    Fill = "cornflowerblue",
                },
                text = "node2",
                OffsetX = 400,
                OffsetY = 200,
                Constraints = NodeConstraints.Default & ~(NodeConstraints.InConnect | NodeConstraints.OutConnect)
            });
            ViewData.nodes = nodes;
            return View();
        }
    }
    public class Node : DiagramNode
    {
        public string text;
    }
}