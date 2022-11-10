public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.items = new[] { "Video" };
        return View();
    }
}