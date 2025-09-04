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
            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Width = 100,
                Height = 100,
                Shape = new DiagramHtml() { Type = Syncfusion.EJ2.Diagrams.Shapes.HTML },
            });
            nodes.Add(new DiagramNode()
            {
                Id = "node2",
                Width = 100,
                Height = 100,
                Shape = new DiagramNative() { Type = Syncfusion.EJ2.Diagrams.Shapes.Native, Scale = Stretch.Stretch },
            });
            ViewBag.nodes = nodes;

            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "palette", Expanded = true, Symbols = nodes, Title = "HTML and SVG Nodes" });
            ViewBag.palettes = palettes;

            return View();
        }
    }
}