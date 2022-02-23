public class HomeController : Controller
{
    public ActionResult Index()
    {
        string[] frameWorkList = new string[] { "Andrew Fuller", "Janet Leverling", "Laura Callahan", "Margaret Hamilt", "Michael Suyama", "Nancy Davloio", "Robert King" };
        ViewBag.elementModel = new { dataSource = frameWorkList, placeholder = "Select employee", popupHeight = "200px" };
        ViewBag.url = "https://ej2services.syncfusion.com/development/web-services/api/Editor/UpdateData";
        ViewBag.textValue = "Andrew Fuller";
        return View();
    }
}