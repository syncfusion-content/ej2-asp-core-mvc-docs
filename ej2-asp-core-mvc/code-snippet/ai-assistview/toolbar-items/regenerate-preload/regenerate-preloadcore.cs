using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class RegeneratePreloadModel : PageModel
    {
        // Core (Razor Pages) sample action providing prompts and toolbar items
        public void OnGet()
        {
            ViewData["Prompts"] = new[]
            {
                new {
                    prompt = "What is AI?",
                    response = "<div> AI stands for Artificial Intelligence, enabling machines to mimic human intelligence for tasks such as learning, problem-solving, and decision-making.</div>",
                    regeneratedResponses = new[] {
                        "AI, or Artificial Intelligence, refers to the simulation of human intelligence in machines programmed to think and learn like humans.",
                        "Artificial Intelligence is the development of computer systems capable of performing tasks that typically require human intelligence.",
                        "AI is a branch of computer science focused on building machines that can perform tasks requiring human-like intelligence."
                    }
                }
            };

            ViewData["ToolbarItems"] = new[] {
                new { type = "Button", iconCss = "e-icons e-assist-copy", tooltip = "Copy" },
                new { type = "Button", iconCss = "e-icons e-assist-like", tooltip = "Like" },
                new { type = "Button", iconCss = "e-icons e-assist-dislike", tooltip = "Need Improvement" },
                new { type = "Button", iconCss = "e-icons e-assist-regenerate", tooltip = "Regenerate" }
            };
        }
    }
}
