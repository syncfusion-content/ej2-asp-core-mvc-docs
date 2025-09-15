using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mscc.GenerativeAI;  // Correct namespace for Mscc.GenerativeAI package
using System.Threading.Tasks;

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

        string apiKey = ""; // Replace with your key
        var googleAI = new GoogleAI(apiKey: apiKey);
        var model = googleAI.GenerativeModel(model: Model.Gemini15Flash);

        var response = await model.GenerateContent(request.Prompt);

        if (string.IsNullOrEmpty(response?.Text))
        {
            _logger.LogError("Gemini API returned no text.");
            return BadRequest("No response from Gemini.");
        }

        _logger.LogInformation("Gemini response received: {Response}", response.Text);
        return new JsonResult(response.Text);
    }
    catch (Exception ex)
    {
        _logger.LogError("Exception in Gemini call: {Message}", ex.Message);
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
