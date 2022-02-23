public class HomeController : Controller
{

    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
    public ActionResult Index()
    {
        ViewBag.DialogButtons = new ButtonModel() { isPrimary = true, content = "Dismiss" };
        return View();
    }

}