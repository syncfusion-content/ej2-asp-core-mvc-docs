public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.validationRules = new { Number = new { maxLength = 5 } };
        return View();
    }
}