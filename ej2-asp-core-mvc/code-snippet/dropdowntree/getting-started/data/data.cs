using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DropDownTree.Models;
using Syncfusion.EJ2.DropDowns;

namespace DropDownTree.Controllers
{
    public class DropDownTreeController : Controller
    {
          public IActionResult Index()
        {
            List<Parent> parentitem = new List<Parent>();
            List<Child> childitem = new List<Child>();
            parentitem.Add(new Parent
            {
                nodeId = "01",
                nodeText = "Music",
                nodeChild = childitem,
            });
            childitem.Add(new Child { nodeId = "01-01", nodeText = "Gouttes.mp3" });

            List<Child> childitem2 = new List<Child>();
            parentitem.Add(new Parent
            {
                nodeId = "02",
                nodeText = "Videos",
                expanded=true,
                nodeChild = childitem2,
            });
            childitem2.Add(new Child { nodeId = "02-01", nodeText = "Naturals.mp4" });
            childitem2.Add(new Child { nodeId = "02-02", nodeText = "Wild.mpeg"});
            List<Child> childitem3 = new List<Child>();
            parentitem.Add(new Parent
            {
                nodeId = "03",
                nodeText = "Documents",
                nodeChild = childitem3,
            });
            childitem3.Add(new Child { nodeId = "03-01", nodeText = "Environment Pollution.docx" });
            childitem3.Add(new Child { nodeId = "03-02", nodeText = "Global Water, Sanitation, & Hygiene.docx"});
            childitem3.Add(new Child { nodeId = "03-03", nodeText = "Global Warming.ppt" });
            childitem3.Add(new Child { nodeId = "03-04", nodeText = "Social Network.pdf" });
            childitem3.Add(new Child { nodeId = "03-05", nodeText = "Youth Empowerment.pdf"});
            ViewBag.dataSource = parentitem;
            char[] value = { 'n','o','d','e','C', 'h', 'i', 'l', 'd' };
            string Child = new string(value);
            ViewBag.child = Child;
            return View();
        }
          public class Parent
        {
            public string nodeId;
            public string nodeText;
            public string icon;
            public bool expanded;
            public bool selected;
            public List<Child> nodeChild;

        }
        public class Child
        {
            public string nodeId;
            public string nodeText;
            public string icon;
            public bool expanded;
            public bool selected;
            public List<Child> nodeChild;

        }
    }
}