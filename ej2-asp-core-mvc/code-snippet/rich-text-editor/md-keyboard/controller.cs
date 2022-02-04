public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "Bold", "Italic", "StrikeThrough", "|",
        "Formats", "OrderedList", "UnorderedList", "|",
        "CreateLink", "Image", "CreateTable", "|","Undo", "Redo" };

        ViewBag.value = @"The sample is added to showcase **markdown editing**.

    Type or edit the content and apply formatting to view markdown formatted content.

    We can add our own custom formation syntax for the Markdown formation.

    The third-party library <b>Marked</b> is used in this sample to convert markdown into HTML content";

        return View();
    }
}