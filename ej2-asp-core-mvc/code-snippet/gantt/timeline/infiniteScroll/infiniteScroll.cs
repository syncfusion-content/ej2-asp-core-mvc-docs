using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ganttData());
        }

        public static List<GanttDataSource> ganttData()
        {
            return new List<GanttDataSource>()
            {
                new GanttDataSource{ TaskID=1, TaskName="Project kickoff & planning", StartDate=new DateTime(2026,1,1), EndDate=new DateTime(2026,1,10) },

                new GanttDataSource{ TaskID=2, TaskName="Requirement gathering", StartDate=new DateTime(2026,1,1), Duration=5, Progress=100, ParentID=1 },
                new GanttDataSource{ TaskID=3, TaskName="Scope finalization", StartDate=new DateTime(2026,1,6), Duration=4, Predecessor="2", ParentID=1 },

                new GanttDataSource{ TaskID=4, TaskName="Design phase", StartDate=new DateTime(2026,1,11), EndDate=new DateTime(2026,1,31) },
                new GanttDataSource{ TaskID=5, TaskName="UI/UX design", StartDate=new DateTime(2026,1,11), Duration=10, ParentID=4 },
                new GanttDataSource{ TaskID=6, TaskName="Architecture setup", StartDate=new DateTime(2026,1,15), Duration=12, ParentID=4 },

                new GanttDataSource{ TaskID=7, TaskName="Development phase", StartDate=new DateTime(2026,2,1), EndDate=new DateTime(2026,12,15) },
                new GanttDataSource{ TaskID=8, TaskName="Frontend development", StartDate=new DateTime(2026,2,1), Duration=120, Progress=60, ParentID=7 },
                new GanttDataSource{ TaskID=9, TaskName="Backend development", StartDate=new DateTime(2026,2,5), Duration=140, Progress=55, ParentID=7 },
                new GanttDataSource{ TaskID=10, TaskName="API integration", StartDate=new DateTime(2026,8,1), Duration=60, Predecessor="8,9", ParentID=7 },

                new GanttDataSource{ TaskID=11, TaskName="Testing & bug fixing", StartDate=new DateTime(2026,12,16), EndDate=new DateTime(2027,1,31) },
                new GanttDataSource{ TaskID=12, TaskName="Unit testing", StartDate=new DateTime(2026,12,16), Duration=20, ParentID=11 },
                new GanttDataSource{ TaskID=13, TaskName="Integration testing", StartDate=new DateTime(2027,1,5), Duration=20, Predecessor="10", ParentID=11 },

                new GanttDataSource{ TaskID=14, TaskName="Release", StartDate=new DateTime(2027,2,1), EndDate=new DateTime(2027,2,15) },
                new GanttDataSource{ TaskID=15, TaskName="Beta release", StartDate=new DateTime(2027,2,1), Duration=5, ParentID=14 },
                new GanttDataSource{ TaskID=16, TaskName="Production deployment", StartDate=new DateTime(2027,2,10), Duration=2, Predecessor="15", ParentID=14 }
            };
        }
    }

    public class GanttDataSource
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public int? Progress { get; set; }
        public string Predecessor { get; set; }
        public int? ParentID { get; set; }
    }
}