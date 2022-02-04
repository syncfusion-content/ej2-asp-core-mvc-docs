public class HomeController : Controller
{
   public class Cultures
    {
        public string CultureName { get; set; }
    }
    public IActionResult Index()
        {
            List<Cultures> cultureData = new List<Cultures>();
            cultureData.Add(new Cultures() { CultureName = "de" });
            cultureData.Add(new Cultures() { CultureName = "zh" });
            cultureData.Add(new Cultures() { CultureName = "en" });
            ViewBag.cultureData = cultureData;
             return View();
        }

}