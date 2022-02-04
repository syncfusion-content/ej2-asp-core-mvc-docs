public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.dateModel = new { placeholder = "Select date" };
        ViewBag.validationRules = new { Today = new { required = true } };
        ViewBag.ValidationModel = new { TodayCustom = new { required = true } };
        return View();
    }
}