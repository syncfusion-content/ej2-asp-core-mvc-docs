public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.items = new[] { "NumberFormatList", "BulletFormatList" };
        return View();
    }
}