using Mscc.GenerativeAI;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {

        public IndexViewModel ViewModel { get; set; } = new IndexViewModel();
        public void OnGet()
        {
            // actions here
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
                var model = googleAI.GenerativeModel(model: Model.Gemini25Flash); //Replace your model name here

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
        }

        public class IndexViewModel
        {
            public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();
        }

        public class PromptRequest
        {
            public string Prompt { get; set; }
        }

        public class ToolbarItemModel
        {
            public string align { get; set; }
            public string iconCss { get; set; }
        }
    }
