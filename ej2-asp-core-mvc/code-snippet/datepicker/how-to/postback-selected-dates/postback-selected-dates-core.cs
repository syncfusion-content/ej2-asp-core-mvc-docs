using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EJ2Sample.Controllers
{
    public class FormData
    {
        public String date { get; set; }
        public DateTime recievedDate { get; set; }
    }
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult ChangeData([FromBody] FormData date)
        {
            //Process using recieved date 
            date.recievedDate = DateTime.Parse(date.date);
            return Json(date);
        }
    }
}