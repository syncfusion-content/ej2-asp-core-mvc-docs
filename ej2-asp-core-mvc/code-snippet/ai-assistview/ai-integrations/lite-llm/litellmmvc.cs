using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using System.Diagnostics;

namespace SyncfusionWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var items = new List<ToolbarItemModel>
            {
                new ToolbarItemModel { IconCss = "e-icons e-refresh", Align = "Right" }
            };
            ViewBag.Items = items;
            var promptSuggestionData = new string[]
            {
                "How do I prioritize my tasks?",
                "How can I improve my time management skills?"
            };
            ViewBag.PromptSuggestionData = promptSuggestionData;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Define ErrorViewModel inline for self-containment (or create Models/ErrorViewModel.cs separately)
            var errorViewModel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(errorViewModel);
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

                // LiteLLM settings
                var liteLlmHost = "http://localhost:4000";
                const string liteLlmApiKey = "";

                var url = $"{liteLlmHost.TrimEnd('/')}/v1/chat/completions";
                var headers = new Dictionary<string, string>
                {
                    { "Content-Type", "application/json" }
                };
                if (!string.IsNullOrEmpty(liteLlmApiKey))
                {
                    headers.Add("Authorization", $"Bearer {liteLlmApiKey}");
                }

                var requestBody = new
                {
                    model = "openai/gpt-4o-mini", // Must match model_name in config.yaml
                    messages = new[] { new { role = "user", content = request.Prompt } },
                    temperature = 0.7,
                    max_tokens = 300,
                    stream = false
                };

                using var httpClient = new HttpClient();
                foreach (var header in headers)
                {
                    httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                }

                var json = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, content);
                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError("LiteLLM API returned status: {StatusCode}", response.StatusCode);
                    return BadRequest($"No response from LiteLLM: {response.StatusCode}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                using var document = JsonDocument.Parse(responseContent);
                var responseText = document.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString()?.Trim() ?? "No response received.";

                if (string.IsNullOrEmpty(responseText))
                {
                    _logger.LogError("LiteLLM API returned no text.");
                    return BadRequest("No response from LiteLLM.");
                }

                _logger.LogInformation("LiteLLM response received: {Response}", responseText);
                return Json(responseText);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in LiteLLM call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }
    }

    public class ToolbarItemModel
    {
        public string? IconCss { get; set; }  
        public string? Align { get; set; }    
    }

    public class PromptRequest
    {
        public string? Prompt { get; set; } 
    }
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
    }
}