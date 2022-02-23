public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.modalData = new { placeholder = "Enter some text" };
        ViewBag.saveButton = new { content = "Ok", cssClass = "e-outline" };
        ViewBag.cancelButton = new { content = "Cancel", cssClass = "e-outline" };
        ViewBag.textValue = "Andrew";
        return View();
    }
}