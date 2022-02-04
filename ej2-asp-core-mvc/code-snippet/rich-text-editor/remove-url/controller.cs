public class HomeController : Controller
{
    private IWebHostEnvironment hostingEnv;

    public HomeController(IWebHostEnvironment env)
    {
        hostingEnv = env;
    }

    public ActionResult Index()
    {
        return View();
    }

    [AcceptVerbs("Post")]
    public void SaveImage(IList<IFormFile> UploadFiles)
    {
        try
        {
            foreach (IFormFile file in UploadFiles)
            {
                if (UploadFiles != null)
                {
                    string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    filename = hostingEnv.WebRootPath + "\\Uploads" + $@"\{filename}";

                    // Create a new directory, if it does not exists
                    if (!Directory.Exists(hostingEnv.WebRootPath + "\\Uploads"))
                    {
                        Directory.CreateDirectory(hostingEnv.WebRootPath + "\\Uploads");
                    }

                    if (!System.IO.File.Exists(filename))
                    {
                        using (FileStream fs = System.IO.File.Create(filename))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                        Response.StatusCode = 200;
                    }
                }
            }
        }
        catch (Exception)
        {
            Response.StatusCode = 204;
        }
    }

    [AcceptVerbs("Post")]
    public void RemoveImage(IList<IFormFile> UploadFiles)
    {
        try
        {
            foreach (IFormFile file in UploadFiles)
            {
                if (UploadFiles != null)
                {
                    // Do remove action here}
                    Response.StatusCode = 200;
                }
            }
        }
        catch (Exception)
        {
            Response.StatusCode = 204;
        }
    }
}
