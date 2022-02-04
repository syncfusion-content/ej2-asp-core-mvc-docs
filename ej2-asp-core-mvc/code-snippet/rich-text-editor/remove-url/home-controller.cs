public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [AcceptVerbs("Post")]
    public void SaveImage(HttpPostedFileBase UploadFiles)
    {
        try
        {
            if (UploadFiles != null)
            {
                string fileName = UploadFiles.FileName;
                var fileSave = System.Web.HttpContext.Current.Server.MapPath("~/Uploads");

                // Create a new directory, if it does not exists
                if (!System.IO.Directory.Exists(fileSave))
                {
                    System.IO.Directory.CreateDirectory(fileSave);
                }

                var fileSavePath = Path.Combine(fileSave, fileName);

                // Save the image
                UploadFiles.SaveAs(fileSavePath);

                Response.StatusCode = 200;
                Response.ContentType = "application/json; charset=utf-8";
            }
        }
        catch (Exception)
        {
            Response.StatusCode = 204;
        }
    }

    [AcceptVerbs("Post")]
    public void RemoveImage(HttpPostedFileBase UploadFiles)
    {
        
        try
        {
            if (UploadFiles != null)
            {
                // Do remove action here

                Response.StatusCode = 200;
                Response.ContentType = "application/json; charset=utf-8";
            }
        }
        catch (Exception)
        {
            Response.StatusCode = 204;
        }
    }
}
