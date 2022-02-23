public class HomeController : Controller
{
    public ActionResult Index()
    {
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

        ViewBag.items = new[] { "FontName", "FontSize" };
        ViewBag.fontFamilyItems = new[] { item1, item2, item3, item4, item5, item6 };
        ViewBag.fontSizeItems = new[] { size1, size2, size3, size4, size5 };
        return View();
    }

}