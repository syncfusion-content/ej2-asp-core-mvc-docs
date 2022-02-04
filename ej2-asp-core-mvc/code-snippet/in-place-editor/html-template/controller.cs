public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.dateValue = "2018-05-23";
        return View();
    }
}