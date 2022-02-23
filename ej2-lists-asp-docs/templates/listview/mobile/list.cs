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
                text= "Jenifer",
                contact= "(206) 555-985774",
                id= "1",
                avatar= "",
                pic= "pic01"
            });
            listdata.Add(new
            {
                text= "Amenda",
                contact= "(206) 555-3412",
                id= "2",
                avatar= "A",
                pic= ""
            });
            listdata.Add(new
            {

                text= "Isabella",
                contact= "(206) 555-8122",
                id= "4",
                avatar= "",
                pic= "pic02"
            });
            listdata.Add(new
            {
                text= "William ",
                contact= "(206) 555-9482",
                id= "5",
                avatar= "W",
                pic= ""
            });
            listdata.Add(new
            {
                text= "Jacob",
                contact= "(71) 555-4848",
                id= "6",
                avatar= "",
                pic= "pic04"
            });
            listdata.Add(new
            {
                text= "Matthew",
                contact= "(71) 555-7773",
                id= "7",
                avatar= "M",
                pic= ""
            });
            listdata.Add(new
            {
                text= "Oliver",
                contact= "(71) 555-5598",
                id= "8",
                avatar= "",
                pic= "pic03"
            });
            listdata.Add(new
            {
                text= "Charlotte",
                contact= "(206) 555-1189",
                id= "9",
                avatar= "C",
                pic= ""
            });
            ViewBag.dataSource = listdata;
            return View();
        }
    }
}
