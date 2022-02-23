public class HomeController : Controller
{
    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }

    }

    // GET: RTL
    public ActionResult Index()
    {
        ViewBag.DialogButtons = new ButtonModel() { isPrimary = true, content = "Submit" };
        ViewBag.SubmitButtons1 = new ButtonModel() { content = "YES", isPrimary = true };
        ViewBag.SubmitButtons2 = new ButtonModel() { content = "NO" };
        return View();
    }
}