public class HomeController : Controller
{
    public ActionResult Index()
    {
        string hostUrl = "https://ej2-aspcore-service.azurewebsites.net/";
        ViewBag.ajaxSettings = new {
            url = hostUrl + "api/FileManager/FileOperations",
            getImageUrl = hostUrl + "api/FileManager/GetImage",
            uploadUrl = hostUrl + "api/FileManager/Upload",
            downloadUrl = hostUrl + "api/FileManager/Download"
        };
        ViewBag.items = new[] { "FileManager", "Image" };
        return View();
    }
}