using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
//File Manager's base functions are available in the below package
using Syncfusion.EJ2.FileManager.Base;
//File Manager's operations are available in the below package
using Syncfusion.EJ2.FileManager.PhysicalFileProvider;
using Newtonsoft.Json;
using System.Web.Hosting;


namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // Accessing the File Operations from File Manager package
        PhysicalFileProvider operation = new PhysicalFileProvider();
        public HomeController()
        {
            // Map the path of the files to be accessed with the host
            var path = HostingEnvironment.MapPath("~/Content/Files");
            // Assign the mapped path as root folder
            operation.RootFolder(path);
            // Set Rules for folder and file Access
            operation.SetRules(GetRules());
        }

        public ActionResult FileOperations(FileManagerDirectoryContent args)
        {
            // Processing the File Manager operations
            switch (args.Action)
            {
                case "read":
                    return Json(operation.ToCamelCase(operation.GetFiles(args.Path, args.ShowHiddenItems)));
                case "delete":
                    return Json(operation.ToCamelCase(operation.Delete(args.Path, args.Names)));
                case "copy":
                    return Json(operation.ToCamelCase(operation.Copy(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData)));
                case "move":
                    return Json(operation.ToCamelCase(operation.Move(args.Path, args.TargetPath, args.Names, args.RenameFiles, args.TargetData)));
                case "details":
                    if (args.Names == null)
                    {
                        args.Names = new string[] { };
                    }
                    return Json(operation.ToCamelCase(operation.Details(args.Path, args.Names)));
                case "create":
                    return Json(operation.ToCamelCase(operation.Create(args.Path, args.Name)));
                case "search":
                    return Json(operation.ToCamelCase(operation.Search(args.Path, args.SearchString, args.ShowHiddenItems, args.CaseSensitive)));
                case "rename":
                    return Json(operation.ToCamelCase(operation.Rename(args.Path, args.Name, args.NewName)));
            }
            return null;
        }

        public ActionResult Upload(string path, IList<System.Web.HttpPostedFileBase> uploadFiles, string action)
        {
            FileManagerResponse uploadResponse;
            uploadResponse = operation.Upload(path, uploadFiles, action, null);
            return Content("");
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

        public AccessDetails GetRules()
        {
            AccessDetails accessDetails = new AccessDetails();
            List<AccessRule> Rules = new List<AccessRule> {
                // FileRules For Default User
                new AccessRule { Path = "/*.*", Role = "Default User", Read = Permission.Deny, Write = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny, IsFile = true },
                // FileRules For Administrator
                new AccessRule { Path = "/*.*", Role = "Administrator", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Allow, Download = Permission.Allow, IsFile = true },
                // FileRules For Document Manager
                new AccessRule { Path = "/*.*", Role = "Document Manager", Read = Permission.Deny, Write = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny, IsFile = true },
                new AccessRule { Path = "/Documents/*.*", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Allow, Download = Permission.Allow, IsFile = true },
                new AccessRule { Path = "/*.png", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny, IsFile = true },
                new AccessRule { Path = "/Documents/*.png", Role = "Document Manager", Read = Permission.Deny, Write = Permission.Allow, Copy = Permission.Deny, Download = Permission.Allow, IsFile = true },
                new AccessRule { Path = "/2.*", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Deny, Download = Permission.Deny, IsFile = true },
                new AccessRule { Path = "/Documents/2.*", Role = "Document Manager", Read = Permission.Deny, Write = Permission.Deny, Copy = Permission.Deny, Download = Permission.Allow, IsFile = true },
                new AccessRule { Path = "/2.png", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Deny, Download = Permission.Allow, IsFile = true },
                new AccessRule { Path = "/Documents/2.png", Role = "Document Manager", Read = Permission.Deny, Write = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny, IsFile = true },
                new AccessRule { Path = "/text", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Deny, Download = Permission.Allow, IsFile = true },
                new AccessRule { Path = "/Documents/text", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Deny, Download = Permission.Deny, IsFile = true },
                // FolderRules For Default User
                new AccessRule { Path = "*", Role = "Default User", Read = Permission.Deny, Write = Permission.Deny, Copy = Permission.Deny, WriteContents = Permission.Deny, Upload = Permission.Deny, Download = Permission.Deny, IsFile = false },
                new AccessRule { Path = "/", Role = "Default User", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Deny, WriteContents = Permission.Deny, Upload = Permission.Deny, Download = Permission.Deny, IsFile = false },
                // FolderRules For Administrator
                new AccessRule { Path = "*", Role = "Administrator", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Allow, WriteContents = Permission.Allow, Upload = Permission.Allow, Download = Permission.Deny, IsFile = false },
                new AccessRule { Path = "/", Role = "Administrator", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Allow, WriteContents = Permission.Allow, Upload = Permission.Allow, Download = Permission.Deny, IsFile = false },
                // FolderRules For Document Manager
                new AccessRule { Path = "*", Role = "Document Manager", Read = Permission.Deny, Write = Permission.Deny, Copy = Permission.Deny, WriteContents = Permission.Deny, Upload = Permission.Deny, Download = Permission.Deny, IsFile = false },
                new AccessRule { Path = "/", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Deny, WriteContents = Permission.Deny, Upload = Permission.Deny, Download = Permission.Deny, IsFile = false },
                new AccessRule { Path = "/Documents", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Deny, Copy = Permission.Allow, WriteContents = Permission.Allow, Upload = Permission.Allow, Download = Permission.Deny, IsFile = false },
                new AccessRule { Path = "/Documents/*", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Allow, WriteContents = Permission.Allow, Upload = Permission.Allow, Download = Permission.Allow, IsFile = false },
                new AccessRule { Path = "/Music.png", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Allow, WriteContents = Permission.Allow, Upload = Permission.Allow, Download = Permission.Allow, IsFile = false },
                new AccessRule { Path = "/Documents/Music.png", Role = "Document Manager", Read = Permission.Allow, Write = Permission.Allow, Copy = Permission.Allow, WriteContents = Permission.Allow, Upload = Permission.Deny, Download = Permission.Deny, IsFile = false },
            };
            accessDetails.AccessRules = Rules;
            accessDetails.Role = "Document Manager";
            return accessDetails;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
