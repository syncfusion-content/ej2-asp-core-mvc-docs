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
            ViewBag.DataSource = TaskModeData();
            return View();
        }
        public static List<GanttDataSource> TaskModeData()
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Parent Task 1",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 03, 03),
                Progress = 40,
                IsManual = true,
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record1Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Child Task 1",
                StartDate = new DateTime(2017, 02, 27),
                EndDate = new DateTime(2017, 03, 03),
                Progress = 40
            };
            GanttDataSource Record1Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Child Task 2",
                StartDate = new DateTime(2017, 02, 26),
                EndDate = new DateTime(2017, 03, 03),
                Progress = 40,
                IsManual = true
            };
            GanttDataSource Record1Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Child Task 3",
                StartDate = new DateTime(2017, 02, 27),
                Duration = 5,
                Progress = 40,
                EndDate = new DateTime(2017, 03, 03)
            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Parent Task 2",
                StartDate = new DateTime(2017, 03, 05),
                EndDate = new DateTime(2017, 03, 09),
                Progress = 40,
                IsManual = true,
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record2Child1 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Child Task 1",
                StartDate = new DateTime(2017, 03, 06),
                EndDate = new DateTime(2017, 03, 09),
                Progress = 40,
            };
            GanttDataSource Record2Child2 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "Child Task 2",
                StartDate = new DateTime(2017, 03, 06),
                EndDate = new DateTime(2017, 03, 09),
                Progress = 40
            };
            GanttDataSource Record2Child3 = new GanttDataSource()
            {
                TaskId = 8,
                TaskName = "Child Task 3",
                StartDate = new DateTime(2017, 02, 28),
                EndDate = new DateTime(2017, 03, 05),
                Progress = 40,
                IsManual = true
            };
            GanttDataSource Record2Child4 = new GanttDataSource()
            {
                TaskId = 9,
                TaskName = "Child Task 4",
                StartDate = new DateTime(2017, 03, 04),
                EndDate = new DateTime(2017, 03, 09),
                Progress = 40,
                IsManual = true
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);
            Record2.SubTasks.Add(Record2Child4);

            GanttDataSource Record3 = new GanttDataSource()
            {
                TaskId = 10,
                TaskName = "Parent Task 3",
                StartDate = new DateTime(2017, 03, 13),
                EndDate = new DateTime(2017, 03, 17),
                Progress = 40,
                IsManual = true,
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record3Child1 = new GanttDataSource()
            {
                TaskId = 11,
                TaskName = "Child Task 1",
                StartDate = new DateTime(2017, 03, 13),
                EndDate = new DateTime(2017, 03, 17),
                Progress = 40
            };
            GanttDataSource Record3Child2 = new GanttDataSource()
            {
                TaskId = 12,
                TaskName = "Child Task 2",
                StartDate = new DateTime(2017, 03, 13),
                EndDate = new DateTime(2017, 03, 17),
                Progress = 40
            };
            GanttDataSource Record3Child3 = new GanttDataSource()
            {
                TaskId = 13,
                TaskName = "Child Task 3",
                StartDate = new DateTime(2017, 03, 13),
                EndDate = new DateTime(2017, 03, 17),
                Progress = 40
            };
            GanttDataSource Record3Child4 = new GanttDataSource()
            {
                TaskId = 14,
                TaskName = "Child Task 4",
                StartDate = new DateTime(2017, 03, 12),
                EndDate = new DateTime(2017, 03, 17),
                Progress = 40,
                IsManual = true
            };
            GanttDataSource Record3Child5 = new GanttDataSource()
            {
                TaskId = 15,
                TaskName = "Child Task 5",
                StartDate = new DateTime(2017, 03, 13),
                EndDate = new DateTime(2017, 03, 17),
                Progress = 40,
            };
            Record3.SubTasks.Add(Record3Child1);
            Record3.SubTasks.Add(Record3Child2);
            Record3.SubTasks.Add(Record3Child3);
            Record3.SubTasks.Add(Record3Child4);
            Record3.SubTasks.Add(Record3Child5);

            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);
            GanttDataSourceCollection.Add(Record3);
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
            public string Notes { get; set; }
            public int? Work { get; set; }
            public int ParentID { get; set; }
        }
    }
}