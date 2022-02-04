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
        public ActionResult ChangeData(FormData formData)
        {
            //Process using recieved date 
            formData.recievedDate = DateTime.Parse(formData.date);
            return Json(formData);
        }
    }
}