public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.value = @"<p>This is paragraph one.</p><p>This is paragraph two.</p>"
        return View();
    }
}