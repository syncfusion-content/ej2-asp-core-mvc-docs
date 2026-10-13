using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.StockChart
{
    public partial class StockChartController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }
    }
}