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
            List<Syncfusion.EJ2.Diagrams.DiagramNode> umlShapes = new List<Syncfusion.EJ2.Diagrams.DiagramNode>();
                umlShapes.Add(new DiagramNode() {
                        Id = "Class",
                        OffsetX = 200,
                        OffsetY = 250,
                        Shape = new UmlClassifierShapeModel()
                        {
                            Type = "UmlClassifier",
                            ClassShapes = new ClassShapes()
                            {
                                Name = "Patient",
                            },
                            Classifier = "Class"
                        },
                    });
                umlShapes.Add(new DiagramNode() {
                        Id = "Interface",
                        OffsetX = 400,
                        OffsetY = 350,
                        Shape = new UmlClassifierShapeModel()
                        {
                            Type = "UmlClassifier",
                            InterfaceShapes = new InterfaceShapes()
                            {
                                Name = "Bank Account",
                            },
                            Classifier = "Interface"
                        },
                    });
                umlShapes.Add(new DiagramNode() {
                        Id = "Enumeration",
                        OffsetX = 600,
                        OffsetY = 450,
                        Shape = new UmlClassifierShapeModel()
                        {
                            Type = "UmlClassifier",
                            Enumerations = new Enumerations()
                            {
                                Name = "AccountType",
                            },
                            Classifier = "Enumeration"
                        },
                    });

            List<SymbolPalettePalette> Palettes = new List<SymbolPalettePalette>();
            Palettes.Add(new SymbolPalettePalette() { Id = "UMLClass", Expanded = true, Symbols = umlShapes, Title = "UML Nodes" });
            ViewBag.palettes = Palettes;
            ViewBag.getSymbolInfo = "getSymbolInfo";
            ViewBag.getSymbolDefaults = "getSymbolDefaults";
            return View();
        }
    }
    public class UmlClassifierShapeModel
    {
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("ClassShapes")]
        [JsonProperty("classShape")]
        public ClassShapes ClassShapes
        {
            get;
            set;
        }
        
        [DefaultValue(null)]
        [HtmlAttributeName("Enumerations")]
        [JsonProperty("enumeration")]
        public Enumerations Enumerations
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("InterfaceShapes")]
        [JsonProperty("interfaceShape")]
        public InterfaceShapes InterfaceShapes
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("classifier")]
        [JsonProperty("classifier")]
        public string Classifier
        {
            get;
            set;
        }
    }
    public class Enumerations
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("members")]
        [JsonProperty("members")]
        public List<UMLMembers> Members
        {
            get;
            set;
        }
    }

    public class ClassShapes
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("attributes")]
        [JsonProperty("attributes")]
        public List<UMLProperty> Attributes
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("methods")]
        [JsonProperty("methods")]
        public List<UMLMethods> Methods
        {
            get;
            set;
        }
    }

    public class InterfaceShapes
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("attributes")]
        [JsonProperty("attributes")]
        public List<UMLProperty> Attributes
        {
            get;
            set;
        }

        [DefaultValue(null)]
        [HtmlAttributeName("methods")]
        [JsonProperty("methods")]
        public List<UMLMethods> Methods
        {
            get;
            set;
        }
    }

    public class UMLProperty
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }
    
    public class UMLMethods
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        [DefaultValue(null)]
        [HtmlAttributeName("type")]
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
    }

    public class UMLMembers
    {
        [DefaultValue(null)]
        [HtmlAttributeName("name")]
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}