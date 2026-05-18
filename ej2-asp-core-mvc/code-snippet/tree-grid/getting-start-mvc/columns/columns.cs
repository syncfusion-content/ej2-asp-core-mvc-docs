public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View(TreeGridItems.GetTreeData());
    }
}
public class TreeGridItems
{
    public TreeGridItems() { }
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set;}
    public int Duration { get; set; }
    public List<TreeGridItems> Children { get; set; }

    public static List<TreeGridItems> GetTreeData()
    {
        List<TreeGridItems> BusinessObjectCollection = new List<TreeGridItems>();

        TreeGridItems Record1 = new TreeGridItems()
        {
            TaskId = 1,
            TaskName = "Planning",
            StartDate = new DateTime(2025, 2, 4),
            EndDate = new DateTime(2025, 2, 7),
            Duration = 4,
            Children = new List<TreeGridItems>()
        };

        TreeGridItems Child1 = new TreeGridItems()
        {
            TaskId = 2,
            TaskName = "Plan timeline",
            StartDate = new DateTime(2025, 2, 4),
            EndDate = new DateTime(2025, 2, 7),
            Duration = 4
        };

        TreeGridItems Child2 = new TreeGridItems()
        {
            TaskId = 3,
            TaskName = "Plan budget",
            StartDate = new DateTime(2025, 2, 4),
            EndDate = new DateTime(2025, 2, 7),
            Duration = 4
        };

        Record1.Children.Add(Child1);
        Record1.Children.Add(Child2);

        TreeGridItems Record2 = new TreeGridItems()
        {
            TaskId = 4,
            TaskName = "Design",
            StartDate = new DateTime(2025, 2, 10),
            EndDate = new DateTime(2025, 2, 14),
            Duration = 5,
            Children = new List<TreeGridItems>()
        };

        TreeGridItems Child3 = new TreeGridItems()
        {
            TaskId = 5,
            TaskName = "Software Specification",
            StartDate = new DateTime(2025, 2, 10),
            EndDate = new DateTime(2025, 2, 12),
            Duration = 3
        };

        TreeGridItems Child4 = new TreeGridItems()
        {
            TaskId = 6,
            TaskName = "Design Documentation",
            StartDate = new DateTime(2025, 2, 13),
            EndDate = new DateTime(2025, 2, 14),
            Duration = 2
        };

        TreeGridItems Child5 = new TreeGridItems()
        {
            TaskId = 7,
            TaskName = "Design complete",
            StartDate = new DateTime(2025, 2, 14),
            EndDate = new DateTime(2025, 2, 14),
            Duration = 1
        };

        Record2.Children.Add(Child3);
        Record2.Children.Add(Child4);
        Record2.Children.Add(Child5);

        BusinessObjectCollection.Add(Record1);
        BusinessObjectCollection.Add(Record2);

        return BusinessObjectCollection;
    } 
}
