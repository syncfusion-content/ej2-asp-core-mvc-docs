public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.modalData = new { placeholder = "Enter employee name" };
        ViewBag.value = "Andrew";
        return View();
    }
}