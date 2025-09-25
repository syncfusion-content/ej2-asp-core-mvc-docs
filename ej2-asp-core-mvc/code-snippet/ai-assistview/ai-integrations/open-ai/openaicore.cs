using OpenAI;
using Azure;
using Azure.AI.OpenAI;
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

                string endpoint = ""; // Replace with your Azure OpenAI endpoint
                string apiKey = ""; // Replace with your Azure OpenAI API key
                string deploymentName = ""; // Replace with your Azure OpenAI deployment name (e.g., gpt-4o-mini)

                var credential = new AzureKeyCredential(apiKey); 
                var client = new AzureOpenAIClient(new Uri(endpoint), credential);
                var chatClient = client.GetChatClient(deploymentName);

                var chatCompletionOptions = new ChatCompletionOptions();
                var completion = await chatClient.CompleteChatAsync(
                    new[] { new UserChatMessage(request.Prompt) },
                    chatCompletionOptions
                );
                string responseText = completion.Value.Content[0].Text;
                if (string.IsNullOrEmpty(responseText))
                {
                    _logger.LogError("Azure OpenAI API returned no text.");
                    return BadRequest("No response from Azure OpenAI.");
                }

                _logger.LogInformation("Azure OpenAI response received: {Response}", responseText);
                return new JsonResult(responseText);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in Azure OpenAI call: {Message}", ex.Message);
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
