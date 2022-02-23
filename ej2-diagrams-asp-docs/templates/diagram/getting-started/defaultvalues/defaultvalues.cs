using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public ActionResult Connector()
        {
            List<DiagramNode> Nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "node1" });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "node2" });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Annotations = Node1,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetY= 100,
        });
            Nodes.Add(new DiagramNode()
            {
                Id = "node2",
                Annotations = Node2,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetY = 300,
            });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector", SourceID = "node1", TargetID = "node2", });
            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;
            return View();
        }
    }

}