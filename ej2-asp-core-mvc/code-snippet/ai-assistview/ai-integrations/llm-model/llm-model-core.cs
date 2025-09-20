using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssistViewDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChatClient _chatClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IChatClient chatClient, ILogger<HomeController> logger)
        {
            _chatClient = chatClient;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            // Initialize toolbar items
            viewModel.Items = new List<ToolbarItemModel>
            {
                new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" }
            };
            // Initialize prompt suggestions
            viewModel.PromptSuggestionData = new string[]
            {
                "What are the best tools for organizing my tasks?",
                "How can I maintain work-life balance effectively?"
            };
            return View(viewModel);
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

                // Use Ollama via IChatClient (from Program.cs)
                var chatCompletion = await _chatClient.CompleteAsync(request.Prompt);
                var responseText = chatCompletion.Message.Contents.FirstOrDefault()?.ToString();

                if (string.IsNullOrEmpty(responseText))
                {
                    _logger.LogError("Ollama API returned no text.");
                    return BadRequest("No response from Ollama.");
                }

                _logger.LogInformation("Ollama response received: {Response}", responseText);
                return Json(responseText);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in Ollama call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }

    public class IndexViewModel
    {
        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
        public string[] PromptSuggestionData { get; set; }
    }

    public class PromptRequest
    {
        [JsonPropertyName("prompt")]
        public string Prompt { get; set; }
    }

    public class ToolbarItemModel
    {
        public string align { get; set; }
        public string iconCss { get; set; }
    }
}