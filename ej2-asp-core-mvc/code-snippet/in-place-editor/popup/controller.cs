public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.positionData = new string[] { "TopLeft", "TopCenter", "TopRight", "BottomLeft", "BottomCenter", "BottomRight", "LeftTop", "LeftCenter", "LeftBottom", "RightTop", "RightCenter", "RightBottom" };
        ViewBag.modelData = new { placeholder = "Enter some text" };
        ViewBag.text = "BottomCenter";
        ViewBag.textValue = "Andrew";
        ViewBag.model = new { position = "BottomCenter" };
        return View();
    }
}