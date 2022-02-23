using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ListBoxController : Controller
    {
        public IActionResult icons()
        {
           List<object> Data = new List<object>{
           new { Text = "Account Settings", IconCss = "e-list-icons e-list-user-settings" },
           new { Text = "Address Book", IconCss = "e-list-icons e-list-address-book" },
           new { Text = "Forward", IconCss = "e-list-icons e-list-delete"  },
           new { Text = "Reply", IconCss = "e-list-icons e-list-reply" },
           new { Text = "Reply All", IconCss = "e-list-icons e-list-reply-all" },
           new { Text = "Save All Attachments", IconCss = "e-list-icons e-list-save-all-attachments" },
           new { Text = "Save As", IconCss = "e-list-icons e-list-icon-save-as" },
           new { Text = "Touch/Mouse Mode", IconCss = "e-list-icons e-list-touch" },
           new { Text = "Undo", IconCss = "e-list-icons e-list-undo" },
        };
            ViewBag.data = Data;
            return View();
        }
    }
}