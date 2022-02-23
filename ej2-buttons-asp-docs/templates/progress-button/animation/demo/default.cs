using Syncfusion.EJ2.SplitButtons;

public class HomeController : Controller
{
    public ActionResult Index()
    {
            ProgressButtonSpinSettings spinSettings = new ProgressButtonSpinSettings()
            {
                Position = SpinPosition.Left
            };
            ViewBag.spinSettings = spinSettings;
            ProgressButtonAnimationSettings animationSettings = new ProgressButtonAnimationSettings()
            {
                Effect = AnimationEffect.SlideRight,
                Duration = 500,
                Easing = "linear",
            };
            ViewBag.animationSettings = animationSettings;
            return View();
    }
}
