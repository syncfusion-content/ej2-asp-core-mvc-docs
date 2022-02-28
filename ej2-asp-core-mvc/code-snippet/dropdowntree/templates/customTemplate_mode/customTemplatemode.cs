using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using itemtemplates.Models;
using Syncfusion.EJ2.DropDowns;

namespace itemtemplates.Controllers
{
    public class HomeController : Controller
    {
        DropDownTreeFields templateData = new DropDownTreeFields();
        public ActionResult Index()
        {
            DropDownTreeTemplate dropdownTreeTemplate = new DropDownTreeTemplate();
            templateData.DataSource = dropdownTreeTemplate.Template();
            templateData.Value = "id";
            templateData.Text = "name";
            templateData.Expanded = "expanded";
            templateData.HasChildren = "hasChild";
            templateData.ParentValue = "pid";
            ViewBag.templateData = templateData;
            //ASP.NET Core Code Blocks
            ViewBag.localData = templateData.DataSource;
            return View();
        }
    }
}