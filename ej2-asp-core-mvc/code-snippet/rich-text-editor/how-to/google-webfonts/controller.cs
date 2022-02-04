public class HomeController : Controller
{

    public ActionResult Index()
    {
        object item1 = new
        {
            text = "Segoe UI",
            value = "Segoe UI"
        };
        object item2 = new
        {
            text = "Roboto",
            value = "Roboto"
        };
        object item3 = new
        {
            text = "Great vibes",
            value = "Great Vibes,cursive"
        };
        object item4 = new
        {
            text = "Noto Sans",
            value = "Noto Sans"
        };
        object item5 = new
        {
            text = "Impact",
            value = "Impact,Charcoal,sans-serif"
        };
        object item6 = new
        {
            text = "Tahoma",
            value = "Tahoma,Geneva,sans-serif"
        };
        ViewBag.fontItems = new[] { item1, item2, item3, item4, item5, item6 };
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