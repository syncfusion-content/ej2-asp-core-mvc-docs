public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.data = new KanbanDataModels().VirtualScrollKanbanData();
        ViewBag.dialogData = new KanbanDialogModels().VirtualScrollDialogCardField();
        return View();
    }
}
