using System.Collections.Generic; 
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
    public partial class DiagramController: Controller {
        // GET: Nodes
 // GET: Connector
        public ActionResult Connector()
        {
            List<DiagramConnector> connectors = new List<DiagramConnector>();

            List<DiagramConnectorAnnotation> annotations = new List<DiagramConnectorAnnotation>();
            annotations.Add(new DiagramConnectorAnnotation() { Offset = .7, Content = "Routing \n enabled" });
            connectors.Add(new DiagramConnector() { Id = "connector", SourceID = "shape1", TargetID = "node2", Type = Segments.Orthogonal, Annotations = annotations });

            annotations = new List<DiagramConnectorAnnotation>();
            annotations.Add(new DiagramConnectorAnnotation() { Offset = .7, Content = "Routing \n disabled" });
            connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "shape1", TargetID = "node2", Constraints = ConnectorConstraints.Default & ~ConnectorConstraints.InheritLineRouting  Type = Segments.Orthogonal, Annotations = annotations });

            List<Syncfusion.EJ2.Diagrams.DiagramNode> nodes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
            List<DiagramNode> Node1 = new List<DiagramNode>();
            nodes.Add(new DiagramNode() { OffsetX = 100, OffsetY = 100, Height = 50, Width = 120 });

            List<DiagramNode> Node1 = new List<DiagramNode>();
            nodes.Add(new DiagramNode() { OffsetX = 350, OffsetY = 350, Height = 50, Width = 120 });

            List<DiagramNode> Node1 = new List<DiagramNode>();
            nodes.Add(new DiagramNode() { OffsetX = 150, OffsetY = 200, Height = 50, Width = 120 });

            List<DiagramNode> Node1 = new List<DiagramNode>();
            nodes.Add(new DiagramNode() { OffsetX = 300, OffsetY = 200, Height = 50, Width = 120 });


            ViewBag.nodes = nodes;
            ViewBag.connectors = connectors;
            return View();
        }
    }
}