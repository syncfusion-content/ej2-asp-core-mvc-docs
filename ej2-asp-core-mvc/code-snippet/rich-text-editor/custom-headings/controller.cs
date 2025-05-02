public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.items = new[] { "Formats"};
        ViewBag.value = @"<p>The Syncfudion Rich Text Editor, a WYSIWYG (what you see is what you get) editor, is a user interface that allows you to create, edit, and format rich text content. You can try out a demo of this editor here.</p><p><b>Key features:</b></p><ul><li><p>Provides &lt;IFRAME&gt; and &lt;DIV&gt; modes.</p></li><li><p>Bulleted and numbered lists.</p></li><li><p>Handles images, hyperlinks, videos, hyperlinks, uploads, etc.</p></li><li><p>Contains undo/redo manager. </p></li></ul><div style='display: inline-block; width: 60%; vertical-align: top; cursor: auto;'><img alt='Sky with sun' src='https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png' width='309' style='min-width: 10px; min-height: 10px; width: 309px; height: 174px;' class='e-rte-image e-imginline e-rte-drag-image' height='174' /></div>";
        ViewBag.customFormats = new[]
        {
            new { text= "Paragraph", value= "p"},
            new { text= "Heading 1", value= "h1"},
            new { text= "Heading 2", value= "h2" },
            new { text= "Heading 3", value= "h3" },
            new {text= "Heading 4", value= "h4" },
            new { text= "Heading 5", value= "h5" }
        };
            
        return View();
    }
}