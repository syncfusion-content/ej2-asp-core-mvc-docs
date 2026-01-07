using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IndexViewModel ViewModel { get; set; } = new IndexViewModel();

        public void OnGet()
        {
            // Initialize toolbar items
            ViewModel.Items = new List<ToolbarItemModel>
            {
                new ToolbarItemModel
                {
                    IconCss = "e-icons e-refresh",  
                    Align = "Right",                
                }
            };

            // Initialize prompt suggestions
            ViewModel.PromptSuggestionData = new string[]
            {
                "How do I prioritize my tasks?",
                "How can I improve my time management skills?"
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

                // LiteLLM settings
                var liteLlmHost = "http://localhost:4000";
                const string liteLLMApiKey = "";
                var url = $"{liteLlmHost.TrimEnd('/')}/v1/chat/completions";
                var headers = new Dictionary<string, string>
                {
                    { "Content-Type", "application/json" }
                };
                if (!string.IsNullOrEmpty(liteLLMApiKey))
                {
                    headers.Add("Authorization", $"Bearer {liteLLMApiKey}");
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
                return new JsonResult(responseText);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in LiteLLM call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }
    }

    public class IndexViewModel
    {
        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
        public string[] PromptSuggestionData { get; set; }
    }

    public class PromptRequest
    {
        public string? Prompt { get; set; }
    }

    public class ToolbarItemModel
    {
        public string? IconCss { get; set; }
        public string? Align { get; set; }  
    }
}