public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.modelData = new { placeholder = "Enter some text" };
        ViewBag.editableOnData = new string[] { "Click", "DblClick", "EditIconClick" };
        ViewBag.text = "Click";
        ViewBag.textValue = "Andrew";
        return View();
    }
}