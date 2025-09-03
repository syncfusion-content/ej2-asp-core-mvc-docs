using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DataSource = ganttData();
            return View();
        }

        public static List<GanttDataSource> ganttData()
        {
            List<GanttDataSource> data = new List<GanttDataSource>
            {
                new GanttDataSource
                {
                    TaskID = 1,
                    TaskName = "Project Initiation",
                    StartDate = new DateTime(2019, 4, 2),
                    EndDate = new DateTime(2019, 4, 21)
                },
                new GanttDataSource
                {
                    TaskID = 2,
                    TaskName = "Identify Site location",
                    StartDate = new DateTime(2019, 4, 2),
                    Duration = 0,
                    Progress = 50,
                    ParentID = 1,
                    BaselineStartDate = new DateTime(2019, 4, 2),
                    BaselineEndDate = new DateTime(2019, 4, 6)
                },
                new GanttDataSource
                {
                    TaskID = 3,
                    TaskName = "Perform Soil test",
                    StartDate = new DateTime(2019, 4, 2),
                    Duration = 4,
                    Progress = 50,
                    ParentID = 1,
                    Predecessor = "2FS",
                    BaselineStartDate = new DateTime(2019, 4, 4),
                    BaselineEndDate = new DateTime(2019, 4, 9),
                    BaselineDuration = 5
                },
                new GanttDataSource
                {
                    TaskID = 4,
                    TaskName = "Soil test approval",
                    StartDate = new DateTime(2019, 4, 2),
                    Duration = 4,
                    Progress = 50,
                    ParentID = 1,
                    BaselineStartDate = new DateTime(2019, 4, 8),
                    BaselineDuration = 4
                },
                new GanttDataSource
                {
                    TaskID = 5,
                    TaskName = "Project Estimation",
                    StartDate = new DateTime(2019, 4, 2),
                    EndDate = new DateTime(2019, 4, 21)
                },
                new GanttDataSource
                {
                    TaskID = 6,
                    TaskName = "Develop floor plan for estimation",
                    StartDate = new DateTime(2019, 4, 4),
                    Duration = 3,
                    Progress = 50,
                    ParentID = 5,
                    BaselineStartDate = new DateTime(2019, 4, 4),
                    BaselineEndDate = new DateTime(2019, 4, 8)
                },
                new GanttDataSource
                {
                    TaskID = 7,
                    TaskName = "List materials",
                    StartDate = new DateTime(2019, 4, 4),
                    Duration = 3,
                    Progress = 50,
                    ParentID = 5,
                    BaselineStartDate = new DateTime(2019, 4, 2),
                    BaselineEndDate = new DateTime(2019, 4, 4),
                    BaselineDuration = 2
                },
                new GanttDataSource
                {
                    TaskID = 8,
                    TaskName = "Estimation approval",
                    StartDate = new DateTime(2019, 4, 4),
                    BaselineStartDate = new DateTime(2019, 04, 02),
                    Duration = 0,
                    Progress = 50,
                    ParentID = 5,
                    BaselineDuration = 0
                }
            };
            return data;
        }

    }
    public class GanttDataSource
        {
            public int TaskID { get; set; }
            public string? TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime BaselineStartDate { get; set; }
            public DateTime BaselineEndDate { get; set; }
            public int? BaselineDuration { get; set; }
            public DateTime? EndDate { get; set; }
            public int? Duration { get; set; }
            public int? Progress { get; set; }
            public int? ParentID { get; set; }
            public string? Predecessor { get; set; }
            public List<int>? Resources { get; set; }
    }
}