using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.Button
{
    public partial class ButtonController : Controller
    {
        public ActionResult DropDownButton()
        {
            List<object> listdata = new List<object>();
            listdata.Add(new
            {
                text = "Print",
                id = "data1",
                category = "Customize Quick Access Toolbar"
            });
            listdata.Add(new
            {
                text = "Save As",
                id = "data2",
                category = "Customize Quick Access Toolbar"
            });
            listdata.Add(new
            {
                text = "Update Folder",
                id = "data3",
                category = "Customize Quick Access Toolbar"
            });
            listdata.Add(new
            {
                text = "Reply",
                id = "data4",
                category = "Customize Quick Access Toolbar"
            });
            ViewBag.listdata = listdata;
            return View();
        }
    }
}