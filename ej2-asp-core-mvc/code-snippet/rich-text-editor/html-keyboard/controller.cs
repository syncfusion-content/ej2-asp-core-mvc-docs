
public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
        "FontName", "FontSize", "FontColor", "BackgroundColor",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "OrderedList", "UnorderedList",
        "Outdent", "Indent", "|",
        "CreateLink", "Image", "CreateTable", "|", "FormatPainter" , "ClearFormat", "Print",
        "SourceCode", "FullScreen", "|", "Undo", "Redo"
    };
        return View();
    }
}