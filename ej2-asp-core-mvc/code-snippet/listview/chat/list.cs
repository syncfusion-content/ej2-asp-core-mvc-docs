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
            List<object> listData = new List<object>();
            listData.Add(new
            {
                text = "Jenifer",
                contact = "Hi",
                id = "1",
                avatar = "",
                pic = "pic01",
                chat = "sender"
            });
            listData.Add(new { text = "Amenda", contact = "Hello", id = "2", avatar = "A", pic = "", chat = "receiver" });
            listData.Add(new
            {
                text = "Jenifer",
                contact = "What Knid of application going to launch",
                id = "4",
                avatar = "",
                pic = "pic02",
                chat = "sender"
            });
            listData.Add(new
            {
                text = "Amenda ",
                contact = "A knid of Emergency broadcast App",
                id = "5",
                avatar = "A",
                pic = "",
                chat = "receiver"
            });
            listData.Add(new
            {
                text = "Jacob",
                contact = "Can you please elaborate",
                id = "6",
                avatar = "",
                pic = "pic04",
                chat = "sender"
            });
            ViewBag.dataSource = listData;
            return View();
        }       
    }
}