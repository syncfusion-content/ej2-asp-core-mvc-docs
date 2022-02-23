using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
namespace sample1.Controllers
{
    public class NodeController : Controller
    {
        // GET: Node
        public ActionResult Node()
        {
            ViewBag.nodes = HierarchicalDetails.GetData();
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            DiagramMargin margin = new DiagramMargin() { Left = 10, Top = 50 };
            ViewBag.marginValue = margin;
            return View();
        }
    }
    public class HierarchicalDetails
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string FillColor { get; set; }
        public HierarchicalDetails(string name, string category, string fillcolor)
        {
            this.Name = name;
            this.Category = category;
            this.FillColor = fillcolor;
        }

        public static List<HierarchicalDetails> GetData()
        {
            List<HierarchicalDetails> hierarchicaldetails = new List<HierarchicalDetails>();
            hierarchicaldetails.Add(new HierarchicalDetails("Diagram", "", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Layout", "Diagram", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Tree Layout", "Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Organizational Chart", "Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Hierarchical Tree", "Tree Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Radial Tree", "Tree Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Mind Map", "Hierarchical Tree", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Family Tree", "Hierarchical Tree", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Management", "Organizational Chart", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Human Resources", "Management", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("University", "Management", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Business", "Management", "#916DAF"));
            return hierarchicaldetails;
        }
    }

}