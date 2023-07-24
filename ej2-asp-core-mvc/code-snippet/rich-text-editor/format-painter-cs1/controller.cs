public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "FormatPainter", "ClearFormat", "Bold", "Italic", "Underline", "|",
            "Formats", "Alignments", "OrderedList", "UnorderedList", "|", "CreateLink", "Image","|",
            "SourceCode", "Undo", "Redo"};
        return View();
    }
}