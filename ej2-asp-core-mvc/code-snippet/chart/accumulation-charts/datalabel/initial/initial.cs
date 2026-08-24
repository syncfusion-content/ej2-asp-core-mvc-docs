public ActionResult Index()
{
    List<PieChartData> chartData = new List<PieChartData>
    {
        new PieChartData { xValue = "Chrome", yValue = 15, text = "15", fill = "#00BDAE" },
        new PieChartData { xValue = "UC Browser", yValue = 22, text = "22", fill = "#404041" },
        new PieChartData { xValue = "iPhone", yValue = 32, text = "32", fill = "#357CD2" },
        new PieChartData { xValue = "Safari", yValue = 31, text = "31", fill = "#E56590" },
        new PieChartData { xValue = "Firefox", yValue = 29, text = "29", fill = "#F8B883" },
        new PieChartData { xValue = "Edge", yValue = 24, text = "24", fill = "#70AD47" },
        new PieChartData { xValue = "Others", yValue = 18, text = "18", fill = "#D77FB3" }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class PieChartData
{
    public string xValue;
    public double yValue;
    public string text;
    public string fill;
}