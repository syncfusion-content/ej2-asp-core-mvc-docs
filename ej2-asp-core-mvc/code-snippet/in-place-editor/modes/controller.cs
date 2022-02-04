public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.modeData = new string[] { "Inline", "Popup" };
        ViewBag.value = "Inline";
        ViewBag.modalData = new { placeholder = "Enter some text" };
        return View();
    }
}