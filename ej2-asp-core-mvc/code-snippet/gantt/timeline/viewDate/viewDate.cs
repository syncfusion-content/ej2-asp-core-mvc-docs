namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DataSource = GanttData.GetData();
            return View();
        }
        public class GanttData
        {
            public int TaskID { get; set; }
            public string? TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public int? Duration { get; set; }
            public int? Progress { get; set; }
            public int? ParentID { get; set; }

            public static List<GanttData> GetData()
            {
                return new List<GanttData>
                {
                    new GanttData { TaskID = 1, TaskName = "Project Initiation", StartDate = DateTime.Parse("02/04/2019") },
                    new GanttData { TaskID = 2, TaskName = "Identify Site location", StartDate = DateTime.Parse("02/04/2019"), Duration = 4, Progress = 50, ParentID = 1 },
                    new GanttData { TaskID = 3, TaskName = "Perform Soil test", StartDate = DateTime.Parse("02/04/2019"), Duration = 4, Progress = 50, ParentID = 1 },
                    new GanttData { TaskID = 4, TaskName = "Soil test approval", StartDate = DateTime.Parse("02/04/2019"), Duration = 4, Progress = 50, ParentID = 1 },
                    new GanttData { TaskID = 5, TaskName = "Project Estimation", StartDate = DateTime.Parse("02/04/2019") },
                    new GanttData { TaskID = 6, TaskName = "Develop floor plan for estimation", StartDate = DateTime.Parse("04/04/2019"), Duration = 3, Progress = 50, ParentID = 5 },
                    new GanttData { TaskID = 7, TaskName = "List materials", StartDate = DateTime.Parse("04/04/2019"), Duration = 3, Progress = 50, ParentID = 5 },
                    new GanttData { TaskID = 8, TaskName = "Estimation approval", StartDate = DateTime.Parse("04/04/2019"), Duration = 3, Progress = 50, ParentID = 5 }
                };
            }
        }
    }

}