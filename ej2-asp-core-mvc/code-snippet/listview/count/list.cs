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
            listdata.Add(new { Name = "Nancy", contact = "(206) 555-985774", id = "1", image = "https://ej2.syncfusion.com/demos/src/grid/images/1.png", category = "Experience" });
            listdata.Add(new { Name = "Janet", contact = "(206) 555-3412", id = "2", image = "https://ej2.syncfusion.com/demos/src/grid/images/3.png", category = "Fresher" });
            listdata.Add(new { Name = "Margaret", contact = "(206) 555-8122", id = "4", image = "https://ej2.syncfusion.com/demos/src/grid/images/4.png", category = "Experience" });
            listdata.Add(new { Name = "Andrew ", contact = "(206) 555-9482", id = "5", image = "https://ej2.syncfusion.com/demos/src/grid/images/2.png", category = "Experience" });
            listdata.Add(new { Name = "Steven", contact = "(71) 555-4848", id = "6", image = "https://ej2.syncfusion.com/demos/src/grid/images/5.png", category = "Fresher" });
            listdata.Add(new { Name = "Michael", contact = "(71) 555-7773", id = "7", image = "https://ej2.syncfusion.com/demos/src/grid/images/6.png", category = "Experience" });
            listdata.Add(new { Name = "Robert", contact = "(71) 555-5598", id = "8", image = "https://ej2.syncfusion.com/demos/src/grid/images/7.png", category = "Fresher" });
            listdata.Add(new { Name = "Laura", contact = "(206) 555-1189", id = "9", image = "https://ej2.syncfusion.com/demos/src/grid/images/8.png", category = "Experience" });
            ViewBag.dataSource = listdata;
            return View();
        }
    }
}
