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
            ViewModel.Items = new List<ToolbarItemModel>
            {
                new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" }
            };

            ViewModel.ResponseItems = new List<ToolbarItemModel>
            {
                new ToolbarItemModel { iconCss = "e-icons e-assist-copy", tooltip = "Copy" },
                new ToolbarItemModel { iconCss = "e-icons e-audio", tooltip = "Read Aloud" },
                new ToolbarItemModel { iconCss = "e-icons e-assist-like", tooltip = "Like" },
                new ToolbarItemModel { iconCss = "e-icons e-assist-dislike", tooltip = "Need Improvement" }
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

                string endpoint = "Your_Azure_OpenAI_Endpoint"; // Replace with your Azure OpenAI endpoint
                string apiKey = "YOUR_AZURE_OPENAI_API_KEY"; // Replace with your Azure OpenAI API key
                string deploymentName = "YOUR_DEPLOYMENT_NAME"; // Replace with your Azure OpenAI deployment name (e.g., gpt-4o-mini)

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
        public List<ToolbarItemModel> ResponseItems { get; set; } = new List<ToolbarItemModel>();
    }

    public class PromptRequest
    {
        public string Prompt { get; set; }
    }

    public class ToolbarItemModel
    {
        public string align { get; set; }
        public string iconCss { get; set; }
        public string tooltip { get; set; }
    }
}
