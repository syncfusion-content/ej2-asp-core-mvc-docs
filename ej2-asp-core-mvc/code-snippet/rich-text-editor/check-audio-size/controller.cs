public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Audio", "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "Blockquote", "OrderedList", "UnorderedList", "|", "CreateLink", "CreateTable", "Image", "|", "SourceCode", "|", "Undo", "Redo" };
        return View();
    }
}