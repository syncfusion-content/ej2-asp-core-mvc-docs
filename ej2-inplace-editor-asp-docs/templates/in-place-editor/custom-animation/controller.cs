public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.model = new { placeholder = "Enter some text" };
        ViewBag.openAnimateData = new string[] { "None", "FadeIn", "FadeZoomIn", "ZoomIn" };
        ViewBag.textValue = "ZoomIn";
        ViewBag.value = "Andrew";
        ViewBag.popupSettings = new Syncfusion.EJ2.InPlaceEditor.InPlaceEditorPopupSettings { Model = new { animation = new { open = new { effect = "ZoomIn", duration = 1000, delay = 0 } } } };
        return View();
    }
}