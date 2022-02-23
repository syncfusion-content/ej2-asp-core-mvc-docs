public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.items = new[] { "Bold", "Italic", "Underline", "StrikeThrough", "-",
        "Formats", "Alignments", "OrderedList", "UnorderedList" };
        return View();
    }
}