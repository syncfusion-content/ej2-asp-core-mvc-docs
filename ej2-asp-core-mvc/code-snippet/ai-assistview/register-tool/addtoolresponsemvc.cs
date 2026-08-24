namespace AssistViewDemo.Controllers
{
    public class HomeController : Controller
    {
        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();

        public IActionResult Index()
        {
            Items.Add(new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" });
            ViewBag.Items = Items;
            ViewBag.PromptSuggestions = new string[]
            {
                "Suggest a healthy breakfast recipe under 5 ingredients",
                "What is the weather in New York?"
            };
            return View();
        }

        public class ToolbarItemModel
        {
            public string iconCss { get; set; }
            public string align { get; set; }
        }
    }
}
