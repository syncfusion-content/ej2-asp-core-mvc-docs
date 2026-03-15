public ActionResult SeriesLabelCustomization()
{
    List<ChartData> vietnamData = new List<ChartData>
    {
        new ChartData { x = 2016, y = 7.8 },
        new ChartData { x = 2017, y = 10.3 },
        new ChartData { x = 2018, y = 15.5 },
        new ChartData { x = 2019, y = 17.5 },
        new ChartData { x = 2020, y = 19.5 },
        new ChartData { x = 2021, y = 23.0 },
        new ChartData { x = 2022, y = 20.0 },
        new ChartData { x = 2023, y = 19.0 },
        new ChartData { x = 2024, y = 22.1 }
    };

    List<ChartData> indonesiaData = new List<ChartData>
    {
        new ChartData { x = 2016, y = 4.8 },
        new ChartData { x = 2017, y = 5.2 },
        new ChartData { x = 2018, y = 6.2 },
        new ChartData { x = 2019, y = 7.8 },
        new ChartData { x = 2020, y = 9.3 },
        new ChartData { x = 2021, y = 14.3 },
        new ChartData { x = 2022, y = 15.6 },
        new ChartData { x = 2023, y = 16.0 },
        new ChartData { x = 2024, y = 17.0 }
    };

    // same for other series

    ViewBag.vietnamData = vietnamData;
    ViewBag.indonesiaData = indonesiaData;

    return View();
}

public class ChartData
{
    public double x;
    public double y;
}