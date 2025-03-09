public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.value = @"<p>Welcome to the Syncfusion Rich Text Editor</p>";
        return View();
    }
}