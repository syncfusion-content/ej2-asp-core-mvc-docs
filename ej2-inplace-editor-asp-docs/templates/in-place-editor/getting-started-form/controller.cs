public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.elementModel = new { placeholder = "Enter your name" };
        ViewBag.dateValue = new DateTime(2018, 12, 04);
        ViewBag.dateModel = new { showTodayButton = true, placeholder = "Select date of birth" };
        string[] genderData = new string[] { "Male", "Female" };
        ViewBag.genderModel = new { placeholder = "Select gender", dataSource = genderData };
        ViewBag.elementValue = "Andrew";
        ViewBag.dropValue = "Male";
        return View();
    }
}