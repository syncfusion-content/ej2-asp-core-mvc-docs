using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;
using OpenAI;
using OpenAI.Chat;
using Syncfusion.EJ2.InteractiveChat;
using Newtonsoft.Json;
using Azure.AI.OpenAI;
using Azure;
private readonly ILogger<HomeController> _logger;
public List<ToolbarItemModel> HeaderToolbar { get; set; } = new List<ToolbarItemModel>();
public HomeController(ILogger<HomeController> logger)
{
    _logger = logger;
}

public IActionResult Index()
{
    HeaderToolbar.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh", tooltip = "Refresh" });
    ViewBag.HeaderToolbar = HeaderToolbar;
    var currentUser = new ChatUIUser { Id = "user1", User = "You" };
    var aiUser = new ChatUIUser { Id = "ai", User = "Azure Open AI" };
    ViewBag.CurrentUser = currentUser;
    ViewBag.AIUser = aiUser;

    return View();
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
            return BadRequest("No response from Azure Open AI.");
        }
        _logger.LogInformation("Azure OpenAI response received: {Response}", responseText);
        return Json(responseText);
    }
    catch (Exception ex)
    {
        _logger.LogError("Exception in Azure Open AI call: {Message}", ex.Message);
        return BadRequest($"Error generating response: {ex.Message}");
    }
}
public class ToolbarItemModel
{
    public string align { get; set; }
    public string iconCss { get; set; }
    public string tooltip { get; set; }
}
