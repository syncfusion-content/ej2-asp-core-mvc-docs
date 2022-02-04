public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.items = new[] { "FontName", "FontSize" };
        return View();
    }
}