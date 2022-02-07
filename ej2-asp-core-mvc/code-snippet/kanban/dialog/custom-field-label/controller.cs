public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.dialog = new KanbanDialogModels().DialogCards();
        ViewBag.data = new KanbanDataModels().KanbanTasks();
        return View();
    }
}
