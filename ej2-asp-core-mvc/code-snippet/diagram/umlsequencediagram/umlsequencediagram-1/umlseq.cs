using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        public ActionResult Model()
        {
            // Define the model correctly
            var model = new DiagramUmlSequenceDiagramModel
            {
                // Define the participants involved in the UML Sequence Diagram
                participants = new List<DiagramUmlSequenceParticipant>
                {
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "User", // Unique identifier for the participant
                        Content = "User", // Label or name of the participant
                        IsActor = true // Indicates that the participant is an actor
                    },
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "System", // Unique identifier for the participant
                        Content = "System", // Label or name of the participant
                        IsActor = false,
                        ShowDestructionMarker = true // Flag to show destruction marker at the end of the lifeline
                    }
                }
            };

            ViewBag.model = model;
            return View();
        }
    }
}
