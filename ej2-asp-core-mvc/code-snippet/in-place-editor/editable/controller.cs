public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.model = new { placeholder = "Enter some text" };
        ViewBag.editableOnData = new string[] { "Click", "DblClick", "EditIconClick" };
        ViewBag.value = "Click";
        ViewBag.inplaceValue = "Andrew";
        return View();
    }
}