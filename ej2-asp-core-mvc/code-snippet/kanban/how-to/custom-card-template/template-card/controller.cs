public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.data = new KanbanDataModels().KanbanTasks();
        return View();
    }
}