public ActionResult Index()
{
    List<Chart3DData> chartData = new List<Chart3DData>
    {
        new Chart3DData { month = new DateTime(2024, 01, 01), sales = 35 },
        new Chart3DData { month = new DateTime(2024, 02, 01), sales = 28 },
        new Chart3DData { month = new DateTime(2024, 03, 01), sales = 34 },
        new Chart3DData { month = new DateTime(2024, 04, 01), sales = 32 },
        new Chart3DData { month = new DateTime(2024, 05, 01), sales = 40 },
        new Chart3DData { month = new DateTime(2024, 06, 01), sales = 32 },
        new Chart3DData { month = new DateTime(2024, 07, 01), sales = 35 },
        new Chart3DData { month = new DateTime(2024, 08, 01), sales = 55 },
        new Chart3DData { month = new DateTime(2024, 09, 01), sales = 38 },
        new Chart3DData { month = new DateTime(2024, 10, 01), sales = 30 },
        new Chart3DData { month = new DateTime(2024, 11, 01), sales = 25 },
        new Chart3DData { month = new DateTime(2024, 12, 01), sales = 32 }
    };

    ViewBag.dataSource = chartData;
    return View();
}

public class Chart3DData
{
    public DateTime month;
    public double sales;
}