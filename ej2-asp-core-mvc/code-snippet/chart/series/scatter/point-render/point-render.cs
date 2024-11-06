public ActionResult Index()
{
    List<AxisLabelData> chartData = new List<AxisLabelData>
    {
        new AxisLabelData { x = 1, y = 15 },
        new AxisLabelData { x = 2, y = 25 },
        new AxisLabelData { x = 3, y = 35 },
        new AxisLabelData { x = 4, y = 40 },
        new AxisLabelData { x = 5, y = 55 },
        new AxisLabelData { x = 6, y = 60 },
        new AxisLabelData { x = 7, y = 65 },
        new AxisLabelData { x = 8, y = 70 },
        new AxisLabelData { x = 9, y = 75 },
        new AxisLabelData { x = 10, y = 80 },
        new AxisLabelData { x = 11, y = 85 },
        new AxisLabelData { x = 12, y = 90 },
        new AxisLabelData { x = 13, y = 92 },
        new AxisLabelData { x = 14, y = 94 },
        new AxisLabelData { x = 15, y = 96 },
        new AxisLabelData { x = 16, y = 30 },
        new AxisLabelData { x = 17, y = 98 },
        new AxisLabelData { x = 18, y = 99 },
        new AxisLabelData { x = 19, y = 100 },
        new AxisLabelData { x = 20, y = 100 }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class AxisLabelData
{
    public double x;
    public double? y;
}