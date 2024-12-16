using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Hosting;
using Newtonsoft.Json;
using Syncfusion.EJ2.FileManager.PhysicalFileProvider;
using Syncfusion.EJ2.FileManager.Base;
using System.Web;
using System;
using System.IO;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // Accessing the File Operations from File Manager package
        PhysicalFileProvider operation = new PhysicalFileProvider();
        public string basePath;
        public HomeController()
        {
            this.basePath = HostingEnvironment.MapPath("~/Content/Files");
            this.operation.RootFolder(HostingEnvironment.MapPath("~/Content/Files"));
        }
        public ActionResult FileOperations(FileManagerDirectoryContent args)
        {

            switch (args.Action)
            {
                case "read":
                    return Json(operation.ToCamelCase(operation.GetFiles(args.Path, args.ShowHiddenItems)));
                case "delete":
                    return Json(operation.ToCamelCase(operation.Delete(args.Path, args.Names)));
                case "details":
                    if(args.Names == null)
                    {
                       args.Names = new string[] { };
                    }
                    return Json(operation.ToCamelCase(operation.Details(args.Path, args.Names, args.Data)));
                case "create":
                    return Json(operation.ToCamelCase(operation.Create(args.Path, args.Name)));
                case "search":
                    return Json(operation.ToCamelCase(operation.Search(args.Path, args.SearchString, args.ShowHiddenItems, args.CaseSensitive)));
                case "copy":
                    return Json(operation.ToCamelCase(operation.Copy(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData)));
                case "move":
                    return Json(operation.ToCamelCase(operation.Move(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData)));
                case "rename":
                    return Json(operation.ToCamelCase(operation.Rename(args.Path, args.Name, args.NewName)));
            }
            return null;

        }
        public ActionResult Upload(string path, IList<System.Web.HttpPostedFileBase> uploadFiles, string action)
        {
            try
            {
                FileManagerResponse uploadResponse;
                foreach (var file in uploadFiles)
                {
                    var folders = (file.FileName).Split('/');
                    // checking the folder upload
                    if (folders.Length > 1)
                    {
                        for (var i = 0; i < folders.Length - 1; i++)
                        {
                            string newDirectoryPath = Path.Combine(this.basePath + path, folders[i]);
                            if (Path.GetFullPath(newDirectoryPath) != (Path.GetDirectoryName(newDirectoryPath) + Path.DirectorySeparatorChar + folders[i]))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            if (!Directory.Exists(newDirectoryPath))
                            {
                                this.operation.ToCamelCase(this.operation.Create(path, folders[i]));
                            }
                            path += folders[i] + "/";
                        }
                    }
                }
                // Invoking upload operation with the required paramaters
                // path - Current path where the file is to uploaded; uploadFiles - Files to be uploaded; action - name of the operation(upload)
                uploadResponse = operation.Upload(path, uploadFiles, action, null);
                return Content("");
            }
            catch (Exception e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                er.Message = "Access denied for Directory-traversal";
                Response.Clear();
                Response.ContentType = "application/json; charset=utf-8";
                Response.StatusCode = Convert.ToInt32(er.Code);
                return Content("");
            }
        }

        public ActionResult Download(string downloadInput)
        {
            FileManagerDirectoryContent args = JsonConvert.DeserializeObject<FileManagerDirectoryContent>(downloadInput);
            return operation.Download(args.Path, args.Names);

        }


        public ActionResult GetImage(FileManagerDirectoryContent args)
        {
            return operation.GetImage(args.Path, args.Id, false, null, null);
        }
    
        public ActionResult Index()
        {
            return View();
        }
    }
}