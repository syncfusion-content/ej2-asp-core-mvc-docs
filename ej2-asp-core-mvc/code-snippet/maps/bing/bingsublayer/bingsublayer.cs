using Newtonsoft.Json;
using Syncfusion.EJ2.Charts;

namespace EJ2_Core_Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.africa = GetAfricaMap();
            ViewBag.africaShape = GetAfricaShape();
            return View();
        }

        public object GetAfricaShape()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Africa.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }

        public object GetAfricaMap()
        {
            string text = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/Africa.json");
            return JsonConvert.DeserializeObject(text);
        }
    }
}