public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "FullScreen" };
        return View();
    }
}