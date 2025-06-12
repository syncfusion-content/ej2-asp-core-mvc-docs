public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.value = @"<p>The Syncfusion Rich Text Editor, a WYSIWYG (what you see is what you get) editor, is a user interface that allows you to create, edit, and format rich text content. You can try out a demo of this editor here.</p><p><b>Key features:</b></p><ul><li><p>Provides &lt;IFRAME&gt; and &lt;DIV&gt; modes.</p></li><li><p>Bulleted and numbered lists.</p></li><li><p>Handles images, hyperlinks, videos, hyperlinks, uploads, etc.</p></li><li><p>Contains undo/redo manager. </p></li></ul><div style='display: inline-block; width: 60%; vertical-align: top; cursor: auto;'><img alt='Sky with sun' src='https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Overview.png' width='309' style='min-width: 10px; min-height: 10px; width: 309px; height: 174px;' class='e-rte-image e-imginline e-rte-drag-image' height='174' /></div>";
        ViewBag.items = new[] { "FontName"};
        
        object item1 = new
        {
            text = "Segoe UI",
            value = "Segoe UI"
        };
        object item2 = new
        {
            text = "Arial",
            value = "Arial,Helvetica,sans-serif"
        };
        object item3 = new
        {
            text = "Courier New",
            value = "Courier New,Courier,monospace"
        };
        object item4 = new
        {
            text = "Georgia",
            value = "Georgia,serif"
        };
        object item5 = new
        {
            text = "Impact",
            value = "Impact,Charcoal,sans-serif"
        };
        object item6 = new
        {
            text = "Calibri Light",
            value = "CalibriLight"
        };

        ViewBag.fontFamilyItems = new[] { item1, item2, item3, item4, item5, item6 };
        return View();
    }

}