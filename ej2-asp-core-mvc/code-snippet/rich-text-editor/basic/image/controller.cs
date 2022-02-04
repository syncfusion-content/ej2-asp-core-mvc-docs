public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.image = new[] {
        "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "-",
        "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension"
            };

        ViewBag.tools = new[] {
        "Bold", "Italic", "Underline", "StrikeThrough",
        "FontName", "FontSize", "FontColor", "BackgroundColor",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "OrderedList", "UnorderedList",
        "Outdent", "Indent", "|",
        "CreateLink", "Image", "CreateTable", "|", "ClearFormat", "Print",
        "SourceCode", "FullScreen", "|", "Undo", "Redo"
            };
        return View();
    }
}