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
            List<object> listdata = new List<object>();
            listdata.Add(new
            {
                text = "Asia",
                id = "01",
                category = "Continent",
                child = new List<object>() { new { text = "India", id = "1", category = "Asia",
                     child= new List<object>() {
                          new  { id= "1001", text= "Delhi", category= "India" },
                          new    {text= "Kashmir", id= "1002", category= "India"},
                          new  { text= "Goa",id= "1003", category= "India" }
                     }
                },
                 new { text = "China",id = "2",category = "Asia",
                      child = new List<object>() {
                          new { text = "Zhejiang", id = "2001", category = "China" },
                          new   {text= "Hunan",id= "2002", category= "China"},
                          new  { text= "Shandong", id= "2003",category= "China"}
                        }
                 }
             }
            });
            listdata.Add(new
            {
                text = "North America",
                id = "02",
                category = "Continent",
                child = new List<object>() { new { text = "USA", id = "3", category = "North America",
                     child= new List<object>() {
                          new    {text= "California", id= "3001", category= "USA"},
                          new  { text= "New York",id= "3002", category= "USA" },
                          new  { text= "Florida",id= "3003", category= "USA" }
                    }
                },
                 new { text = "Canada",id = "4",category = "North America",
                      child = new List<object>() {
                          new { text = "Ontario", id = "4001", category = "Canada" },
                          new   {text= "Alberta",id= "4002", category= "Canada"},
                          new  { text= "Manitoba", id= "4003",category= "Canada"}
                        }
                 }
            }
            });
            listdata.Add(new
            {
                text = "Europe",
                id = "03",
                category = "Continent",
                child = new List<object>() { new { text = "Germany", id = "5", category = "Europe",
                     child= new List<object>() {
                          new    {text= "Berlin", id= "5001", category= "Germany"},
                          new  { text= "Bavaria",id= "5002", category= "Germany" },
                          new  { text= "Hesse",id= "5003", category= "Germany" }
                    }
                },
                 new { text = "France",id = "6",category = "Europe",
                      child = new List<object>() {
                          new { text = "Paris", id = "6001", category = "France" },
                          new   {text= "Lyon",id= "6002", category= "France"},
                          new  { text= "Marseille", id= "6003",category= "France"}
                      }
                 }
              }
            });
            listdata.Add(new
            {
                text = "Australia",
                id = "04",
                category = "Continent",
                child = new List<object>() { new { text = "Australia", id = "7", category = "Australia",
                     child= new List<object>() {
                          new    {text= "Sydney", id= "7001", category= "Australia"},
                          new  { text= "Melbourne",id= "7002", category= "Australia" },
                          new  { text= "Brisbane",id= "7003", category= "Australia" }
                    }
                },
                 new { text = "New Zealand",id = "8",category = "Australia",
                      child = new List<object>() {
                          new { text = "Milford Sound", id = "8001", category = "New Zealand" },
                          new   {text= "Tongariro National Park",id= "8002", category= "New Zealand"},
                          new  { text= "Fiordland National Park", id= "8003",category= "New Zealand"}
                        }
                 },
                 }
            });

            listdata.Add(new
            {
                text = "Africa",
                id = "05",
                category = "Continent",
                child = new List<object>() { new { text = "Morocco", id = "9", category = "Africa",
                     child= new List<object>() {
                          new    {text= "Rabat", id= "9001", category= "Morocco"},
                          new  { text= "Toubkal",id= "9002", category= "Morocco" },
                          new  { text= "Todgha Gorge",id= "9003", category= "Morocco" }
                    }
                },
                 new { text = "South Africa",id = "10",category = "Africa",
                      child = new List<object>() {
                          new { text = "Cape Town", id = "10001", category = "South Africa" },
                          new   {text= "Pretoria",id= "10002", category= "South Africa"},
                          new  { text= "Bloemfontein", id= "10003",category= "South Africa"}
                       }
                 },
            }
            });
            ViewBag.dataSource = listdata;
            return View();
        }
    }
}