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
          
            ViewBag.nodes = RadialTreeDetails.GetData();

            return View();
        }
    }
    public class RadialTreeDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ReportingPerson { get; set; }

        public RadialTreeDetails(string id, string name, string designation, string reportingPerson)
        {
            this.Id = id;
            this.Name = name;
            this.Designation = designation;
            this.ReportingPerson = reportingPerson;
        }

        public static List<RadialTreeDetails> GetData()
        {
            List<RadialTreeDetails> radialTreeDetails = new List<RadialTreeDetails>();
            radialTreeDetails.Add(new RadialTreeDetails("parent", "Maria Anders", "Managing Director", ""));
            radialTreeDetails.Add(new RadialTreeDetails("1", "Ana Trujillo", "Project Manager", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("2", "Lino Rodri", "Project Manager", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("3", "Philip Cramer", "Project Manager", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("4", "Pedro Afonso", "Project Manager", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("5", "Anto Moreno", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("6", "Elizabeth Roel", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("7", "Aria Cruz", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("8", "Eduardo Roel", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("9", "Howard Snyd", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("10", "Daniel Tonini", "Project Lead", "1"));
            radialTreeDetails.Add(new RadialTreeDetails("11", "Nardo Batista", "Project Lead", "1"));
            return radialTreeDetails;
        }
    }

}