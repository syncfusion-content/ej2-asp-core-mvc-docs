public class HomeController : Controller
{

    public ActionResult Index()
    {
        object tools1 = new
        {
            tooltipText = "Preview",
            template = "<button id='preview-code' class='e-tbar-btn e-control e-btn e-icon-btn'>" +
"<span class='e-btn-icon e-md-preview e-icons'></span></button>"
        };
        ViewBag.items = new[] { "Bold", "Italic", "StrikeThrough", "|", "Formats", "OrderedList", "UnorderedList", "|", "CreateLink", "Image", "CreateTable", "|", tools1, "|", "Undo", "Redo" };

        ViewBag.value = @"In Rich Text Editor , you click the toolbar buttons to format the words and the changes are visible immediately. 
Markdown is not like that. When you format the word in Markdown format, you need to add Markdown syntax to the word to indicate which words 
and phrases should look different from each other.

RichTextEditor supports markdown editing when the editorMode set as **markdown** and using both *keyboard interaction* and *toolbar action*, you can apply the formatting to text.

We can add our own custom formation syntax for the Markdown formation, [sample link](https://ej2.syncfusion.com/javascript/demos/#/material/rich-text-editor/markdown-editor-custom-format.html).

The third-party library <b>Marked</b> is used in this sample to convert markdown into HTML content";
        return View();
    }
}