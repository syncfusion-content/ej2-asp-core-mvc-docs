public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.data = new KanbanDataModels().KanbanPizzaData();
        return View();
    }
}
