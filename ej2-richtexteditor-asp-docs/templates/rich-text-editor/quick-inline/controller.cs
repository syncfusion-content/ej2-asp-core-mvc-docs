public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Bold", "Italic", "Underline",
            "Formats", "Alignments", "-", "OrderedList", "UnorderedList", "Image",
             "CreateLink" };
        object tools1 = new
        {
            tooltipText = "Rotate Left",
            template = "<button class='e-tbar-btn e-btn' id='roatateLeft'><span class='e-btn-icon e-icons e-rotate-left'></span>"
        };
        object tools2 = new
        {
            tooltipText = "Rotate Right",
            template = "<button class='e-tbar-btn e-btn' id='roatateRight'><span class='e-btn-icon e-icons e-rotate-right'></span>"
        };
        ViewBag.image = new[] {
            "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "-",
             "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension",tools1
             , tools2
             };

        return View();
    }

}