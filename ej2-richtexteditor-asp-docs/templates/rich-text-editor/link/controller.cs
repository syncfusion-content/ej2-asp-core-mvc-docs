public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "CreateLink" };
        return View();
    }
}