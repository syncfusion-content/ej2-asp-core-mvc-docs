using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using System.Drawing;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Nodes
        public ActionResult Nodes()
        {
            List<DiagramNode> SymbolPaletee = new List<DiagramNode>();
            List<DiagramNode> BasicNodes = new List<DiagramNode>();
            BasicNodes.Add(new DiagramNode()
            {
                Id = "rectangle",
                Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle },
                //To display customized tooltip content by enabling Tooltip Constraints
                Tooltip = new DiagramDiagramTooltip() { Content = "custom tooltip content" },
                Constraints = NodeConstraints.Default | NodeConstraints.Tooltip
            });
            BasicNodes.Add(new DiagramNode() { Id = "plus", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Plus } });
            BasicNodes.Add(new DiagramNode() { Id = "triangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.RightTriangle } });
            ViewBag.BasicShapes = BasicNodes;

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "basic", Expanded = true, Symbols = BasicNodes, Title = "Basic Shapes" });
            ViewBag.palettes = palettes;
            ViewBag.getSymbolInfo = "getSymbolInfo";
            return View();
        }
    }
}