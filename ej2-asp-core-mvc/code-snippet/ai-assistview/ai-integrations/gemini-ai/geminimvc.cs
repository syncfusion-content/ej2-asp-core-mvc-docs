using Mscc.GenerativeAI;

namespace AssistViewDemo.Controllers
{
    public class HomeController : Controller
    {

        public List<ToolbarItemModel> Items { get; set; } = new List<ToolbarItemModel>();

        public IActionResult Index()
        {
            Items.Add(new ToolbarItemModel { iconCss = "e-icons e-refresh", align = "Right" });
            ViewBag.Items = Items;
            var PromptSuggestionData = new string[]
            {
                "What are the best tools for organizing my tasks?",
                "How can I maintain work-life balance effectively?"
            };
            ViewBag.PromptSuggestionData = PromptSuggestionData;
            return View();
        }

        public class ToolbarItemModel
        {
            public string iconCss { get; set; }
            public string align { get; set; }
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

                string apiKey = ""; // Replace with your key
                var googleAI = new GoogleAI(apiKey: apiKey);
                var model = googleAI.GenerativeModel(model: Model.Gemini25Flash); //Replace your model name here

                var responseText = await model.GenerateContent(request.Prompt);

                if (string.IsNullOrEmpty(responseText?.Text))
                {
                    _logger.LogError("Gemini API returned no text.");
                    return BadRequest("No response from Gemini.");
                }

                _logger.LogInformation("Gemini response received: {Response}", responseText?.Text);
                return Json(responseText?.Text);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in Gemini call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }
    }
}