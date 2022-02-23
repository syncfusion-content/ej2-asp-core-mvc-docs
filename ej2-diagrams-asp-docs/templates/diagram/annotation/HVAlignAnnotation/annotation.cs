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
                // Sets the horizontal alignment as left
                HorizontalAlignment = Syncfusion.EJ2.Diagrams.HorizontalAlignment.Left,
                // Sets the vertical alignment as Center
                VerticalAlignment = Syncfusion.EJ2.Diagrams.VerticalAlignment.Center
            });
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
            ViewBag.nodes = Nodes;
            return View();
        }
    }
}