using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DropDownButtonController : Controller
    {
        public ActionResult Template()
        {
            List<object> items = new List<object>();
            items.Add(new
            {
                text = 'Home',
                iconCss = 'e-icons e-home'
            });
            items.Add(new
            {
                text = 'Search',
                iconCss = 'e-icons e-search',
                url = 'http://www.google.com'
            });
            items.Add(new
            {
                text = 'Yes / No',
                iconCss = 'e-icons e-check-box'
            });
            items.Add(new
            {
                text = 'Text',
                iconCss = 'e-icons e-caption',
            });
            items.Add(new
            {
                separator = "True"
            });
            items.Add(new
            {
                text = 'Syncfusion',
                iconCss = 'e-icons e-mouse-pointer',
                url = 'http://www.syncfusion.com'
            });
            ViewBag.items = items;
            return View();
        }
    }
}