public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.ToastButtons1 = new DefaultButtonModel() { content = "Ignore" };
        ViewBag.ToastButtons2 = new DefaultButtonModel() { content = "reply" };
        return View();
    }
    public class DefaultButtonModel
    {
        public string content { get; set; }
    }
}