public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.data = new KanbanDataModels().KanbanTasks();
        ViewBag.PriorityData = new string[] { "None", "High", "Normal", "Low" };
        return View();
    }
}
