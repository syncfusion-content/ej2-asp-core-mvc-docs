using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // This method constructs a UML Sequence Diagram model and passes it to the view
        public ActionResult Model()
        {
            // Define the UML Sequence Diagram model with space between participants
            var model = new DiagramUmlSequenceDiagramModel
            {
                SpaceBetweenParticipants = 300, // Space between the participants in the diagram

                // Define the participants involved in the diagram
                Participants = new List<DiagramUmlSequenceParticipant>
                {
                    new DiagramUmlSequenceParticipant { Id = "Customer", Content = "Customer", IsActor = true },
                    new DiagramUmlSequenceParticipant { Id = "OrderSystem", Content = "Order System", IsActor = false },
                    new DiagramUmlSequenceParticipant { Id = "PaymentGateway", Content = "Payment Gateway", IsActor = false }
                },

                // Define the messages exchanged between participants
                Messages = new List<DiagramUmlSequenceMessage>
                {
                    new DiagramUmlSequenceMessage { Id = "MSG1", Content = "Place Order", FromParticipantID = "Customer", ToParticipantID = "OrderSystem", Type = UmlSequenceMessageType.Synchronous },
                    new DiagramUmlSequenceMessage { Id = "MSG2", Content = "Check Stock Availability", FromParticipantID = "OrderSystem", ToParticipantID = "OrderSystem", Type = UmlSequenceMessageType.Synchronous },
                    new DiagramUmlSequenceMessage { Id = "MSG3", Content = "Stock Available", FromParticipantID = "OrderSystem", ToParticipantID = "Customer", Type = UmlSequenceMessageType.Reply },
                    new DiagramUmlSequenceMessage { Id = "MSG4", Content = "Process Payment", FromParticipantID = "OrderSystem", ToParticipantID = "PaymentGateway", Type = UmlSequenceMessageType.Synchronous },
                    new DiagramUmlSequenceMessage { Id = "MSG5", Content = "Payment Successful", FromParticipantID = "PaymentGateway", ToParticipantID = "OrderSystem", Type = UmlSequenceMessageType.Reply },
                    new DiagramUmlSequenceMessage { Id = "MSG6", Content = "Order Confirmed and Shipped", FromParticipantID = "OrderSystem", ToParticipantID = "Customer", Type = UmlSequenceMessageType.Reply },
                    new DiagramUmlSequenceMessage { Id = "MSG7", Content = "Payment Failed", FromParticipantID = "PaymentGateway", ToParticipantID = "OrderSystem", Type = UmlSequenceMessageType.Reply },
                    new DiagramUmlSequenceMessage { Id = "MSG8", Content = "Retry Payment", FromParticipantID = "OrderSystem", ToParticipantID = "Customer", Type = UmlSequenceMessageType.Reply }
                },
                
                // Define fragments to provide conditional visual representations
                Fragments = new List<DiagramUmlSequenceFragment>
                {
                    new DiagramUmlSequenceFragment
                    {
                        Id = 1,
                        Type = UmlSequenceFragmentType.Optional, // Represents an optional fragment
                        Conditions = new List<DiagramUmlSequenceFragmentCondition>
                        {
                            new DiagramUmlSequenceFragmentCondition
                            {
                                Content = "if item is in stock", // Condition for the fragment
                                MessageIds = new List<string> { "MSG4" }
                            }
                        }
                    },
                    new DiagramUmlSequenceFragment
                    {
                        Id = 2,
                        Type = UmlSequenceFragmentType.Alternative, // Represents an alternative fragment with conditions
                        Conditions = new List<DiagramUmlSequenceFragmentCondition>
                        {
                            new DiagramUmlSequenceFragmentCondition
                            {
                                Content = "if payment is successful",
                                MessageIds = new List<string> { "MSG5", "MSG6" }
                            },
                            new DiagramUmlSequenceFragmentCondition
                            {
                                Content = "if payment fails",
                                MessageIds = new List<string> { "MSG7", "MSG8" }
                            }
                        }
                    },
                    // Parent Fragment
                    new DiagramUmlSequenceFragment
                    {
                        Id = 3,
                        Type = UmlSequenceFragmentType.Loop, // Represents a loop fragment
                        Conditions = new List<DiagramUmlSequenceFragmentCondition>
                        {
                            new DiagramUmlSequenceFragmentCondition
                            {
                                Content = "while attempts less than 3",
                                FragmentIds = new List<int> { 1, 2 } // Nested fragments
                            }
                        }
                    }
                }
            };

            // Pass the diagram model to the view for rendering
            ViewData.model = model;
            return View();
        }
    }
}