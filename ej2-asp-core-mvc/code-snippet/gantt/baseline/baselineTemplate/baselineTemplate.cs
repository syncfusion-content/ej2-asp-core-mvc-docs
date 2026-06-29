using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ganttData());
        }
        public static List<GanttDataSource> ganttData()
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>()
    {
        new GanttDataSource()
        {
            TaskID = 1,
            TaskName = "Consumer electronics launch",
            StartDate = new DateTime(2024, 05, 01),
            EndDate = new DateTime(2024, 05, 14),
            Progress = 58
        },
        new GanttDataSource()
        {
            TaskID = 2,
            TaskName = "Design freeze",
            StartDate = new DateTime(2024, 05, 03),
            Duration = 3,
            BaselineStartDate = new DateTime(2024, 05, 03),
            BaselineDuration = 3,
            BaselineStartDate1 = new DateTime(2024, 05, 03),
            BaselineDuration1 = 5,
            BaselineStartDate2 = new DateTime(2024, 05, 03),
            BaselineDuration2 = 7,
            Progress = 100,
            ParentID = 1
        },
        new GanttDataSource()
        {
            TaskID = 3,
            TaskName = "Prototype development",
            StartDate = new DateTime(2024, 05, 08),
            Duration = 4,
            BaselineStartDate = new DateTime(2024, 05, 07),
            BaselineDuration = 0,
            BaselineStartDate1 = new DateTime(2024, 05, 08),
            BaselineDuration1 = 1,
            BaselineStartDate2 = new DateTime(2024, 05, 09),
            BaselineDuration2 = 1,
            Progress = 90,
            ParentID = 1
        },
        new GanttDataSource()
        {
            TaskID = 4,
            TaskName = "Tooling & mold setup",
            StartDate = new DateTime(2024, 05, 10),
            Duration = 3,
            BaselineStartDate = new DateTime(2024, 05, 10),
            BaselineDuration = 3,
            BaselineStartDate1 = new DateTime(2024, 05, 10),
            BaselineDuration1 = 3,
            BaselineStartDate2 = new DateTime(2024, 05, 10),
            BaselineDuration2 = 3,
            Progress = 70,
            ParentID = 1
        },
        new GanttDataSource()
        {
            TaskID = 5,
            TaskName = "Quality certification",
            StartDate = new DateTime(2024, 05, 13),
            Duration = 3,
            BaselineStartDate = new DateTime(2024, 05, 13),
            BaselineDuration = 3,
            BaselineStartDate1 = new DateTime(2024, 05, 14),
            BaselineDuration1 = 3,
            BaselineStartDate2 = new DateTime(2024, 05, 15),
            BaselineDuration2 = 3,
            Progress = 60,
            ParentID = 1
        },
        new GanttDataSource()
        {
            TaskID = 6,
            TaskName = "Pilot production run",
            StartDate = new DateTime(2024, 05, 10),
            Duration = 4,
            BaselineStartDate = new DateTime(2024, 05, 10),
            BaselineDuration = 3,
            BaselineStartDate1 = new DateTime(2024, 05, 10),
            BaselineDuration1 = 2,
            BaselineStartDate2 = new DateTime(2024, 05, 10),
            BaselineDuration2 = 1,
            Progress = 45,
            ParentID = 1
        },
        new GanttDataSource()
        {
            TaskID = 7,
            TaskName = "Market launch",
            StartDate = new DateTime(2024, 05, 15),
            Duration = 0,
            BaselineStartDate = new DateTime(2024, 05, 14),
            BaselineDuration = 0,
            BaselineStartDate1 = new DateTime(2024, 05, 15),
            BaselineDuration1 = 0,
            BaselineStartDate2 = new DateTime(2024, 05, 16),
            BaselineDuration2 = 0,
            ParentID = 1
        }
    };

            return GanttDataSourceCollection;
        }
    }
    public class GanttDataSource
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public int Progress { get; set; }
        public int? ParentID { get; set; }

        // Baseline fields
        public DateTime? BaselineStartDate { get; set; }
        public int? BaselineDuration { get; set; }

        public DateTime? BaselineStartDate1 { get; set; }
        public int? BaselineDuration1 { get; set; }

        public DateTime? BaselineStartDate2 { get; set; }
        public int? BaselineDuration2 { get; set; }
    }
}