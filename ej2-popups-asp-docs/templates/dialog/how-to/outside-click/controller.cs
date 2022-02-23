public class HomeController : Controller
{

    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }

    }

    public ActionResult Index()
    {
        ViewBag.DialogButtons1 = new ButtonModel() { content = "YES", isPrimary = true };
        ViewBag.DialogButtons2 = new ButtonModel() { content = "NO" };
        return View();
    }
}