public class HomeController : Controller
{
    public ActionResult Index()
    {
        string[] genderData = new string[] { "Male", "Female" };
        ViewBag.modalData = new { placeholder = "Select gender", dataSource = genderData };
        return View();
    }
}