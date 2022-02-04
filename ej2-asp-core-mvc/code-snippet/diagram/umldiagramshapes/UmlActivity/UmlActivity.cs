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

            Nodes.Add(new DefaultNode()
            {
                Id = "Node1",
                OffsetY = 100,
                OffsetX = 100,
                Height = 100,
                Width = 100,
                Shape = new {type="UmlActivity", shape="Action"}
            });
            ViewBag.nodes = Nodes;
            return View();
        }
    }
}