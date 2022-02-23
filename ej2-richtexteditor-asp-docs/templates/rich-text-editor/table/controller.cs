public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "CreateTable" };
        return View();
    }
}