using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // This method sets up and returns a view for the UML Sequence Diagram
        public ActionResult Model()
        {
            // Create a new UML Sequence Diagram model
            var model = new DiagramUmlSequenceDiagramModel
            {
                // Define the participants involved in the sequence diagram
                Participants = new List<DiagramUmlSequenceParticipant>
                {
                    // Define the "User" as a participant, marked as an actor
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "User",
                        Content = "User",
                        IsActor = true
                    },
                    // Define the "System" as a non-actor participant with a destruction marker
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "System",
                        Content = "System",
                        IsActor = false,
                        ShowDestructionMarker = true,
                        // Define activation boxes for the system
                        ActivationBoxes = new List<DiagramUmlSequenceActivationBox>
                        {
                            new DiagramUmlSequenceActivationBox
                            {
                                Id = "ActSystem", // Identifier for the activation box
                                StartMessageID = "MSG1", // Message that starts the activation
                                EndMessageID = "MSG2" // Message that ends the activation
                            }
                        }
                    }
                },
                // Define the messages exchanged between these participants
                Messages = new List<DiagramUmlSequenceMessage>
                {
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG1",
                        Content = "Login Request",
                        FromParticipantID = "User", // Sender of the message
                        ToParticipantID = "System", // Receiver of the message
                        Type = UmlSequenceMessageType.Synchronous // Type of the message
                    },
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG2",
                        Content = "Login Response",
                        FromParticipantID = "System",
                        ToParticipantID = "User",
                        Type = UmlSequenceMessageType.Reply // Reply type indicating a response
                    }
                }
            };

            // Pass the UML sequence diagram model to the view for rendering
            ViewData.model = model;
            return View();
        }
    }
}