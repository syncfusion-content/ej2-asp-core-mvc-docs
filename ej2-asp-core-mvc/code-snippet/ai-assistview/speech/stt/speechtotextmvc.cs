using OpenAI;
using OpenAI.Chat;
using Azure;
using Azure.AI.OpenAI;

namespace AssistViewDemo.Controllers
{
    public class HomeController : Controller
    {

        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();

        public IActionResult Index()
        {
            Items.Add(new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" });
            ViewBag.Items = Items;
            return View();
        }
        public class ToolbarItemModel
        {
            public string iconCss { get; set; }
            public string align { get; set; }
        }
        [HttpPost]
        public async Task<IActionResult> GetAIResponse([FromBody] PromptRequest request)
        {
            try
            {
                _logger.LogInformation("Received request with prompt: {Prompt}", request?.Prompt);

                if (string.IsNullOrEmpty(request?.Prompt))
                {
                    _logger.LogWarning("Prompt is null or empty.");
                    return BadRequest("Prompt cannot be empty.");
                }

                // Azure OpenAI configuration
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
                return Json(responseText);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in Azure OpenAI call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }
    }
}