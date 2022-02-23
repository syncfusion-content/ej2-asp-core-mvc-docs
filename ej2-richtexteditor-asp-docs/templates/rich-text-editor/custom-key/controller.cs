public class HomeController : Controller
{
    public KeyModel KeyConfigData = new KeyModel();

    public class KeyModel
    {
        public string bold { get; set; }
        public string italic { get; set; }
        public string underline { get; set; }
    }
    public ActionResult Index()
    {
        KeyConfigData.bold = "ctrl+alt+b";
        KeyConfigData.italic = "ctrl+alt+i";
        KeyConfigData.underline = "ctrl+alt+u";

        ViewBag.keyConfig = KeyConfigData;

        ViewBag.items = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
        "FontName", "FontSize", "FontColor", "BackgroundColor",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "OrderedList", "UnorderedList",
        "Outdent", "Indent", "|",
        "CreateLink", "Image", "CreateTable", "|", "ClearFormat", "Print",
        "SourceCode", "FullScreen", "|", "Undo", "Redo" };

        return View();
    }

}
