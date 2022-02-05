public class HomeController : Controller
{

    public ActionResult Index()
    {
        ViewBag.data = new Color().Colors();
        return View();
    }
    public class Color
    {
        public string Value { get; set; }
        public string Id { get; set; }
        public List<Color> Colors()
        {
            List<Color> color = new List<Color>();
            position.Add(new Color { Id = "red", Value = "Red" });
            position.Add(new Color { Id = "cyan", Value = "Cyan" });
            position.Add(new Color { Id = "blue", Value = "Blue" });
            position.Add(new Color { Id = "yellow", Value = "Yellow" });
            position.Add(new Color { Id = "pink", Value = "Pink" });
            return color;
        }
    }
}