public class HomeController : Controller
{
    public class ButtonModel
    {
        public string content { get; set; }
        public string cssClass { get; set; }
    }

    public ActionResult Index()
    {
        ViewBag.DialogButtons1 = new ButtonModel() { cssClass = "e-flat", content = "OK" };
        ViewBag.DialogButtons2 = new ButtonModel() { content = "Cancel", cssClass = "e-flat" };
        return View();
    }
}