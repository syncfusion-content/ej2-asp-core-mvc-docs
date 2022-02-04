public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.resources = new
        {
            styles = new[] { "myStyle.css" }
        };
        return View();
    }

}