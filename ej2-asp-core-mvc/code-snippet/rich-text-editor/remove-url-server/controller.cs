public class HomeController: Controller
{
    public ActionResult Index()
    {
        ViewBag.saveUrl = "[SERVICE_HOSTED_PATH]/api/RichTextEditor/SaveFile";
        ViewBag.removeUrl = "[SERVICE_HOSTED_PATH]/api/RichTextEditor/DeleteFile";
        ViewBag.path = "[SERVICE_HOSTED_PATH]/RichTextEditor/";
        return View();
    }
}