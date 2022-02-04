public ActionResult Index()
        {
            ViewBag.DataSource = MultiTaskbarData();
            ViewBag.Resources = GetResourceGroup();
            return View();
        }
        public static List<GanttDataSource> MultiTaskbarData()
        {
            List<GanttDataSource> GanttDataSourceCollection = new List<GanttDataSource>();

            GanttDataSource Record1 = new GanttDataSource()
            {
                TaskId = 1,
                TaskName = "Project Initiation",
                StartDate = new DateTime(2019, 03, 29),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>(),
            };
            GanttDataSource Record1Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify Site Location",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 3,
                Progress = 30,
                Work = 10,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 50 }
                }
            };
            GanttDataSource Record1Child2 = new GanttDataSource()
            {
                TaskId = 3,
                TaskName = "Perform Soil Test",
                StartDate = new DateTime(2019, 04, 03),
                Duration = 4,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 70 }
                },
                Predecessor = "2",
                Progress = 30,
                Work = 20
            };
            GanttDataSource Record1Child3 = new GanttDataSource()
            {
                TaskId = 4,
                TaskName = "Soil Test Approval",
                StartDate = new DateTime(2019, 04, 09),
                Duration = 4,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 1, ResourceUnit = 25 }
                },
                Predecessor = "3",
                Progress = 30,
                Work = 10
            };
            Record1.SubTasks.Add(Record1Child1);
            Record1.SubTasks.Add(Record1Child2);
            Record1.SubTasks.Add(Record1Child3);

            GanttDataSource Record2 = new GanttDataSource()
            {
                TaskId = 5,
                TaskName = "Project Estimation",
                StartDate = new DateTime(2019, 03, 29),
                EndDate = new DateTime(2019, 04, 21),
                SubTasks = new List<GanttDataSource>()
            };
            GanttDataSource Record2Child1 = new GanttDataSource()
            {
                TaskId = 6,
                TaskName = "Develop Floor Plan for Estimation",
                StartDate = new DateTime(2019, 04, 01),
                Duration = 5,
                Progress = 30,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel { ResourceId = 2, ResourceUnit = 50 }
                },
                Work = 50
            };
            GanttDataSource Record2Child2 = new GanttDataSource()
            {
                TaskId = 7,
                TaskName = "List Materials",
                StartDate = new DateTime(2019, 04, 04),
                Duration = 4,
                Resources = new List<ResourceModel>
                {
                    new ResourceModel { ResourceId = 2, ResourceUnit = 40}
                },
                Predecessor = "6FS-2",
                Progress = 30,
                Work = 40
            };
            GanttDataSource Record2Child3 = new GanttDataSource()
            {
                TaskId = 8,
                TaskName = "Estimation Approval",
                StartDate = new DateTime(2019, 04, 09),
                Duration = 4,
                Resources = new List<ResourceModel>
                {
                    new ResourceModel { ResourceId = 2, ResourceUnit = 75}
                },
                Predecessor = "7FS-1",
                Progress = 30,
                Work = 60
            };
            Record2.SubTasks.Add(Record2Child1);
            Record2.SubTasks.Add(Record2Child2);
            Record2.SubTasks.Add(Record2Child3);

            GanttDataSource Record3 = new GanttDataSource()
            {
                TaskId = 9,
                TaskName = "Sign Contract",
                StartDate = new DateTime(2019, 04, 09),
                Duration = 1,
                Resources = new List<ResourceModel>
                {
                    new ResourceModel { ResourceId = 3 }
                },
                Predecessor = "11FS-5"
            };

            GanttDataSourceCollection.Add(Record1);
            GanttDataSourceCollection.Add(Record2);
            GanttDataSourceCollection.Add(Record3);
            return GanttDataSourceCollection;
        }
        public static List<ResourceGroupCollection> MultitaskbarResource()
        {
            List<ResourceGroupCollection> GanttResourcesCollection = new List<ResourceGroupCollection>();

            ResourceGroupCollection Record1 = new ResourceGroupCollection()
            {
                ResourceId = 1,
                ResourceName = "Martin Tamer",
                ResourceGroup = "Planning Team",
                isExpand = false
            };
            ResourceGroupCollection Record2 = new ResourceGroupCollection()
            {
                ResourceId = 2,
                ResourceName = "Rose Fuller",
                ResourceGroup = "Testing Team",
                isExpand = true
            };
            ResourceGroupCollection Record3 = new ResourceGroupCollection()
            {
                ResourceId = 3,
                ResourceName = "Margaret Buchanan",
                ResourceGroup = "Approval Team",
                isExpand = false
            };
            GanttResourcesCollection.Add(Record1);
            GanttResourcesCollection.Add(Record2);
            GanttResourcesCollection.Add(Record3);
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
            public bool isExpand { get; set; }
        }