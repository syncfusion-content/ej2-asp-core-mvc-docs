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
          
            ViewBag.nodes = MindMapDetails.GetData();
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            DiagramMargin margin = new DiagramMargin() { Left = 10, Top = 50 };
            ViewBag.marginValue = margin;
            return View();
        }
    }
    public class MindMapDetails
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string ParentId { get; set; }
        public string Branch { get; set; }
        public string Fill { get; set; }

        public MindMapDetails(string id, string label, string parent, string branch, string fill)
        {
            this.Id = id;
            this.Label = label;
            this.ParentId = parent;
            this.Branch = branch;
            this.Fill = fill;
        }

        public static List<MindMapDetails> GetData()
        {
            List<MindMapDetails> mindmapDetails = new List<Controllers.MindMapDetails>();

             mindmapDetails.Add(new MindMapDetails("1", "Creativity", "", "Root", "red"));
            mindmapDetails.Add(new MindMapDetails("3", "Brainstorming", "1", "Right", "red"));
            mindmapDetails.Add(new MindMapDetails("4", "Complementing", "1", "Left", "red"));

            mindmapDetails.Add(new MindMapDetails("22", "Sessions", "3", "subRight", "red"));
            mindmapDetails.Add(new MindMapDetails("23", "Complementing", "3", "subRight", "red"));

            mindmapDetails.Add(new MindMapDetails("25", "Local", "22", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("26", "Remote", "22", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("27", "Individual", "22", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("28", "Teams", "22", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("29", "Ideas", "23", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("30", "Engagement", "23", "subRight", ""));

            mindmapDetails.Add(new MindMapDetails("31", "Product", "29", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("32", "Service", "29", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("33", "Business Direction", "29", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("34", "Empowering", "30", "subRight", ""));
            mindmapDetails.Add(new MindMapDetails("35", "Ownership", "30", "subRight", ""));

            mindmapDetails.Add(new MindMapDetails("50", "Information", "4", "subLeft", ""));
            mindmapDetails.Add(new MindMapDetails("51", "Expectations", "4", "subLeft", ""));


            mindmapDetails.Add(new MindMapDetails("53", "Competetors", "50", "subLeft", ""));
            mindmapDetails.Add(new MindMapDetails("54", "Products", "50", "subLeft", ""));
            mindmapDetails.Add(new MindMapDetails("55", "Features", "50", "subLeft", ""));
            mindmapDetails.Add(new MindMapDetails("56", "Other Data", "50", "subLeft", ""));

            mindmapDetails.Add(new MindMapDetails("59", "Organization", "51", "subLeft", ""));
            mindmapDetails.Add(new MindMapDetails("60", "Customer", "51", "subLeft", ""));
            mindmapDetails.Add(new MindMapDetails("61", "Staff", "51", "subLeft", ""));
            mindmapDetails.Add(new MindMapDetails("62", "Stakeholders", "51", "subLeft", ""));
            return mindmapDetails;
        }
    }

}