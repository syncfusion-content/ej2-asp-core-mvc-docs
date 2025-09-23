using OpenAI;

namespace WebApplication4.Pages
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

            // Initialize prompt suggestions
            ViewModel.PromptSuggestionData = new string[]
            {
                "What are the best tools for organizing my tasks?",
                "How can I maintain work-life balance effectively?"
            };
        }

        public async Task<IActionResult> OnPostGetAIResponse([FromBody] PromptRequest request)
        {
            try
            {
                _logger.LogInformation("Received request with prompt: {Prompt}", request?.Prompt);

                if (string.IsNullOrEmpty(request?.Prompt))
                {
                    _logger.LogWarning("Prompt is null or empty.");
                    return BadRequest("Prompt cannot be empty.");
                }

                string apiKey = ""; // Replace with your OpenAI API key
                var openAiClient = new OpenAIClient(apiKey);
                var chatClient = openAiClient.GetChatClient("gpt-4o-mini"); // Use your preferred model, e.g., "gpt-4o-mini" or "gpt-4o"

                ChatCompletion completion = await chatClient.CompleteChatAsync(request.Prompt);
                string responseText = completion.Content[0].Text;

                if (string.IsNullOrEmpty(responseText))
                {
                    _logger.LogError("OpenAI API returned no text.");
                    return BadRequest("No response from OpenAI.");
                }

                _logger.LogInformation("OpenAI response received: {Response}", responseText);
                return new JsonResult(responseText);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in Gemini call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }
        }

        public class IndexViewModel
        {
            public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
            public string[] PromptSuggestionData { get; set; }
        }

        public class PromptRequest
        {
            public string Prompt { get; set; }
        }

        public class ToolbarItemModel
        {
            public string align { get; set; }
            public string iconCss { get; set; }
        }
    }
}