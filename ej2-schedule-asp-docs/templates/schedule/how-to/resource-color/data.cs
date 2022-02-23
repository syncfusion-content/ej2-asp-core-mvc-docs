using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public partial class ScheduleController : Controller
    {
        public ActionResult resource-color()
        {
            ViewBag.datasource = new ScheduleData().GetResourceTeamData();

            List<ProjectResource> projects = new List<ProjectResource>();
            projects.Add(new ProjectResource { text = "PROJECT 1", id = 1, color = "#cb6bb2" });
            projects.Add(new ProjectResource { text = "PROJECT 2", id = 2, color = "#56ca85" });
            ViewBag.Projects = projects;

            List<CategoryResource> categories = new List<CategoryResource>();
            categories.Add(new CategoryResource { text = "Development", id = 1, color = "#1aaa55" });
            categories.Add(new CategoryResource { text = "Testing", id = 2, color = "#7fa900" });
            ViewBag.Categories = categories;

            ViewBag.Resources = new string[] { "Projects", "Categories" };
            return View();
        }
    }
    public class ProjectResource
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
    }
    public class CategoryResource
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
    }
}