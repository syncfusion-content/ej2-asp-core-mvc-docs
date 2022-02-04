using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AutoCompleteController : Controller
    {
         public ActionResult Index()
        {
            DataModel model = new DataModel();
            model.EnquiringAboutSelectListItems = new ListItems().getListItems();
            model.EnquiringAboutSelect = "104";
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(DataModel model)
        {
            model.EnquiringAboutSelectListItems = new ListItems().getListItems();
            model.EnquiringAboutSelect = model.EnquiringAboutSelect;
            return View(model);
        }
    }
    public class DataModel
    {
        [Required(ErrorMessage = "The value is Required")]
        public string EnquiringAboutSelect { get; set; }
        public List<ListItems> EnquiringAboutSelectListItems { get; set; }

    }

    public class ListItems
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public List<ListItems> getListItems()
        {
            List<ListItems> items = new List<ListItems>();
            items.Add(new ListItems() { Text = "Aberdeen", Value = "103" });
            items.Add(new ListItems() { Text = "Alexandria", Value = "102" });
            items.Add(new ListItems() { Text = "Albany", Value = "101" });
            items.Add(new ListItems() { Text = "Beacon ", Value = "104" });
            items.Add(new ListItems() { Text = "Brisbane ", Value = "105" });
            return items;
        }
    }
}