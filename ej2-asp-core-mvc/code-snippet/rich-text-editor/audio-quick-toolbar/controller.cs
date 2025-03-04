public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.value = @"<p><b>Get started with Quick Toolbar to click on an audio</b></p>
                    <p>Using the quick toolbar, users can replace, display, and delete the selected audio.</p>
                    <p><audio controls><source src='https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Audio.wav' type='audio/mp3' /></audio></p>";
        ViewBag.items = new[] { "Audio" };
        ViewBag.audio = new[] { "AudioReplace", "Remove", "AudioLayoutOption"};
        return View();
    }
}