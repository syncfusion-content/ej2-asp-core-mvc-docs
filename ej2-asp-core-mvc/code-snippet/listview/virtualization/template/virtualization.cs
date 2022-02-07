using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult nestedlist()
        {
            List<object> listData = new List<object>();
            listData.Add(new { text = "Nancy", imgUrl = "", icon = "N", id = "0" });
            listData.Add(new { text = "Andrew", imgUrl = "", icon = "A", id = "1" });
            listData.Add(new { text = "Janet", imgUrl = "", icon = "J", id = "2" });
            listData.Add(new { text = "Margaret", icon = "", imgUrl = "./margaret.png", id = "3" });
            listData.Add(new { text = "Steven", imgUrl = "", icon = "S", id = "4" });
            listData.Add(new { text = "Laura", icon = "", imgUrl = "./images/laura.png", id = "5" });
            listData.Add(new { text = "Robert", imgUrl = "", icon = "R", id = "6" });
            listData.Add(new { text = "Michael", imgUrl = "", icon = "M", id = "7" });
            listData.Add(new { text = "Albert", icon = "", imgUrl = "./images/albert.png", id = "8" });
            listData.Add(new { text = "Nolan", imgUrl = "", icon = "N", id = "9" });


                for (int i = 10; i < 1000; i++)
                {
                    int index = new Random().Next(0, 10);
                    listData.Add(new
                    {
                        text = listData[index].GetType().GetProperty("text").GetValue(listData[index], null).ToString(),
                        icon = listData[index].GetType().GetProperty("icon").GetValue(listData[index], null).ToString(),
                        imgUrl = listData[index].GetType().GetProperty("imgUrl").GetValue(listData[index], null).ToString(),
                        id = i.ToString()
                    });
                }

            ViewBag.listData = listData;
            return View();
        }
    }
}