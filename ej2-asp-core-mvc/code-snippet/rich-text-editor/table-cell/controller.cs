public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "CreateTable" };
        ViewBag.Table = new[] {
                "TableHeader", "TableRows", "TableColumns", "TableCell", "-", "BackgroundColor", "TableRemove", "TableCellVerticalAlign", "Styles"
            };
        return View();
    }
}
