public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.value = @" <p>Rich Text Editor allows inserting video and audio from online sources and the local computers where you want to insert a video and audio into your content.</p>
            <p><b>Get started with Quick Toolbar to click on a video</b></p>
            <p>Using the quick toolbar, users can replace, align, display, dimension, and delete the selected video.</p>
            <p>
                <video controls>
                    <source src='https://cdn.syncfusion.com/ej2/richtexteditor-resources/RTE-Ocean-Waves.mp4'
                           style='width: 30%;' type='video/mp4' />
                </video>
            </p>";
        ViewBag.items = new[] { "Video" };
        ViewBag.video = new[] { "VideoReplace", "VideoAlign", "VideoRemove", "VideoLayoutOption", "VideoDimension"};
        return View();
    }
}