using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram {
        public partial class DiagramController: Controller {
                // GET: Nodes
                public ActionResult Nodes() {
                        List < DiagramNode > SymbolPaletee = new List < DiagramNode > ();
                         List<Lane> Lanes = new List<Lane>();
                         Lanes.Add(new Lane()
            {
                Id = "stackCanvas1",
                Height = 100,
                Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "Consumer" },
                    Width = 50,
                },                
            });
                        List<Phase> Phases = new List<Phase>();
                        SymbolPaletee.Add(new SwimlaneShapes() {
                            Id = "lane1", Shape = new {
                               Type = "SwimLane",
                   PhaseSize = 20,
                    Header = new Header()
                {
                    Annotation = new DiagramNodeAnnotation() { Content = "ONLINE PURCHASE STATUS" },
                    Height = 50,
                    Orientation = "Horizontal",
                    Style = new DiagramTextStyle() { FontSize = 11 }
                },
                Lanes = Lanes,
                Phases = Phases
                            }
                        });
                        SymbolPaletee.Add(new FlowShapes() {
                            Id = "lane2", Shape = new {
                                type = "Flow", shape = "Terminator"
                            }
                        });
                        SymbolPaletee.Add(new FlowShapes() {
                            Id = "Process", Shape = new {
                                type = "Flow", shape = "Process"
                            }
                        });
                        SymbolPaletee.Add(new FlowShapes() {
                            Id = "Decision", Shape = new {
                                type = "Flow", shape = "Decision"
                            }
                        });
                      
                        List < SymbolPalettePalette > palettes = new List < SymbolPalettePalette > (); 
                                            palettes.Add(new SymbolPalettePalette() {
                                                Id = "swimlane", Expanded = true, Symbols = swimlane, IconCss = "e-ddb-icons e-connector", Title = "Swimlane Shapes"
                                            }); ViewBag.palettes = palettes;

                                            return View();
                                        }
                                    }
                                }