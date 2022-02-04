public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Print" };
        return View();
    }
}