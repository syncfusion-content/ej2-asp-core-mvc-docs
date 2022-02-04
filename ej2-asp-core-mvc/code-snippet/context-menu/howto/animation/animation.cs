using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ContextMenuController : Controller
    {
        public ActionResult Animation()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Show All Bookmarks"
            });
            menuItems.Add(new
            {
                text = "Bookmarks Toolbar",
                items = new List<object>()
                {
                    new { 
                        text = "Most Visited",
                        items = new List<object>()
                        {
                            new {
                                text = "Google"
                            },
                            new {
                                text = "Gmail"
                            }
                        }
                    },
                    new {
                        text = "Recently Added"
                    }
                }
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}