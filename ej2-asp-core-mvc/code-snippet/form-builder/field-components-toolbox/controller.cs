using System.Web.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.toolboxItemCategories = GetToolboxCategories();
        return View();
    }
    public List<ToolboxCategories> GetToolboxCategories()
    {
        return new List<ToolboxCategories>
        {
            new ToolboxCategories()
            {
                Category = "basic",
                Items = new[] { "textbox", "textarea" }
            },
            new ToolboxCategories()
            {
                Category = "advanced",
                Items = new[] { "date", "dateRange" }
            },
            new ToolboxCategories()
            {
                Category = "layout",
                Items = new[] { "panel", "card" }
            }
        };
    }
}
public class ToolboxCategories
{
    [JsonProperty("category")] public string Category { get; set; }
    [JsonProperty("items")] public string[] Items { get; set; }
}