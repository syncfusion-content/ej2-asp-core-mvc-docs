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
                var model = googleAI.GenerativeModel(model: Model.Gemini15Flash);

                var responseText = await model.GenerateContent(request.Prompt);

                if (string.IsNullOrEmpty(responseText?.Text))
                {
                    _logger.LogError("OpenAI API returned no text.");
                    return BadRequest("No response from OpenAI.");
                }

                _logger.LogInformation("OpenAI response received: {Response}", responseText?.Text);
                return Json(responseText?.Text);
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in OpenAI call: {Message}", ex.Message);
                return BadRequest($"Error generating response: {ex.Message}");
            }
        }
    }
}