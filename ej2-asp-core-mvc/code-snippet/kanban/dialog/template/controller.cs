public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.data = new KanbanDataModels().KanbanTasks();
        ViewBag.status = new KanbanDataModels().DialogStatus();
        ViewBag.assignee = new KanbanDataModels().AssigneeData();
        ViewBag.priority = new KanbanDataModels().PriorityData();
        return View();
    }
}
