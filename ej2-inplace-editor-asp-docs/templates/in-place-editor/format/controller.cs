public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = new DateTime(2018, 11, 23);
        ViewBag.model = new { placeholder = "Select date", format = "yyyy-MM-dd" };
        return View();
    }
}