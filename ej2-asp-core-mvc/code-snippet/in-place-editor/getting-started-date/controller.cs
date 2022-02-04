public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.dateValue = new DateTime(2018, 12, 04);
        ViewBag.modalData = new { showTodayButton = true };
        return View();
    }
}