public ActionResult Index()
{
    List<AxisLabelData> chartData = new List<AxisLabelData>
        {
            new AxisLabelData { month = "Jan", sales = 35 },
            new AxisLabelData { month = "Feb", sales = 28 },
            new AxisLabelData { month = "Mar", sales = 34 },
            new AxisLabelData { month = "Apr", sales = null },
            new AxisLabelData { month = "May", sales = 40 },
            new AxisLabelData { month = "Jun", sales = 32 },
            new AxisLabelData { month = "Jul", sales = 35 },
            new AxisLabelData { month = "Aug" },
            new AxisLabelData { month = "Sep", sales = 38 },
            new AxisLabelData { month = "Oct", sales = 30 },
            new AxisLabelData { month = "Nov", sales = 25 },
            new AxisLabelData { month = "Dec", sales = 32 },
        };
        ViewBag.dataSource = chartData;
        ChartEmptyPointSettings chartEmptyPointSettings = new ChartEmptyPointSettings();
        chartEmptyPointSettings.Mode = EmptyPointMode.Zero;
        chartEmptyPointSettings.Fill = "red";
        chartEmptyPointSettings.Border.Width = 2;
        chartEmptyPointSettings.Border.Color = "green";
        ViewBag.emptyPoint = chartEmptyPointSettings;
        ChartMarkerSettings marker = new ChartMarkerSettings();
        marker.Visible = true;
        marker.Width = 7;
        marker.Height = 7;
        marker.IsFilled = true;
        ViewBag.marker = marker;
        return View();
}


public class AxisLabelData
{
    public string month;
    public double? sales;
}