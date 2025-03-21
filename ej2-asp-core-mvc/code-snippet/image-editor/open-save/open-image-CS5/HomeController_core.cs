using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Popups;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ImageEditorController : Controller
    {

        public IActionResult ProfilePicture()
        {
            var permission = new Permission
            {
                copy = false,
                download = false,
                write = false,
                writeContents = false,
                read = true,
                upload = false,
                message = ""
            };
            var resultData = new List<FileData>
            {
                new FileData
                {
                    dateCreated = DateTime.Parse("2023-11-15T19:02:02.3419426+05:30"),
                    dateModified = DateTime.Parse("2024-01-08T16:55:20.9464164+05:30"),
                    filterPath = "\\",
                    hasChild = true,
                    id = "0",
                    isFile = false,
                    name = "Pictures",
                    parentId = "0",
                    size = 228465,
                    type = "folder"
                },
                new FileData
                {
                    dateCreated = DateTime.Parse("2023-11-15T19:02:02.3419426+05:30"),
                    dateModified = DateTime.Parse("2024-01-08T16:55:20.9464164+05:30"),
                    filterPath = "\\",
                    hasChild = false,
                    id = "1",
                    isFile = true,
                    name = "Flower",
                    parentId = "0",
                    size = 65536,
                    type = ".png",
                    imageUrl = "https://ej2.syncfusion.com/react/demos/src/image-editor/images/flower.png"
                },
                new FileData
                {
                    dateCreated = DateTime.Parse("2023-11-15T19:02:02.3419426+05:30"),
                    dateModified = DateTime.Parse("2024-01-08T16:55:20.9464164+05:30"),
                    filterPath = "\\",
                    hasChild = false,
                    id = "2",
                    isFile = true,
                    name = "Bridge",
                    parentId = "0",
                    size = 53248,
                    type = ".png",
                    imageUrl = "https://ej2.syncfusion.com/react/demos/src/image-editor/images/bridge.png"
                }
            };
            ViewBag.ResultData = resultData;
            return View();
        }
    }

    public class Permission
    {
        public bool copy { get; set; }
        public bool download { get; set; }
        public bool write { get; set; }
        public bool writeContents { get; set; }
        public bool read { get; set; }
        public bool upload { get; set; }
        public string? message { get; set; }
    }

    public class FileData
    {
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
        public string? filterPath { get; set; }
        public bool hasChild { get; set; }
        public string? id { get; set; }
        public bool isFile { get; set; }
        public string? name { get; set; }
        public string? parentId { get; set; }
        public int size { get; set; }
        public string? type { get; set; }
        public Permission? permission { get; set; }
        public string? imageUrl { get; set; }
    }
}