public class HomeController : Controller
{

    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }

    public ActionResult Index()
    {
        ViewBag.button1 = new { content = "YES", isPrimary = true };
        ViewBag.button2 = new { content = "NO" };
        return View();
    }

}