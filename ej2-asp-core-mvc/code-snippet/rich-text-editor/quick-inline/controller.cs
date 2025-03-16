public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.value = @"<p>The Syncfudion Rich Text Editor, a WYSIWYG (what you see is what you get) editor, is a user interface that allows you to create, edit, and format rich text content. You can try out a demo of this editor here.</p><p><b>Key features:</b></p><ul><li><p>Provides &lt;IFRAME&gt; and &lt;DIV&gt; modes.</p></li><li><p>Bulleted and numbered lists.</p></li><li><p>Handles images, hyperlinks, videos, hyperlinks, uploads, etc.</p></li><li><p>Contains undo/redo manager. </p></li></ul><div style='display: inline-block; width: 60%; vertical-align: top; cursor: auto;'><img alt='Sky with sun' src='https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png' width='309' style='min-width: 10px; min-height: 10px; width: 309px; height: 174px;' class='e-rte-image e-imginline e-rte-drag-image' height='174' /></div>";
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