public class HomeController : Controller
{

    public ActionResult Index()
    {
            ViewBag.items = new[] { "Checklist", "Bold", "Italic", "StrikeThrough", "|", "Formats", "Alignments", "Blockquote", "OrderedList",
            "UnorderedList", "|", "CreateLink", "Image", "|", "SourceCode", "Undo", "Redo" };
        return View();
    }
}
