public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.model = new { placeholder = "Select a customer", fields = new { text = "ContactName", value = "CustomerID" } };
        ViewBag.value = "Maria Anders";
        return View();
    }
}