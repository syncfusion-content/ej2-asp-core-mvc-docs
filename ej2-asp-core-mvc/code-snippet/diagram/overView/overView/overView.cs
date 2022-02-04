using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;
using sample1.Models;

namespace sample1.Controllers
{
    public partial class DiagramController : Controller
    {
        // GET: Overview
        public ActionResult Overview()
        {
           ViewBag.Nodes = OverviewData.GetData();
            return View();
        }
    }
}

    public class OverviewData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ReportingPerson { get; set; }
        public string Image { get; set; }

        public OverviewData(string id, string name, string designation, string reportingperson)
        {
            this.Id = id;
            this.Name =name;
            this.Designation =designation;
            this.ReportingPerson =reportingperson;
            
        }

        public static List<OverviewData> GetData()
        {
            List<OverviewData> data = new List<OverviewData>();
            data.Add(new OverviewData("parent", "Maria Anders", "Managing Director", ""));
            data.Add(new OverviewData("1", "Ana Trujillo", "Project Manager", "parent"));
            data.Add(new OverviewData("2", "Anto Moreno", "Project Manager", "parent"));
            data.Add(new OverviewData("3", "Thomas Hardy", "Project Lead", "1"));
            data.Add(new OverviewData("4", "Christina kaff", "Project Lead", "2"));
            data.Add(new OverviewData("5", "Hanna Moos", "Senior S/w Engg", "3"));
            data.Add(new OverviewData("6", "Peter Citeaux", "Senior S/w Engg", "4"));
            return data;

        }
    }
