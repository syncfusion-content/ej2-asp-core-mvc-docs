using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RTE.Pages
{
    public class IndexModel : PageModel // Imported respective page model
    {
        public string Value { get; set; } // value declaration

        public void OnGet()
        {
            this.Value = "<p> Sample text content </p>"; //value Initialization
        }

        public void OnPost()
        {
            var comments = Request.Form["comment"];  //Triggers form action
        }
    }
}
