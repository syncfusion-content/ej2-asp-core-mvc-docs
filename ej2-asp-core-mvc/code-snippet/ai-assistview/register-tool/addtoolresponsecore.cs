namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public IndexViewModel ViewModel { get; set; } = new IndexViewModel();

        public void OnGet()
        {
            ViewModel.Items = new List<ToolbarItemModel>
            {
                new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" }
            };
            ViewModel.PromptSuggestions = new string[]
            {
                "Suggest a healthy breakfast recipe under 5 ingredients",
                "What is the weather in New York?"
            };
        }
    }

    public class IndexViewModel
    {
        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
        public string[] PromptSuggestions { get; set; }
    }

    public class ToolbarItemModel
    {
        public string align { get; set; }
        public string iconCss { get; set; }
    }
}
