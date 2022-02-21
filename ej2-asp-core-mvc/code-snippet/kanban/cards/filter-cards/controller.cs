public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.data = new KanbanDataModels().KanbanTasks();
        ViewBag.PriorityData = new KanbanDataModels().KanbanTasks().Select(e => e.Priority).Distinct().ToList();
        return View();
    }
}
