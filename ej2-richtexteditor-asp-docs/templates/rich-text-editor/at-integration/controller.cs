
public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new object[] {"|", "Undo", "Redo", "|",
        "Bold", "Italic", "Underline", "StrikeThrough", "|",
        "FontName", "FontSize", "FontColor", "BackgroundColor", "|",
        "SubScript", "SuperScript", "|",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "|", "OrderedList", "UnorderedList", "|",
        "Outdent", "Indent", "|", "CreateLink", "CreateTable", "Image", "|", "SourceCode"};
        return View();
    }
}