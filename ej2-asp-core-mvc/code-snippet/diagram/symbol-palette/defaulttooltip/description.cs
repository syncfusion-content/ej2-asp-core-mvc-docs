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
        public ActionResult Nodes()
        {
            List<DiagramNode> flowShapes = new List<DiagramNode>();
            flowShapes.Add(new DiagramNode() { Id = "Terminator", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Terminator } });
            flowShapes.Add(new DiagramNode() { Id = "Process", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Process } });
            flowShapes.Add(new DiagramNode() { Id = "Decision", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Decision } });
            flowShapes.Add(new DiagramNode() { Id = "Document", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Document } });
            flowShapes.Add(new DiagramNode() { Id = "PreDefinedProcess", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.PreDefinedProcess } });
            flowShapes.Add(new DiagramNode() { Id = "DirectData", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.DirectData } });
            flowShapes.Add(new DiagramNode() { Id = "SequentialData", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.SequentialData } });
            flowShapes.Add(new DiagramNode() { Id = "Sort", Shape = new DiagramFlowShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Flow, Shape = FlowShapes.Sort } });
            ViewBag.flowShapes = flowShapes;

            List<DiagramNode> basicShapes = new List<DiagramNode>();
            basicShapes.Add(new DiagramNode() { Id = "Rectangle", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Rectangle } });
            basicShapes.Add(new DiagramNode() { Id = "Ellipse", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Ellipse } });
            basicShapes.Add(new DiagramNode() { Id = "Hexagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Hexagon } });
            basicShapes.Add(new DiagramNode() { Id = "Star", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Star } });
            basicShapes.Add(new DiagramNode() { Id = "Diamond", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Diamond } });
            basicShapes.Add(new DiagramNode() { Id = "Pentagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Pentagon } });
            basicShapes.Add(new DiagramNode() { Id = "Heptagon", Shape = new DiagramBasicShape() { Type = Syncfusion.EJ2.Diagrams.Shapes.Basic, Shape = BasicShapes.Heptagon } });
            ViewBag.basicShapes = basicShapes;

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = flowShapes, Title = "Flow Shapes" });
            palettes.Add(new SymbolPalettePalette() { Id = "basic", Expanded = true, Symbols = basicShapes, Title = "Basic Shapes" });
            ViewBag.palettes = palettes;
            ViewBag.getSymbolInfo = "getSymbolInfo";
            return View();
        }
    }
}