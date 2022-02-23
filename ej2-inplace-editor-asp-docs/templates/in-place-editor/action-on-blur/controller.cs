public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.blurActionData = new string[] { "Submit", "Cancel", "Ignore" };
        ViewBag.modelData = new { placeholder = "Enter some text" };
        ViewBag.text = "Submit";
        ViewBag.textValue = "Andrew";
        return View();
    }
}