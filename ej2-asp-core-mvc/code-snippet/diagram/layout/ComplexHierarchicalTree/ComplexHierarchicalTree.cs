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
          
            ViewBag.nodes = ComplexHierarchicalDataDetails.GetData();
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            DiagramMargin margin = new DiagramMargin() { Left = 10, Top = 50 };
            ViewBag.marginValue = margin;

            return View();
        }
    }
    public class ComplexHierarchicalDataDetails
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string[] ReportingPersons { get; set; }
        public string Border { get; set; }

        public ComplexHierarchicalDataDetails(string name, string color, string[] reportingPersons, string border)
        {
            this.Name = name;
            this.Color = color;
            this.ReportingPersons = reportingPersons;
            this.Border = border;
        }

        public static List<ComplexHierarchicalDataDetails> GetData()
        {
            List<ComplexHierarchicalDataDetails> data = new List<ComplexHierarchicalDataDetails>();

            data.Add(new ComplexHierarchicalDataDetails("node11", "#e7704c", null, "#c15433"));

            data.Add(new ComplexHierarchicalDataDetails("node12", "#efd46e", new string[] { "node114" }, "#d6b123"));
            data.Add(new ComplexHierarchicalDataDetails("node13", "#58b087", new string[] { "node12" }, "#16955e"));
            data.Add(new ComplexHierarchicalDataDetails("node14", "#58b087", new string[] { "node12" }, "#16955e"));
            data.Add(new ComplexHierarchicalDataDetails("node15", "#58b087", new string[] { "node12" }, "#16955e"));

            data.Add(new ComplexHierarchicalDataDetails("node16", "#14ad85", new string[] { }, ""));

            data.Add(new ComplexHierarchicalDataDetails("node17", "#659be5", new string[] { "node13", "node14", "node15" }, "#3a6eb5"));
            data.Add(new ComplexHierarchicalDataDetails("node18", "#14ad85", new string[] { }, ""));
            data.Add(new ComplexHierarchicalDataDetails("node19", "#8dbe6c", new string[] { "node16", "node17", "node18" }, "#489911"));

            data.Add(new ComplexHierarchicalDataDetails("node110", "#8dbe6c", new string[] { "node16", "node17", "node18" }, "#489911"));
            data.Add(new ComplexHierarchicalDataDetails("node111", "#8dbe6c", new string[] { "node16", "node17", "node18", "node116" }, "#489911"));

            data.Add(new ComplexHierarchicalDataDetails("node21", "#e7704c", null, "#c15433"));

            return data;
        }
    }

}