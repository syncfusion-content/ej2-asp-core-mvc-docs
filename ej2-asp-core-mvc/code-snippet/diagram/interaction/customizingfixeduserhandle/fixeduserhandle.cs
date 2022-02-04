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
        public ActionResult Node()
        {
            List<DiagramNode> Nodes = new List<DiagramNode>();
            // A fixed user handle is created and stored in fixed user handle collection of Node.
            List<DiagramNodeFixedUserHandle> nodehandle = new List<DiagramNodeFixedUserHandle>();
            nodehandle.Add(new DiagramNodeFixedUserHandle() { Margin = new DiagramMargin() {Right=20 },Width=20,Height=20, PathData = "M60.3,18H27.5c-3,0-5.5,2.4-5.5,5.5v38.2h5.5V23.5h32.7V18z M68.5,28.9h-30c-3,0-5.5,2.4-5.5,5.5v38.2c0,3,2.4,5.5,5.5,5.5h30c3,0,5.5-2.4,5.5-5.5V34.4C73.9,31.4,71.5,28.9,68.5,28.9z M68.5,72.5h-30V34.4h30V72.5z" });
            Nodes.Add(new DiagramNode()
            {
                Id = "Node1",
                OffsetY = 100,
                OffsetX = 100,
                Height = 100,
                Width =100,
                FixedUserHandles = nodehandle
            });
            ViewBag.nodes = Nodes;
            // A fixed user handle is created and stored in fixed user handle collection of Connector.
            List<DiagramConnectorFixedUserHandle> connectorhandle = new List<DiagramConnectorFixedUserHandle>();
            connectorhandle.Add(new DiagramConnectorFixedUserHandle() {Offset=0,Alignment= FixedUserHandleAlignment.After,Displacement= new DiagramPoint() {X=10, Y = 10 }, Width = 20, Height = 20, PathData = "M60.3,18H27.5c-3,0-5.5,2.4-5.5,5.5v38.2h5.5V23.5h32.7V18z M68.5,28.9h-30c-3,0-5.5,2.4-5.5,5.5v38.2c0,3,2.4,5.5,5.5,5.5h30c3,0,5.5-2.4,5.5-5.5V34.4C73.9,31.4,71.5,28.9,68.5,28.9z M68.5,72.5h-30V34.4h30V72.5z" });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector",FixedUserHandles = connectorhandle, SourcePoint = new DiagramPoint() { X = 100, Y = 100 }, TargetPoint = new DiagramPoint() { X = 300, Y = 300 }  });
            ViewBag.connectors = Connectors;
            return View();
        }
    }
}