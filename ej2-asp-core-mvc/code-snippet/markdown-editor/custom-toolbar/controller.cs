public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = "In Rich Text Editor, you click the toolbar buttons to format the words and the changes are visible immediately. Markdown is not like that. When you format the word in Markdown format, you need to add Markdown syntax to the word to indicate which words and phrases should look different from each other. Rich Text Editor supports markdown editing when the editorMode set as **markdown** and using both *keyboard interaction* and *toolbar action*, you can apply the formatting to text. You can add our own custom formation syntax for the Markdown formation, [sample link](https://ej2.syncfusion.com/home/). The third-party library <b>Marked</b> is used in this sample to convert markdown into HTML content.";
        var tools = new
        {
            tooltipText = "Insert Symbol",
            template = "<button class='e-tbar-btn e-btn' tabindex='-1' id='custom_tbar'  style='width:100%'><div class='e-tbar-btn-text rtecustomtool' style='font-weight: 500;'> &#937;</div></button>"
        };
        ViewBag.items = new object[] { "Bold", "Italic", "|", "Formats", "OrderedList",
            "UnorderedList", "|", "CreateLink", "Image", "CreateTable", "|", tools
            , "|", "Undo", "Redo"
        };
        ViewBag.button = new
        {
            content = "Insert",
            isPrimary = true
        };
        ViewBag.button1 = new
        {
            content = "Cancel"
        };
            
        return View();
    }
}