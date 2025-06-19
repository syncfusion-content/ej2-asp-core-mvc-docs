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
            // Create a new UML Sequence Diagram model
            var model = new DiagramUmlSequenceDiagram
            {
                // Define the participants involved in the sequence diagram
                Participants = new List<DiagramUmlSequenceParticipant>
                {
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "User",
                        Content = "User",
                        IsActor = true // Indicates this participant is an actor
                    },
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "System",
                        Content = "System",
                        IsActor = false,
                        ShowDestructionMarker = true // Shows a destruction marker in the diagram
                    },
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "Logger",
                        Content = "Logger",
                        IsActor = false,
                        ShowDestructionMarker = true
                    },
                    new DiagramUmlSequenceParticipant
                    {
                        Id = "SessionManager",
                        Content = "SessionManager",
                        IsActor = false
                    }
                },
                // Define the messages exchanged between these participants
                Messages = new List<DiagramUmlSequenceMessage>
                {
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG1",
                        Content = "Login Request",
                        FromParticipantID = "User", // The sender of the message
                        ToParticipantID = "System", // The receiver of the message
                        Type = UmlSequenceMessageType.Synchronous // Message type indicating a synchronous operation
                    },
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG2",
                        Content = "Login Response",
                        FromParticipantID = "System",
                        ToParticipantID = "User",
                        Type = UmlSequenceMessageType.Reply
                    },
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG3",
                        Content = "Log Event",
                        FromParticipantID = "System",
                        ToParticipantID = "Logger",
                        Type = UmlSequenceMessageType.Asynchronous // Message type indicating an asynchronous operation
                    },
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG4",
                        Content = "Create Session",
                        FromParticipantID = "System",
                        ToParticipantID = "SessionManager",
                        Type = UmlSequenceMessageType.Create // Message type indicating creation of a session
                    },
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG5",
                        Content = "Delete Session",
                        FromParticipantID = "System",
                        ToParticipantID = "SessionManager",
                        Type = UmlSequenceMessageType.Delete // Message type indicating deletion of a session
                    },
                    new DiagramUmlSequenceMessage
                    {
                        Id = "MSG6",
                        Content = "Validate Inputs",
                        FromParticipantID = "System",
                        ToParticipantID = "System", // Message directed to the same participant (self-message)
                        Type = UmlSequenceMessageType.Self // Message type indicating a self-message
                    }
                }
            };

            // Pass the UML sequence diagram model to the view
            ViewData.model = model;
            return View();
        }
    }
}