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
                text = "Asia",
                id = "01",
                category = "Continent",
                child = new List<object>() { new { text = "India", id = "1", category = "Asia",
                     child= new List<object>() {
                          new  { id= "1001", text= "Delhi", category= "India",htmlAttributes= new { @class= "e-file e-checkbox-hidden" } },
                          new    {text= "Kashmir", id= "1002", category= "India",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "Goa",id= "1003", category= "India",htmlAttributes= new { @class= "e-file" } }
                     }
                },
                 new { text = "China",id = "2",category = "Asia",
                      child = new List<object>() {
                          new { text = "Zhejiang", id = "2001", category = "China",htmlAttributes= new { @class= "e-file" } },
                          new   {text= "Hunan",id= "2002", category= "China",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "Shandong", id= "2003",category= "China",htmlAttributes= new { @class= "e-file" }}
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
                          new    {text= "California", id= "3001", category= "USA",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "New York",id= "3002", category= "USA",htmlAttributes= new { @class= "e-file e-checkbox-hidden" } },
                          new  { text= "Florida",id= "3003", category= "USA" ,htmlAttributes= new { @class= "e-file" }}
                    }
                },
                 new { text = "Canada",id = "4",category = "North America",
                      child = new List<object>() {
                          new { text = "Ontario", id = "4001", category = "Canada",htmlAttributes= new { @class= "e-file e-checkbox-hidden" } },
                          new   {text= "Alberta",id= "4002", category= "Canada",htmlAttributes= new { @class= "e-file" }},
                          new  { text= "Manitoba", id= "4003",category= "Canada",htmlAttributes= new { @class= "e-file" }}
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
                          new    {text= "Berlin", id= "5001", category= "Germany",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "Bavaria",id= "5002", category= "Germany",htmlAttributes= new { @class= "e-file" } },
                          new  { text= "Hesse",id= "5003", category= "Germany" ,htmlAttributes= new { @class= "e-file e-checkbox-hidden" }}
                    }
                },
                 new { text = "France",id = "6",category = "Europe",
                      child = new List<object>() {
                          new { text = "Paris", id = "6001", category = "France" ,htmlAttributes= new { @class= "e-file" }},
                          new   {text= "Lyon",id= "6002", category= "France",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "Marseille", id= "6003",category= "France",htmlAttributes= new { @class= "e-file" }}
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
                          new    {text= "Sydney", id= "7001", category= "Australia",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "Melbourne",id= "7002", category= "Australia" ,htmlAttributes= new { @class= "e-file" }},
                          new  { text= "Brisbane",id= "7003", category= "Australia" ,htmlAttributes= new { @class= "e-file" }}
                    }
                },
                 new { text = "New Zealand",id = "8",category = "Australia",
                      child = new List<object>() {
                          new { text = "Milford Sound", id = "8001", category = "New Zealand",htmlAttributes= new { @class= "e-file" } },
                          new   {text= "Tongariro National Park",id= "8002", category= "New Zealand",htmlAttributes= new { @class= "e-file" }},
                          new  { text= "Fiordland National Park", id= "8003",category= "New Zealand",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }}
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
                          new    {text= "Rabat", id= "9001", category= "Morocco",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "Toubkal",id= "9002", category= "Morocco",htmlAttributes= new { @class= "e-file" } },
                          new  { text= "Todgha Gorge",id= "9003", category= "Morocco" ,htmlAttributes= new { @class= "e-file e-checkbox-hidden" }}
                    }
                },
                 new { text = "South Africa",id = "10",category = "Africa",
                      child = new List<object>() {
                          new { text = "Cape Town", id = "10001", category = "South Africa" ,htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new   {text= "Pretoria",id= "10002", category= "South Africa",htmlAttributes= new { @class= "e-file e-checkbox-hidden" }},
                          new  { text= "Bloemfontein", id= "10003",category= "South Africa",htmlAttributes= new { @class= "e-file" }}
                       }
                 },
            }
            });
            ViewBag.dataSource = listdata;
            return View();
        }       
    }
}