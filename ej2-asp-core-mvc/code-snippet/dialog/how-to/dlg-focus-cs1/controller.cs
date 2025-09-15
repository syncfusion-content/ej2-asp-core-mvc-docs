public class HomeController : Controller
{

    public class ButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }

    }

    public ActionResult Index()
    {
        ViewBag.DialogButtons1 = new ButtonModel() { isPrimary = true, content = "Ok" };
        ViewBag.DialogButtons2 = new ButtonModel() { content = "Cancel" };
        return View();
    }

}