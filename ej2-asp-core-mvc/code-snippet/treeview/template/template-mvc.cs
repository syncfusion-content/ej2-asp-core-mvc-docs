using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;
using Syncfusion.EJ2.Navigations;

namespace EJ2CoreSampleBrowser.Controllers.TreeView
{
    public partial class TreeViewController : Controller
    {

        public IActionResult Template()
        {
           TreeViewFieldsSettings templateFields = new TreeViewFieldsSettings();
            TreeviewTemplate treeviewTemplate = new TreeviewTemplate();
            templateFields.DataSource = treeviewTemplate.getTreeviewTemplate();
            templateFields.HasChildren = "HasChild";
            templateFields.Expanded = "Expanded";
            templateFields.Selected = "Selected";
            templateFields.Id = "id";
            templateFields.ParentID = "pid";
            templateFields.Text = "name";
            ViewBag.templateFields = templateFields;
            return View();
        }
    }
}
