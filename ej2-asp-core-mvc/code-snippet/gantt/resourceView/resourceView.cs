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
            ViewBag.DataSource = ResourceViewData();
            ViewBag.Resources = GetResourceGroup();
            return View();
        }
        public static List<GanttDataSource> ResourceViewData()
        {
            List<GanttDataSource> GanttResourceSampleCollection = new List<GanttDataSource>();

            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 03, 29),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record1Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 2,
                Progress = 30,
                Work = 10,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{  ResourceId = 1, ResourceUnit = 50 }
                }
            };
            GanttDataSource Record1Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform soil test",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 4,
                Progress = 30,
                Work = 20,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel {  ResourceId = 2, ResourceUnit = 70 }
                }
            };
            GanttDataSource Record1Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil test approval",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 1,
                Progress = 30,
                Work = 10,
                Resources = new List<ResourceModel> {
                   new ResourceModel { ResourceId = 3, ResourceUnit = 25 },
                   new ResourceModel { ResourceId = 1, ResourceUnit = 75 },
                }

            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project estimation",
                StartDate = new DateTime(2019, 03, 29),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record2Child1 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop floor plan for estimation",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 3,
                Progress = 30,
                Work = 30,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{ ResourceId = 4, ResourceUnit = 50 },
                   new ResourceModel{ ResourceId = 2, ResourceUnit = 70 }
                }
            };
            GanttDataSource Record2Child2 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List materials",
                StartDate = new DateTime(2019, 04, 01),
                Duration = 3,
                Progress = 30,
                Work = 40,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{ ResourceId = 6, ResourceUnit = 40 }
                }
            };
            GanttDataSource Record2Child3 = new GanttDataSource()
            {
                TaskId = 8,
                TaskName = "Estimation approval",
                StartDate = new DateTime(2019, 04, 01),
                Duration = 2,
                Progress = 30,
                Work = 60,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{ ResourceId = 5, ResourceUnit = 75 }
                }
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);

            GanttDataSource Record3 = new GanttDataSource()
            {
                TaskId = 9,
                TaskName = "Sign contract",
                StartDate = new DateTime(2019, 04, 01),
                Duration = 1,
                Progress = 30,
            };
            GanttResourceSampleCollection.Add(Record1);
            GanttResourceSampleCollection.Add(Record2);
            GanttResourceSampleCollection.Add(Record3);
            return GanttResourceSampleCollection;
        }

        public static List<ResourceGroupCollection> GetResourceGroup()
        {
            List<ResourceGroupCollection> GanttResourcesCollection = new List<ResourceGroupCollection>();

            ResourceGroupCollection Record1 = new ResourceGroupCollection()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer",
                ResourceGroup = "Planning Team"
            };
            ResourceGroupCollection Record2 = new ResourceGroupCollection()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller",
                ResourceGroup = "Testing Team"
            };
            ResourceGroupCollection Record3 = new ResourceGroupCollection()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan",
                ResourceGroup = "Approval Team"
            };
            ResourceGroupCollection Record4 = new ResourceGroupCollection()
            {
                ResourceId = 4,
                ResourceName = "Fuller King",
                ResourceGroup = "Development Team"
            };
            ResourceGroupCollection Record5 = new ResourceGroupCollection()
            {
                ResourceId = 5,
                ResourceName = "Davolio Fuller",
                ResourceGroup = "Approval Team"
            };
            ResourceGroupCollection Record6 = new ResourceGroupCollection()
            {
                ResourceId = 6,
                ResourceName = "Van Jack",
                ResourceGroup = "Development Team"
            };
            GanttResourcesCollection.Add(Record1);
            GanttResourcesCollection.Add(Record2);
            GanttResourcesCollection.Add(Record3);
            GanttResourcesCollection.Add(Record4);
            GanttResourcesCollection.Add(Record5);
            GanttResourcesCollection.Add(Record6);
            return GanttResourcesCollection;
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
        public class ResourceGroupCollection
        {
            public int ResourceId { get; set; }
            public string ResourceName { get; set; }
            public string ResourceGroup { get; set; }
        }
    }
}