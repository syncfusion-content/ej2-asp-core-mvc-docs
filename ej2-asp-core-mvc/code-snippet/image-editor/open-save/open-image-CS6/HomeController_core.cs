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
            var ParentItems = new List<Parentitem>();
            var ChildItem1 = new List<Childitem>();
            var ChildItem2 = new List<Childitem>();
            var ChildItem3 = new List<Childitem>();
            ParentItems.Add(new Parentitem
            {
                NodeId = "01",
                NodeText = "Videos",
                Icon = "folder",
                Child = ChildItem1,
            });
            ChildItem1.Add(new Childitem { NodeId = "01-01", NodeText = "Naturals.mp4", Icon = "video" });
            ChildItem1.Add(new Childitem { NodeId = "01-02", NodeText = "Wild.mpeg", Icon = "video" });

            ParentItems.Add(new Parentitem
            {
                NodeId = "02",
                NodeText = "Documents",
                Icon = "folder",
                Child = ChildItem2,
            });
            ChildItem2.Add(new Childitem { NodeId = "02-01", NodeText = "Environment Pollution.docx", Icon = "docx" });
            ChildItem2.Add(new Childitem { NodeId = "02-02", NodeText = "Global Water, Sanitation, & Hygiene.docx", Icon = "docx" });
            ChildItem2.Add(new Childitem { NodeId = "02-03", NodeText = "Global Warming.ppt", Icon = "ppt" });
            ChildItem2.Add(new Childitem { NodeId = "02-04", NodeText = "Social Network.pdf", Icon = "pdf" });
            ChildItem2.Add(new Childitem { NodeId = "02-05", NodeText = "Youth Empowerment.pdf", Icon = "pdf" });

            ParentItems.Add(new Parentitem
            {
                NodeId = "03",
                NodeText = "Pictures",
                Icon = "folder",
                Child = ChildItem3,
                Expanded = true
            });
            ChildItem3.Add(new Childitem { NodeId = "03-01", NodeText = "WIN_20160726_094117.JPG", Image = "https://ej2.syncfusion.com/react/demos/src/image-editor/images/bridge.png" });
            ChildItem3.Add(new Childitem { NodeId = "03-02", NodeText = "WIN_20160726_094118.JPG", Image = "https://ej2.syncfusion.com/react/demos/src/image-editor/images/flower.png" });
            ViewBag.ParentItems = ParentItems;
            return View();
        }
    }

    public class Parentitem
    {
        public string NodeId;
        public string NodeText;
        public string Image;
        public string Icon;
        public bool Expanded;
        public bool Selected;
        public List<Childitem> Child;

    }
    public class Childitem
    {
        public string NodeId;
        public string NodeText;
        public string Image;
        public string Icon;
        public bool Expanded;
        public bool Selected;
        public List<SubChilditem> Child;

    }
    public class SubChilditem
    {
        public string NodeId;
        public string NodeText;
        public string Image;
        public string Icon;
        public bool Expanded;
        public bool Selected;

    }
}