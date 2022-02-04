public class HomeController : Controller
{
    public ActionResult Index()
    {
        ProgressButtonSpinSettings spinSettings = new ProgressButtonSpinSettings()
        {
            Position = SpinPosition.Right,
            Width = "20",
            Template = "<div class='template'></div>"
        };
        ViewBag.spinSettings = spinSettings;
        return View();
    }
}
