using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public IActionResult Template()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                answerType = "Selection",
                description = "Choose from options",
                iconCss = "e-icons e-list-unordered"
            });
            menuItems.Add(new
            {
                answerType = "Yes / No",
                description = "Select Yes or No",
                iconCss = "e-icons e-check-box"
            });
            menuItems.Add(new
            {
                answerType = "Text",
                description = "Type own answer",
                iconCss = "e-icons e-caption",
                items = new List<object>
                {
                    new
                    {
                        answerType = "Single line",
                        description = "Type answer in a single line",
                        iconCss = "e-icons e-text-form"
                    },
                    new
                    {
                        answerType = "Multiple line",
                        description = "Type answer in multiple lines",
                        iconCss = "e-icons e-text-wrap"
                    }
                }
            });
            menuItems.Add(new
            {
                answerType = "None",
                iconCss = "e-icons e-mouse-pointer",
                description = "No answer required"
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}