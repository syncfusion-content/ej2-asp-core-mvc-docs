using Azure;
using Azure.AI.OpenAI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenAI.Chat;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {

        public IndexViewModel ViewModel { get; set; } = new IndexViewModel();
        public void OnGet()
        {
            // Initialize toolbar items
            ViewModel.Items = new List<ToolbarItemModel>
            {
                new ToolbarItemModel
                {
                    iconCss = "e-icons e-refresh",
                    align = "Right",
                }
            };
        }
    }

    public class IndexViewModel
    {
        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
    }

    public class ToolbarItemModel
    {
        public string align { get; set; }
        public string iconCss { get; set; }
    }
}
