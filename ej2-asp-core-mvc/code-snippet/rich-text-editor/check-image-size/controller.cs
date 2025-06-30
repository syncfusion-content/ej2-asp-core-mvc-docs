public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Iamge", "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "Blockquote", "OrderedList", "UnorderedList", "|", "CreateLink", "CreateTable", "|", "SourceCode", "|", "Undo", "Redo" };
        return View();
    }
}