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
            Node3.Add(new DiagramNodeAnnotation() { Content = "i < 10?" });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "print(hello!!)", Style = new DiagramTextStyle() { Fill = "White" } });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "i++;" });
            List<DiagramNodeAnnotation> Node6 = new List<DiagramNodeAnnotation>();
            Node6.Add(new DiagramNodeAnnotation() { Content = "End" });
            List<DiagramConnectorAnnotation> connector1 = new List<DiagramConnectorAnnotation>();
            connector1.Add(new DiagramConnectorAnnotation() { Content = "Yes" });
            List<DiagramConnectorAnnotation> connector2 = new List<DiagramConnectorAnnotation>();
            connector2.Add(new DiagramConnectorAnnotation() { Content = "No" });
            Nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Annotations = Node1,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                Shape = new { type = "Flow", shape = "Terminator" },
                OffsetY = 50,
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node2",
                Annotations = Node2,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetY = 140,
                Shape = new { type = "Flow", shape = "Process" },
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node3",
                Annotations = Node3,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetY = 230,
                Shape = new { type = "Flow", shape = "Decision" },
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node4",
                Annotations = Node4,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetY = 320,
                Shape = new { type = "Flow", shape = "PreDefinedProcess" },
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node5",
                Annotations = Node5,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                OffsetY = 410,
                Shape = new { type = "Flow", shape = "Process" },
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node6",
                Annotations = Node6,
                Style = new NodeStyleNodes() { Fill = "darkcyan" },
                
                OffsetY = 500,
                Shape = new { type = "Flow", shape = "Terminator" },
            });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "node1", TargetID = "node2", });
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "node2", TargetID = "node3", });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "node3", TargetID = "node4", Annotations = connector1, });
            Connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "node3", TargetID = "node6", Annotations = connector2, });
            Connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "node4", TargetID = "node5" });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "node5", TargetID = "node3" });
            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;
            return View();
        }
    }

}