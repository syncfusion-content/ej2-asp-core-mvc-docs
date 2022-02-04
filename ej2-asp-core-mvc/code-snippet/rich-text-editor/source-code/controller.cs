public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "SourceCode" };
        return View();
    }
}