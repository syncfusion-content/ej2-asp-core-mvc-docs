public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.items = new[] { "AICommands", "AIQuery" };
        return View();
    }
}