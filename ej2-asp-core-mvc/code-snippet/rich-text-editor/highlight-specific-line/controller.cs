public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = @"<p>The Rich Text Editor component is the WYSIWYG ('what you see is what you get') editor that provides the best user experience to create and update content. Users can format their content using standard toolbar commands.</p>";
        return View();
    }
}