using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult list()
        {   
            List<object> listdata = new List<object>();
            listdata.Add(new
            {
                Name = "IBM Open-Sources Web Sphere Liberty Code",
                content = "In September, IBM announced that it would be open-sourcing the code for WebSphere...",
                id = "1",
                image = "https://ej2.syncfusion.com/demos/src/listview/images/1.png",
                timeStamp = "Syncfusion Blog - October 19, 2017"
            });

            listdata.Add(new
            {
                Name = "Must Reads: 5 Big Data E-books to upend your development",
                content = "Our first e-book was published in May 2012-jQuery Succinctly was the start of over...",
                id = "2",
                image = "https://ej2.syncfusion.com/demos/src/listview/images/2.png",
                timeStamp = "Syncfusion Blog - October 18, 2017"
            });
            listdata.Add(new
            {
                Name = "The Syncfusion Global License: Your Questions, Answered ",
                content = "Syncfusion recently hosted a webinar to cover the ins and outs of the Syncfusion global...",
                id = "4",
                image = "https://ej2.syncfusion.com/demos/src/listview/images/3.png",
                timeStamp = "Syncfusion Blog - October 18, 2017"
            });

            listdata.Add(new
            {
                Name = "Know: What is Coming from Microsoft this Fall ",
                content = "On October 17, Microsoft will release its Fall Creators Update for the Windows 10 platform...",
                id = "5",
                image = "https://ej2.syncfusion.com/demos/src/listview/images/6.png",
                timeStamp = "Syncfusion Blog - October 17, 2017"
            });
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}