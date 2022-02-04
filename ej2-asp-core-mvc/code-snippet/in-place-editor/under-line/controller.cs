public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.modelData = new { placeholder = "Enter some text" };
        ViewBag.textValue = "Andrew";
        return View();
    }
}