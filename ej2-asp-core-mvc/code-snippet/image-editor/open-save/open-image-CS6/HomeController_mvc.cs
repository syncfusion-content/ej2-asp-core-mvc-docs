using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Popups;
using Syncfusion.EJ2.ImageEditor;

namespace EJ2MVCSampleBrowser.Controllers.ImageEditor
{
    public partial class ImageEditorController : Controller
    {
        public ActionResult ProfilePicture()
        {
            var listdata = new List<object>();
            listdata.Add(new
            {
                id = 1,
                name = "Videos",
                icon = "folder",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 2,
                pid = 1,
                name = "Naturals.mp4",
                icon = "video"
            });
            listdata.Add(new
            {
                id = 3,
                pid = 1,
                name = "Wild.mpeg",
                icon = "video"
            });

            listdata.Add(new
            {
                id = 4,
                name = "Documents",
                icon = "folder",
                hasChild = true
            });
            listdata.Add(new
            {
                id = 5,
                pid = 4,
                name = "Environment Pollution.docx",
                icon = "docx"
            });
            listdata.Add(new
            {
                id = 6,
                pid = 4,
                name = "Global Water, Sanitation, & Hygiene.docx",
                icon = "docx"
            });
            listdata.Add(new
            {
                id = 7,
                pid = 4,
                name = "Global Warming.ppt",
                icon = "ppt"
            });
            listdata.Add(new
            {
                id = 8,
                pid = 7,
                name = "Social Network.pdf",
                icon = "pdf"
            });
            listdata.Add(new
            {
                id = 9,
                pid = 7,
                name = "Youth Empowerment.pdf",
                icon = "pdf"
            });
            listdata.Add(new
            {
                id = 10,
                name = "Pictures",
                hasChild = true,
                icon = "folder",
                expanded = true
            });
            listdata.Add(new
            {
                id = 11,
                pid = 10,
                name = "WIN_20160726_094117.JPG",
                image = "https://ej2.syncfusion.com/react/demos/src/image-editor/images/bridge.png"
            });
            listdata.Add(new
            {
                id = 12,
                pid = 10,
                name = "WIN_20160726_094118.JPG",
                image = "https://ej2.syncfusion.com/react/demos/src/image-editor/images/flower.png"
            });
            ViewBag.Listdata = listdata;
            return View();
        }
    }
    public class DefaultButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}