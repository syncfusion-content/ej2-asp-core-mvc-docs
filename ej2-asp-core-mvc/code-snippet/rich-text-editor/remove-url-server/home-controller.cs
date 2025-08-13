public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewData["InsertImageSettings"] = new RichTextEditorImageSettings
        {
            SaveUrl = "[SERVICE_HOSTED_PATH]/api/RichTextEditor/SaveFile",
            RemoveUrl = "[SERVICE_HOSTED_PATH]/api/RichTextEditor/DeleteFile",
            Path = "[SERVICE_HOSTED_PATH]/RichTextEditor/"
        };
        return View();
    }
}
