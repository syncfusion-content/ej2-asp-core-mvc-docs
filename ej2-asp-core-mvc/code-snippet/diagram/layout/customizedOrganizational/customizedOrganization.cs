using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Syncfusion.EJ2.Diagrams;



namespace organization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Nodes = OverviewData.GetAllRecords();
            return View();

        }
        public class OverviewData
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public string ReportingPerson { get; set; }
            public string Image { get; set; }

            public OverviewData(string id, string name, string designation, string reportingperson, string Image)
            {
                this.Id = id;
                this.Name = name;
                this.Designation = designation;
                this.ReportingPerson = reportingperson;
                this.Image = Image;
            }

            public static List<OverviewData> GetAllRecords()
            {
                List<OverviewData> data = new List<OverviewData>();
                data.Add(new OverviewData("parent", "Maria Anders", "Managing Director", "", "./assets/diagram/employees/image1.png"));
                data.Add(new OverviewData("1", "Ana Trujillo", "Project Manager", "parent", "./assets/diagram/employees/image2.png"));
                data.Add(new OverviewData("2", "Anto Moreno", "Project Lead", "1", "./assets/diagram/employees/image3.png"));
                data.Add(new OverviewData("3", "Thomas Hardy", "Senior S/w Engg", "2", "./assets/diagram/employees/image4.png"));
                data.Add(new OverviewData("4", "Christina kaff", "S/w Engg", "3", "./assets/diagram/employees/image5.png"));
                data.Add(new OverviewData("5", "Hanna Moos", "Project Trainee", "4", "./assets/diagram/employees/image6.png"));
                data.Add(new OverviewData("6", "Peter Citeaux", "S/w Engg", "5", "./assets/diagram/employees/image7.png"));
                data.Add(new OverviewData("7", "Martín Kloss", "Project Trainee", "6", "./assets/diagram/employees/image8.png"));
                data.Add(new OverviewData("8", "Elizabeth Mary", "Project Trainee", "6", "./assets/diagram/employees/image9.png"));
                data.Add(new OverviewData("9", "Victoria Ash", "Senior S/w Engg", "5", "./assets/diagram/employees/image10.png"));
                data.Add(new OverviewData("10", "Francisco Yang", "Senior S/w Engg", "3", "./assets/diagram/employees/image11.png"));
                data.Add(new OverviewData("11", "Yang Wang", "Project Manager", "parent", "./assets/diagram/employees/image12.png"));
                data.Add(new OverviewData("12", "Lino Rodri", "Project Manager", "11", "./assets/diagram/employees/image13.png"));
                data.Add(new OverviewData("13", "Philip Cramer", "Senior S/w Engg", "24", "./assets/diagram/employees/image14.png"));
                data.Add(new OverviewData("14", "Pedro Afonso", "Project Trainee", "15", "./assets/diagram/employees/image15.png"));
                data.Add(new OverviewData("15", "Elizabeth Roel", "S/w Engg", "13", "./assets/diagram/employees/image16.png"));
                data.Add(new OverviewData("16", "Janine Labrune", "Project Lead", "12", "./assets/diagram/employees/image17.png"));
                data.Add(new OverviewData("17", "Ann Devon", "Project Manager", "25", "./assets/diagram/employees/image18.png"));
                data.Add(new OverviewData("18", "Roland Mendel", "Project Lead", "17", "./assets/diagram/employees/image19.png"));
                data.Add(new OverviewData("19", "Aria Cruz", "Senior S/w Engg", "18", "./assets/diagram/employees/image20.png"));
                data.Add(new OverviewData("20", "Martine Rancé", "S/w Engg", "18", "./assets/diagram/employees/image21.png"));
                
                return data;
            }
        }
    }
}
