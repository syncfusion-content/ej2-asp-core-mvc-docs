public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<Task> task = new List<Task>();
 
        Task parent1 = new Task { TaskID = 1, TaskName = "Planning", StartDate = new DateTime(2025, 2, 4), EndDate = new DateTime(2025, 2, 7), Duration = 4, Children = new List<Task>() };
        parent1.Children.Add(new Task(2, "Plan timeline", new DateTime(2025, 2, 4), new DateTime(2025, 2, 7), 4));
        parent1.Children.Add(new Task(3, "Plan budget", new DateTime(2025, 2, 4), new DateTime(2025, 2, 7), 4));
 
        Task parent2 = new Task { TaskID = 4, TaskName = "Design", StartDate = new DateTime(2025, 2, 10), EndDate = new DateTime(2025, 2, 14), Duration = 5, Children = new List<Task>() };
 
        parent2.Children.Add(new Task(5, "Software Specification", new DateTime(2025, 2, 10), new DateTime(2025, 2, 12), 3));
        parent2.Children.Add(new Task(6, "Design Documentation", new DateTime(2025, 2, 13), new DateTime(2025, 2, 14), 2));
        parent2.Children.Add(new Task(7, "Design complete", new DateTime(2025, 2, 14), new DateTime(2025, 2, 14), 1));
 
        task.Add(parent1);
        task.Add(parent2);
        ViewBag.DataSource = task;
        return View();
    }
 
    public class Task
    {
        public Task() { }
        public int? TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Duration { get; set; }
        public List<Task> Children { get; set; }
 
        public Task(int taskID, string taskName, DateTime start, DateTime end, int duration)
        {
            this.TaskID = taskID;
            this.TaskName = taskName;
            this.StartDate = start;
            this.EndDate = end;
            this.Duration = duration;
        }
    }
}
