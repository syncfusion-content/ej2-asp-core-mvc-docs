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
            ViewBag.DataSource = UnscheduledData();
            return View();
        }
        public static List<GanttDataSource> UnscheduledData()
        {
            List<GanttDataSource> ganttData = new List<GanttDataSource>();
            GanttDataSource record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Task 1",
                StartDate = new DateTime(2019, 01, 03),
                EndDate = new DateTime(2019, 01, 08),
                Duration = 5,
                TaskType = "",
            };
            GanttDataSource record2 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Task 2",
                Duration = 5,
                TaskType = "Task with duration only",
            };
            GanttDataSource record3 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Task 3",
                StartDate = new DateTime(2019, 01, 03),
                TaskType = "Task with start date only",

            };
            GanttDataSource record4 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Task 4",
                EndDate = new DateTime(2019, 01, 08),
                TaskType = "Task with end date only",
            };
            ganttData.Add(record1);
            ganttData.Add(record2);
            ganttData.Add(record3);
            ganttData.Add(record4);
            return ganttData;
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
            public string Notes { get; set; }
            public int? Work { get; set; }
            public int ParentID { get; set; }
        }
    }
}