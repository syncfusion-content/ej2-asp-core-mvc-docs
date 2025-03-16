public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = @"<p>The Syncfudion Rich Text Editor, a WYSIWYG (what you see is what you get) editor, is a user interface that allows you to create, edit, and format rich text content. You can try out a demo of this editor here.</p><p><b>Key features:</b></p><ul><li><p>Provides &lt;IFRAME&gt; and &lt;DIV&gt; modes.</p></li><li><p>Bulleted and numbered lists.</p></li><li><p>Handles images, hyperlinks, videos, hyperlinks, uploads, etc.</p></li><li><p>Contains undo/redo manager. </p></li></ul><div style='display: inline-block; width: 60%; vertical-align: top; cursor: auto;'><img alt='Sky with sun' src='https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png' width='309' style='min-width: 10px; min-height: 10px; width: 309px; height: 174px;' class='e-rte-image e-imginline e-rte-drag-image' height='174' /></div>";
        object size1 = new
        {
            text = "8 px",
            value = "8px"
        };
        object size2 = new
        {
            text = "10 px",
            value = "10px"
        };
        object size3 = new
        {
            text = "12 px",
            value = "12px"
        };
        object size4 = new
        {
            text = "14 px",
            value = "14px"
        };
        object size5 = new
        {
            text = "42 px",
            value = "42px"
        };

        ViewBag.items = new[] { "FontSize" };
        ViewBag.fontSizeItems = new[] { size1, size2, size3, size4, size5 };
        return View();
    }

}