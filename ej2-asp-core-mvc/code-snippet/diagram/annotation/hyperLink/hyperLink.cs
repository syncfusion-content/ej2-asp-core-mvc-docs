using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
namespace sample1.Controllers
{
    public class NodeController : Controller
    {
        // GET: Node
        public ActionResult Node()
        {
            // Sets the Annotation for the Node
            List<DiagramNode> Nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() {
                //Sets the offset for the content
                Content = "Node1",
                Style = new DiagramTextStyle() {
                    Color = "black",
                    Fill = "transparent" },
                //Sets the margin for the annotation
                Margin = new DiagramMargin() { Top = 10 }
                // Sets the horizontal alignment as left
                HorizontalAlignment = Syncfusion.EJ2.Diagrams.HorizontalAlignment.Left,
                // Sets the vertical alignment as Center
                VerticalAlignment = Syncfusion.EJ2.Diagrams.VerticalAlignment.Center
            });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation()
            {
                //Sets the offset for the content
                Content = "Node1",
                hyperlink= {link= "https://www.google.com/"},             
                Style = new DiagramTextStyle()
                {
                    Color = "black",
                    Fill = "transparent"
                },
                //Sets the margin for the annotation
                Margin = new DiagramMargin() { Bottom = 10 }
                // Sets the horizontal alignment as left
                HorizontalAlignment = Syncfusion.EJ2.Diagrams.HorizontalAlignment.Left,
                // Sets the vertical alignment as Center
                VerticalAlignment = Syncfusion.EJ2.Diagrams.VerticalAlignment.Center });
            Nodes.Add(new DefaultNode()
            {
                Id = "Node1",
                OffsetY = 100,
                OffsetX = 100,
                Height = 100,
                Width =100,
                // add the Annotation for the Node
                Annotations = Node1,
            });
            Nodes.Add(new DefaultNode()
            {
                Id = "Node2",
                OffsetY = 100,
                OffsetX = 100,
                Height = 100,
                Width = 100,
                // add the Annotation for the Node
                Annotations = Node2,
            });            // Sets the Annotation for the Connector
            List<DiagramConnectorAnnotation> Connector1 = new List<DiagramConnectorAnnotation>();
            Connector1.Add(new DiagramConnectorAnnotation() {
                Content = "Connector1",
                // Sets the offset for the content
                Offset = 0,
                //Sets the margin for the annotation
                Margin = new DiagramMargin() { Top = 10 },
                Style = new DiagramTextStyle() { Color = "white", Fill = "transparent" } });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector1",
                SourceID = "Node1",
                TargetID = "Node2",
                // add the Annotation for the Connector
                Annotations = Connector1
            });

            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;
            return View();
        }
    }
}