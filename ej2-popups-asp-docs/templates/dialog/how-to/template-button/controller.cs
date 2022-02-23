public class HomeController : Controller
{
    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
        public string iconCss { get; set; }

    }

    public ActionResult Index()
    {
        ViewBag.DefaultButtons1 = new ButtonModel() { content = "YES", isPrimary = true, iconCss = "e-icons e-ok-icon" };
        ViewBag.DefaultButtons2 = new ButtonModel() { content = "NO", iconCss = "e-icons e-close-icon" };
        return View();
    }
}