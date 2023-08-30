public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "FormatPainter", "ClearFormat", "Bold", "Italic", "Underline", "|",
            "Formats", "Alignments", "OrderedList", "UnorderedList", "|", "CreateLink", "Image","|",
            "SourceCode", "Undo", "Redo"};
        ViewBag.allowedFormats = "p;h1;h2;h3;div;ul;ol;li;span;strong;em;code;";
        ViewBag.deniedFormats = "h3(e-rte-block-blue-text){background-color,padding,color}[title]; li{color}; span(e-inline-text-highlight){color}[title]; strong{color}(e-rte-strong-bg);";
        return View();
    }
}