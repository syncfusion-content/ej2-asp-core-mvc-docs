public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.externalDropId = new string[] { "#TreeView" };
        ViewBag.data = new KanbanDataModels().KanbanTasks();
        ViewBag.treeDataSource = new KanbanDataModels().TreeDataSource();
        return View();
    }
}
