using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;
using OpenAI;
using OpenAI.Chat;
using Syncfusion.EJ2.InteractiveChat;
using Newtonsoft.Json;

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
    var aiUser = new ChatUIUser { Id = "ai", User = "Open AI" };
    ViewBag.CurrentUser = currentUser;
    ViewBag.AIUser = aiUser;

    return View();
}

[HttpPost]
[ValidateAntiForgeryToken]
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
        string apiKey = ""; // Replace with your OpenAI API key
        var openAiClient = new OpenAIClient(apiKey);
        var chatClient = openAiClient.GetChatClient("gpt-4o-mini"); // Use your preferred model, e.g., "gpt-4o-mini" or "gpt-4o"
        OpenAI.Chat.ChatCompletion completion = await chatClient.CompleteChatAsync(request.Prompt);
        string responseText = completion.Content[0].Text;
        if (string.IsNullOrEmpty(responseText))
        {
            _logger.LogError("OpenAI API returned no text.");
            return BadRequest("No response from OpenAI.");
        }
        _logger.LogInformation("OpenAI response received: {Response}", responseText);
        return Json(responseText);
    }
    catch (Exception ex)
    {
        _logger.LogError("Exception in OpenAI call: {Message}", ex.Message);
        return BadRequest($"Error generating response: {ex.Message}");
    }
}
public class ToolbarItemModel
{
    public string align { get; set; }
    public string iconCss { get; set; }
    public string tooltip { get; set; }
}
