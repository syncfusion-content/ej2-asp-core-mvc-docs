public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new object[] { "CreateLink" };
        return View();
    }
}