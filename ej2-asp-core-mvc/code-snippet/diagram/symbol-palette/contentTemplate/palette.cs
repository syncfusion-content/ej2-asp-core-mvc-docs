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
        public string CreateNodeContent(string nodeId)
        {
            if (nodeId == "node1")
                return $"<div style='height:100%; background:#f1e3da;font-family:Arial;padding-top:5px;'><div style='font-size:12px;font-weight:bold;margin-left:3px;padding-top:5px;'>📞Call</div><div style='font-size:10px;margin-left:5px;'>Client Call @10AM</div><div style='font-size:8px; color:#666;margin-left:5px;'>+1 234 567 8901</div></div>";
            else
            {
                return $"<svg width='200' height='200'><path d='M 13.69 3.77 C 13.69 3.77 12.22 0.03 16.83 0 C 16.83 0 19.9 0.13 19 4.32 C 18.99 4.36 18.98 4.41 18.97 4.45 C 17.98 8.77 15.87 12.87 15.04 15.03 H 19.85 C 19.85 15.03 21.06 19.61 16.71 20 H 2.42 C 2.42 20 -1.39 18.58 0.55 14.68 L 4.24 3.84 H 0.63 C 0.63 3.84 -0.76 0.94 2.74 0.03 L 16.79 0 L 15.9 0.36 L 14.43 2.08 L 13.69 3.77 Z M 13.64 1.33 C 13.64 1.33 13.34 1.81 13.3 2.31 H 2.1 C 2.1 2.31 2.03 1.44 2.98 1.27 L 13.64 1.33 Z M 18.48 16.47 C 18.48 16.47 18.32 19.15 15.74 18.34 C 15.74 18.34 14.72 17.77 14.8 16.48 L 18.48 16.47 Z M 14.25 3.74 C 14.25 3.74 15.05 3.48 15.12 2.24 C 15.12 2.24 15.3 1.1 16.95 1.55 C 16.95 1.55 17.94 1.9 17.26 3.95 C 17.26 3.95 14.52 12.45 13.53 14.29 C 13.53 14.29 12.22 16.94 13.65 18.52 H 3.09 C 3.09 18.52 0.87 18.07 2.18 14.9 C 2.18 14.9 5.79 5.36 6.11 3.74 L 14.25 3.74 Z' visibility='visible' opacity='1' fill='skyblue' stroke='black' stroke-width='1' stroke-dasharray='none'/></svg>";
            };
        }
        
        public ActionResult Nodes()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();

            nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Width = 100,
                Height = 100,
                Shape = new DiagramHtml() { Type = Syncfusion.EJ2.Diagrams.Shapes.HTML, content = CreateNodeContent("node1") }
            });
            
            nodes.Add(new DiagramNode()
            {
                Id = "node2",
                Width = 100,
                Height = 100,
                Shape = new DiagramNative() { Type = Syncfusion.EJ2.Diagrams.Shapes.Native, Scale = Stretch.Stretch, content = CreateNodeContent("node2") }
            });

            ViewBag.nodes = nodes;
            List<SymbolPalettePalette> palettes = new List<SymbolPalettePalette>();
            palettes.Add(new SymbolPalettePalette() { Id = "palette", Expanded = true, Symbols = nodes, Title = "HTML and SVG Nodes" });
            ViewBag.palettes = palettes;
            return View();
        }
    };
};