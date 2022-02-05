  public ActionResult SelfReferenceData()
  {
    var treeData = TreeGridItems.GetSelfData();
    ViewBag.datasource = treeData;
    return View();
  }

   public class TreeGridItems
        {
            public TreeGridItems() { }
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public int Duration { get; set; }
            public int? ParentId { get; set; }
            public static List<TreeGridItems> GetSelfData()
            {
                List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 1, TaskName = "Parent Task 1", StartDate = new DateTime(2017, 10, 23), Duration = 10, ParentId = null
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 2, TaskName = "Child task 1", StartDate = new DateTime(2017, 10, 23), Duration = 4, ParentId = 1
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 3, TaskName = "Child Task 2", StartDate = new DateTime(2017, 10, 24), Duration = 5, ParentId = 1
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 4, TaskName = "Child task 3", StartDate = new DateTime(2017, 10, 25), Duration = 6, ParentId = 1
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 5, TaskName = "Parent Task 2", StartDate = new DateTime(2017, 10, 23), Duration = 10, ParentId = null
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 6, TaskName = "Child task 1", StartDate = new DateTime(2017, 10, 23), Duration = 4, ParentId = 5
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 7, TaskName = "Child Task 2", StartDate = new DateTime(2017, 10, 24), Duration = 5, ParentId = 5
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 8, TaskName = "Child task 3", StartDate = new DateTime(2017, 10, 25), Duration = 6, ParentId = 5
                });
                BusinessObjectCollection.Add(new TreeGridItems()
                {
                    TaskId = 9, TaskName = "Child task 4", StartDate = new DateTime(2017, 10, 25), Duration = 6, ParentId = 5
                });
                return BusinessObjectCollection;
               }
         }
