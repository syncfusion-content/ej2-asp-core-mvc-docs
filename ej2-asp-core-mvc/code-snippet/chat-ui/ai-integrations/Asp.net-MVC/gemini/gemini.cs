using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;
using Mscc.GenerativeAI;
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
    var aiUser = new ChatUIUser { Id = "ai", User = "Gemini" };
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
        string apiKey = ""; // Replace with your key
        var googleAI = new GoogleAI(apiKey: apiKey);
        var model = googleAI.GenerativeModel(model: Model.Gemini15Flash);

        var responseText = await model.GenerateContent(request.Prompt);
        if (string.IsNullOrEmpty(responseText?.Text))
        {
            _logger.LogError("Gemini AI API returned no text.");
            return BadRequest("No response from Gemini AI.");
        }
        _logger.LogInformation("Gemini AI response received: {Response}", responseText.Text);
        return Json(responseText.Text);
    }
    catch (Exception ex)
    {
        _logger.LogError("Exception in Gemini AI call: {Message}", ex.Message);
        return BadRequest($"Error generating response: {ex.Message}");
    }
}
public class ToolbarItemModel
{
    public string align { get; set; }
    public string iconCss { get; set; }
    public string tooltip { get; set; }
}
