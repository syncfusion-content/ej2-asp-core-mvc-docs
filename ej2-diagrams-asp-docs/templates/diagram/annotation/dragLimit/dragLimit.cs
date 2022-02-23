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
             // Sets the Annotation for the Connector
            List<DiagramConnectorAnnotation> Connector1 = new List<DiagramConnectorAnnotation>();
            Connector1.Add(new DiagramConnectorAnnotation() {
                Content = "Connector1",
                // Sets the offset for the content
                Offset = 0,
                //Enables drag constraints for a connector.
                Constraints = AnnotationConstraints.Interaction | AnnotationConstraints.Drag,
                //Set drag limit for a connector annotation.
                dragLimit =  new DiagramMargin(){Left=20,Right=20,Top=20,Bottom=20}
             });

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector()
            {
                Id = "connector1",
                SourcePoint = new DiagramPoint() { X = 100, Y = 100 },
                TargetPoint = new DiagramPoint() { X = 200, Y = 200 },
                // add the Annotation for the Connector
                Annotations = Connector1
            });

            ViewBag.connectors = Connectors;
            return View();
        }
    }
}