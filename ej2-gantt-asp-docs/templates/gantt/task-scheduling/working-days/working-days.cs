using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.DataSource = ProjectNewData();
            return View();
        }
        public static List<GanttDataSource> ProjectNewData()
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

            List<IndicatorsModel> Indicators = new List<IndicatorsModel>();

            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Product concept",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };

            GanttDataSource Child11 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Defining the product and its usage",
                StartDate = new DateTime(2019, 04, 02),
                Progress = 30,
                Duration = 3,
            };

            GanttDataSource Child12 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Defining target audience",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 3,
            };

            GanttDataSource Child13 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Prepare product sketch and notes",
                StartDate = new DateTime(2019, 04, 02),
                Progress = 30,
                Duration = 2,
                Predecessor = "2"
            };
            Record1.SubTasks.Add(Child11);
            Record1.SubTasks.Add(Child12);
            Record1.SubTasks.Add(Child13);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Concept approval",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 0,
                Predecessor = "3, 4",
                Indicators = new List<IndicatorsModel>() {
                    new IndicatorsModel() { date = "04/10/2019", name= "Design Phase", tooltip="Design phase completed", iconClass="okIcon e-icons" }
                }
            };

            GanttDataSource Record3 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Market research",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };

            GanttDataSource Record6Child1 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "Demand analysis",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };

            GanttDataSource Record7Child1 = new GanttDataSource()
            {
                TaskId = 8,
                TaskName = "Customer strength",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Predecessor = "5",
                Progress = 30
            };

            GanttDataSource Record7Child2 = new GanttDataSource()
            {
                TaskId = 9,
                TaskName = "Market opportunity analysis",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Predecessor = "5",
            };
            Record6Child1.SubTasks.Add(Record7Child1);
            Record6Child1.SubTasks.Add(Record7Child2);

            GanttDataSource Record6Child2 = new GanttDataSource()
            {
                TaskId = 10,
                TaskName = "Competitor analysis",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Predecessor = "7, 8",
                Progress = 30,
            };
            GanttDataSource Record6Child3 = new GanttDataSource()
            {
                TaskId = 11,
                TaskName = "Product strength analsysis",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Predecessor = "9",
            };
            GanttDataSource Record6Child4 = new GanttDataSource()
            {
                TaskId = 12,
                TaskName = "Research complete",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 0,
                Predecessor = "10",
                Indicators = new List<IndicatorsModel>() {
                    new IndicatorsModel() { date = "04/20/2019", name= "Research completed", tooltip="Research completed", iconClass="description e-icons" }
                }
            };
            Record3.SubTasks.Add(Record6Child1);
            Record3.SubTasks.Add(Record6Child2);
            Record3.SubTasks.Add(Record6Child3);
            Record3.SubTasks.Add(Record6Child4);

            GanttDataSource Record4 = new GanttDataSource()
            {
                TaskId = 13,
                TaskName = "Product design and development",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record13Child1 = new GanttDataSource()
            {
                TaskId = 14,
                TaskName = "Functionality design",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 30,
                Predecessor = "12"
            };
            GanttDataSource Record13Child2 = new GanttDataSource()
            {
                TaskId = 15,
                TaskName = "Quality design",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Predecessor = "12"
            };
            GanttDataSource Record13Child3 = new GanttDataSource()
            {
                TaskId = 16,
                TaskName = "Define reliability",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 2,
                Progress = 30,
                Predecessor = "15"
            };
            GanttDataSource Record13Child4 = new GanttDataSource()
            {
                TaskId = 17,
                TaskName = "Identifying raw materials",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 2,
                Predecessor = "15"
            };
            GanttDataSource Record13Child5 = new GanttDataSource()
            {
                TaskId = 18,
                TaskName = "Define cost plan",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record18Child1 = new GanttDataSource()
            {
                TaskId = 19,
                TaskName = "Manufacturing cost",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 2,
                Predecessor = "17",
                Progress = 30
            };
            GanttDataSource Record18Child2 = new GanttDataSource()
            {
                TaskId = 20,
                TaskName = "Selling cost",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 2,
                Predecessor = "17",
            };
            Record13Child5.SubTasks.Add(Record18Child1);
            Record13Child5.SubTasks.Add(Record18Child2);

            GanttDataSource Record13Child6 = new GanttDataSource()
            {
                TaskId = 21,
                TaskName = "Development of the final design",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record21Child1 = new GanttDataSource()
            {
                TaskId = 22,
                TaskName = "Defining dimensions and package volume",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 2,
                Predecessor = "19, 20",
                Progress = 30
            };
            GanttDataSource Record21Child2 = new GanttDataSource()
            {
                TaskId = 23,
                TaskName = "Develop design to meet industry standards",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 2,
                Predecessor = "22",
            };
            GanttDataSource Record21Child3 = new GanttDataSource()
            {
                TaskId = 24,
                TaskName = "Include all the details",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Predecessor = "23",
            };
            Record13Child6.SubTasks.Add(Record21Child1);
            Record13Child6.SubTasks.Add(Record21Child2);
            Record13Child6.SubTasks.Add(Record21Child3);
            GanttDataSource Record13Child7 = new GanttDataSource()
            {
                TaskId = 25,
                TaskName = "CAD Computer-aided design",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 30,
                Predecessor = "24"
            };
            GanttDataSource Record13Child8 = new GanttDataSource()
            {
                TaskId = 26,
                TaskName = "CAM Computer-aided manufacturing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Predecessor = "25"
            };
            GanttDataSource Record13Child9 = new GanttDataSource()
            {
                TaskId = 27,
                TaskName = "Design complete",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 0,
                Predecessor = "26",
            };
            GanttDataSource Record5 = new GanttDataSource()
            {
                TaskId = 28,
                TaskName = "Prototype testing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Progress = 30,
                Predecessor = "27"
            };
            GanttDataSource Record6 = new GanttDataSource()
            {
                TaskId = 29,
                TaskName = "Include feedback",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Predecessor = "28ss",
                Indicators = new List<IndicatorsModel>() {
                    new IndicatorsModel() { date = "05/24/2019", name= "Production phase", tooltip="Production phase completed", iconClass="okIcon e-icons" }
                }
            };
            GanttDataSource Record7 = new GanttDataSource()
            {
                TaskId = 30,
                TaskName = "Manufacturing",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 5,
                Progress = 30,
                Predecessor = "28, 29"
            };
            GanttDataSource Record8 = new GanttDataSource()
            {
                TaskId = 31,
                TaskName = "Assembling materials to finsihed goods",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 5,
                Predecessor = "30"
            };
            Record4.SubTasks.Add(Record13Child1);
            Record4.SubTasks.Add(Record13Child2);
            Record4.SubTasks.Add(Record13Child3);
            Record4.SubTasks.Add(Record13Child4);
            Record4.SubTasks.Add(Record13Child5);
            Record4.SubTasks.Add(Record13Child6);
            Record4.SubTasks.Add(Record13Child7);
            Record4.SubTasks.Add(Record13Child8);
            Record4.SubTasks.Add(Record13Child9);

            GanttDataSource Record9 = new GanttDataSource()
            {
                TaskId = 32,
                TaskName = "Feedback and testing",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record9Child1 = new GanttDataSource()
            {
                TaskId = 33,
                TaskName = "Internal testing and feedback",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 45,
                Predecessor = "31",
            };
            GanttDataSource Record9Child2 = new GanttDataSource()
            {
                TaskId = 34,
                TaskName = "Customer testing and feedback",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 3,
                Progress = 50,
                Predecessor = "33",
            };
            Record9.SubTasks.Add(Record9Child1);
            Record9.SubTasks.Add(Record9Child2);
            GanttDataSource Record10 = new GanttDataSource()
            {
                TaskId = 35,
                TaskName = "Final product development",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record10Child1 = new GanttDataSource()
            {
                TaskId = 36,
                TaskName = "Important improvements",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Progress = 30,
                Predecessor = "34",
            };
            GanttDataSource Record10Child2 = new GanttDataSource()
            {
                TaskId = 37,
                TaskName = "Address any unforeseen issues",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Progress = 30,
                Predecessor = "36ss",
                Indicators = new List<IndicatorsModel>() {
                    new IndicatorsModel() { date = "06/21/2019", name= "Sales and marketing", tooltip="Sales and marketing", iconClass="description e-icons" }
                }
            };
            Record10.SubTasks.Add(Record10Child1);
            Record10.SubTasks.Add(Record10Child2);
            GanttDataSource Record11 = new GanttDataSource()
            {
                TaskId = 38,
                TaskName = "Final product",
                StartDate = new DateTime(2019, 04, 04),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record11Child1 = new GanttDataSource()
            {
                TaskId = 39,
                TaskName = "Branding product",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Predecessor = "37",
            };
            GanttDataSource Record11Child2 = new GanttDataSource()
            {
                TaskId = 40,
                TaskName = "Marketing and presales",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Progress = 30,
                Predecessor = "39",
            };
            Record11.SubTasks.Add(Record11Child1);
            Record11.SubTasks.Add(Record11Child2);
            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);
            GanttDataSourceCollection.Add(Record3);
            GanttDataSourceCollection.Add(Record4);
            GanttDataSourceCollection.Add(Record5);
            GanttDataSourceCollection.Add(Record6);
            GanttDataSourceCollection.Add(Record7);
            GanttDataSourceCollection.Add(Record8);
            GanttDataSourceCollection.Add(Record9);
            GanttDataSourceCollection.Add(Record10);
            GanttDataSourceCollection.Add(Record11);
            return GanttDataSourceCollection;
        }
        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public string TaskType { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
            public int? Duration { get; set; }
            public bool IsManual { get; set; }
            public int Progress { get; set; }
            public string Predecessor { get; set; }
            public List<GanttDataSource> SubTasks { get; set; }
            public int[] ResourceId { get; set; }
            public List<ResourceModel> Resources { get; set; }
            public string Notes { get; set; }
            public int? Work { get; set; }
            public int ParentID { get; set; }
            public List<IndicatorsModel> Indicators { get; set; }
        }
        public class ResourceModel
        {
            public int ResourceId { get; set; }
            public Nullable<int> ResourceUnit { get; set; }
        }
        public class IndicatorsModel
        {
            public string date { get; set; }
            public string iconClass { get; set; }
            public string name { get; set; }
            public string tooltip { get; set; }
        }
        public class CheckList
        {
            public string id { get; set; }
            public string day { get; set; }

            public static List<CheckList> Days()
            {
                List<CheckList> Data = new List<CheckList>();
                Data.Add(new CheckList { id = "Sunday", day = "Sunday" });
                Data.Add(new CheckList { id = "Monday", day = "Monday" });
                Data.Add(new CheckList { id = "Tuesday", day = "Tuesday" });
                Data.Add(new CheckList { id = "Wednesday", day = "Wednesday" });
                Data.Add(new CheckList { id = "Thursday", day = "Thursday" });
                Data.Add(new CheckList { id = "Friday", day = "Friday" });
                Data.Add(new CheckList { id = "Saturday", day = "Saturday" });
                return Data;
            }
        }
    }
}