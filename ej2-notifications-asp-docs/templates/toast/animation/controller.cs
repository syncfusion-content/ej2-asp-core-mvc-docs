public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.data = new Animation().Animations();
        return View();
    }
    public class Animation
    {
        public string Value { get; set; }
        public string Id { get; set; }
        public List<Animation> Animations()
        {
            List<Animation> animation = new List<Animation>
                {
                    new Animation { Id = "FadeIn", Value = "Fade In" },
                    new Animation { Id = "FadeZoomIn", Value = "Fade Zoom In" },
                    new Animation { Id = "FadeZoomOut", Value = "Fade Zoom Out" },
                    new Animation { Id = "FlipLeftDownIn", Value = "Flip Left Down In" },
                    new Animation { Id = "FlipLeftDownOut", Value = "Flip Left Down Out" },
                    new Animation { Id = "FlipLeftUpIn", Value = "Flip Left Up In" },
                    new Animation { Id = "FlipLeftUpOut", Value = "Flip Left Up Out" },
                    new Animation { Id = "FlipRightDownIn", Value = "Flip Right Down In" },
                    new Animation { Id = "FlipRightUpIn", Value = "Flip Right Up In" },
                    new Animation { Id = "FlipRightUpOut", Value = "Flip Right Up Out" },
                    new Animation { Id = "SlideBottomIn", Value = "Slide Bottom In" },
                    new Animation { Id = "SlideBottomOut", Value = "Slide Bottom Out" },
                    new Animation { Id = "SlideLeftIn", Value = "Slide Left In" },
                    new Animation { Id = "SlideLeftOut", Value = "Slide Left Out" },
                    new Animation { Id = "SlideRightIn", Value = "Slide Right In" },
                    new Animation { Id = "SlideRightOut", Value = "Slide Right Out" },
                    new Animation { Id = "SlideTopIn", Value = "Slide Top In" },
                    new Animation { Id = "SlideTopOut", Value = "Slide Top Out" },
                    new Animation { Id = "ZoomIn", Value = "Zoom In" },
                    new Animation { Id = "ZoomOut", Value = "Zoom Out" }
                };
            return animation;
        }
    }
}