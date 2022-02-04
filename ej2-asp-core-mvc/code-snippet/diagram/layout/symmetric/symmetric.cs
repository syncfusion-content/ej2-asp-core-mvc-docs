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
          
            ViewBag.nodes = SymmetricalDetails.GetData();
            ViewBag.getNodeDefaults = "getNodeDefaults";
            ViewBag.getConnectorDefaults = "getConnectorDefaults";

            return View();
        }
    }
    public class SymmetricalDetails
    {
        public string Id { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string ReportingPerson { get; set; }

        public SymmetricalDetails(string id, string source, string type)
        {
            this.Id = id;
            this.Source = source;
            this.Type = type;
        }

        public static List<SymmetricalDetails> GetData()
        {
            List<SymmetricalDetails> symmetricalDetails = new List<SymmetricalDetails>();

            symmetricalDetails.Add(new Controllers.SymmetricalDetails("parent", "", "Server"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("1", "parent", "Server"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("2", "parent", "Server"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("3", "1", "Server"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("4", "1", "Server"));

            symmetricalDetails.Add(new Controllers.SymmetricalDetails("5", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("6", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("7", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("8", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("9", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("10", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("11", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("12", "1", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("13", "1", "Hub"));

            symmetricalDetails.Add(new Controllers.SymmetricalDetails("14", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("15", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("16", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("18", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("19", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("20", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("21", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("22", "2", "Hub"));
            symmetricalDetails.Add(new Controllers.SymmetricalDetails("23", "2", "Hub"));

            return symmetricalDetails;
        }
    }

}