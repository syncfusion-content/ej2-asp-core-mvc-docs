using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; 
using System.Threading.Tasks;
using OpenAI.Chat;
using OpenAI;
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

        string apiKey = ""; // Replace with your OpenAI API key
        var openAiClient = new OpenAIClient(apiKey);
        var chatClient = openAiClient.GetChatClient("gpt-4o-mini"); // Use your preferred model, e.g., "gpt-4o-mini" or "gpt-4o"

        ChatCompletion completion = await chatClient.CompleteChatAsync(request.Prompt);
        string response = completion.Content[0].Text;

        if (string.IsNullOrEmpty(response))
        {
            _logger.LogError("Open AI API returned no text.");
            return BadRequest("No response from Open AI.");
        }

        _logger.LogInformation("Open AI response received: {Response}", response);
        return new JsonResult(response);
    }
    catch (Exception ex)
    {
        _logger.LogError("Exception in Open AI call: {Message}", ex.Message);
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
