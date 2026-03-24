public IActionResult CrosshairLabelRender()
{
    List<ChartData> chartData = new List<ChartData>
    {
        new ChartData { x = "January", y = 1200 },
        new ChartData { x = "February", y = 900 },
        new ChartData { x = "March", y = 1500 },
        new ChartData { x = "April", y = 700 },
        new ChartData { x = "May", y = 2000 },
        new ChartData { x = "June", y = 300 }
    };

    ViewBag.dataSource = chartData;

    return View();
}

public class ChartData
{
    public string x;
    public double y;
}