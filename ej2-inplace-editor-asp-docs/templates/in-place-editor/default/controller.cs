public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = "Andrew";
        return View();
    }
}