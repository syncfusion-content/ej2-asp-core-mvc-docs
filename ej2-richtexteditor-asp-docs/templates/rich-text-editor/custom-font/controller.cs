public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.items = new[] { "FontColor", "BackgroundColor" };
        return View();
    }
}