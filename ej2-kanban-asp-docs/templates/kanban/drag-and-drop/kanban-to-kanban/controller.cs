public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.externalDropIdA = new string[] { "#kanbanB" };
        ViewBag.externalDropIdB = new string[] { "#kanbanA" };
        ViewBag.data = new KanbanDataModels().KanbanTasks();
    }
}
