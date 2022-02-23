using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Popups;

namespace WebApplication1.Controllers
{
    public class ListViewController : Controller
    {
        public IActionResult list()
        {
            List<DialogDialogButton> button = new List<DialogDialogButton>();
            List<object> listdata = new List<object>();
            listdata.Add(new { text = "Date", id = "1", imgUrl = "./dates.jpg" });
            listdata.Add(new { text = "Fig", id = "2", imgUrl = "./fig.jpg" });
            listdata.Add(new { text = "Apple", id = "3", imgUrl = "./apple.png" });
            listdata.Add(new { text = "Apricot", id = "4", imgUrl = "./apricot.jpg" });
            listdata.Add(new { text = "Grape", id = "5", imgUrl = "./grape.jpg" });
            listdata.Add(new { text = "Strawberry", id = "6", imgUrl = "./strawberry.jpg" });
            listdata.Add(new { text = "Pineapple", id = "7", imgUrl = "./pineapple.jpg" });
            listdata.Add(new { text = "Melon", id = "8", imgUrl = "./melon.jpg" });
            listdata.Add(new { text = "Lemon", id = "9", imgUrl = "./lemon.jpg" });
            listdata.Add(new { text = "Cherry", id = "10", imgUrl = "./cherry.jpg" });
            ViewBag.dataSource = listdata;
            button.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new ButtonModel() { isPrimary = true, content = "Add" } });
            ViewBag.DialogButtons = button;
            return View();

        }
        public class ButtonModel
        {
            public string content { get; set; }
            public bool isPrimary { get; set; }

        }
    }
}
