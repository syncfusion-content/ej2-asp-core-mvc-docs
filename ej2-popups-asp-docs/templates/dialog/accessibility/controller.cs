public class HomeController : Controller
{
    public class ButtonModel
    {
        public string content { get; set; }
        public string cssClass { get; set; }
    }

    public ActionResult Index()
    {
        ViewBag.DialogButtons = new ButtonModel() { cssClass = "e-flat", content = "Submit" };
        return View();
    }
}