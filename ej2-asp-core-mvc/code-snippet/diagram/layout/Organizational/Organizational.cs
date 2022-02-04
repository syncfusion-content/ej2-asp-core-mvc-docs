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
          
            ViewBag.nodes = OrganizationalDetails.GetData();
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";
            ViewBag.getLayoutInfo = "getLayoutInfo";
            DiagramMargin margin = new DiagramMargin() { Left = 10, Top = 50 };
            ViewBag.marginValue = margin;
            return View();
        }
    }
    public class OrganizationalDetails
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string Color { get; set; }
        public string Manager { get; set; }
        public string ChartType { get; set; }

        public OrganizationalDetails(string id, string role, string color, string manager, string chartType)
        {
            this.Id = id;
            this.Role = role;
            this.Color = color;
            this.Manager = manager;
            this.ChartType = chartType;
        }

        public static List<OrganizationalDetails> GetData()
        {
            List<OrganizationalDetails> organizationaldetails = new List<OrganizationalDetails>();
            organizationaldetails.Add(new OrganizationalDetails("parent", "Board", "#71AF17", "", ""));
            organizationaldetails.Add(new OrganizationalDetails("1", "General Manager", "#71AF17", "parent", "right"));
            organizationaldetails.Add(new OrganizationalDetails("11", "Assistant General Manager", "#71AF17", "1", ""));
            organizationaldetails.Add(new OrganizationalDetails("2", "Human Resource Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("3", "Trainers", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("4", "Recruiting Team", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("6", "Design Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("7", "Design Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("8", "Development Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("9", "Drafting Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("10", "Operations Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("11", "Statistics Department", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("12", "Logistics Department", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("16", "Marketing Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("17", "Oversea sales Manager", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("18", "Petroleum Manager", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("20", "Service Dept. Manager", "#2E95D8", "10", ""));

            return organizationaldetails;
        }
    }

}