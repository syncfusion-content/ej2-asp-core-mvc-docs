public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.model = new { placeholder = "Enter some text" };
        ViewBag.value = "Andrew";
        return View();
    }
}