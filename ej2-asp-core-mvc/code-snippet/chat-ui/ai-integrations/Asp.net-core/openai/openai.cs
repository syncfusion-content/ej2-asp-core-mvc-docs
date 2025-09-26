using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using OpenAI.Chat;
using OpenAI;
using Azure;
using Azure.AI.OpenAI;
private readonly ILogger<IndexModel> _logger;
public List<ToolbarItemModel> HeaderToolbar { get; set; } = new List<ToolbarItemModel>();

public IndexModel(ILogger<IndexModel> logger)
{
    _logger = logger;
}

public void OnGet()
{
    HeaderToolbar.Add(new ToolbarItemModel { align = "Right", type = "Button", iconCss = "e-icons e-refresh" });
    HeaderToolbar = HeaderToolbar;
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
            _logger.LogError("Azure Open AI API returned no text.");
            return BadRequest("No response from Azure Open AI.");
        }

        _logger.LogInformation("Azure Open AI response received: {Response}", responseText);
        return new JsonResult(responseText);
    }
    catch (Exception ex)
    {
        _logger.LogError("Exception in Azure Open AI call: {Message}", ex.Message);
        return BadRequest($"Error generating response: {ex.Message}");
    }
}
public class PromptRequest
{
    public string Prompt { get; set; }
}
public class ToolbarItemModel
{
    public string align { get; set; }
    public string iconCss { get; set; }
    public string type { get; set; }
}
