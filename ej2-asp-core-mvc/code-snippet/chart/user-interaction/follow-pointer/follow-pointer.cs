public IActionResult FollowPointer()
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

    List<ChartData> franceData = new List<ChartData>
    {
        new ChartData { x = 2016, y = 14.6 },
        new ChartData { x = 2017, y = 15.5 },
        new ChartData { x = 2018, y = 15.4 },
        new ChartData { x = 2019, y = 14.4 },
        new ChartData { x = 2020, y = 11.6 },
        new ChartData { x = 2021, y = 13.9 },
        new ChartData { x = 2022, y = 12.1 },
        new ChartData { x = 2023, y = 10.0 },
        new ChartData { x = 2024, y = 10.8 }
    };

    List<ChartData> mexicoData = new List<ChartData>
    {
        new ChartData { x = 2016, y = 19.0 },
        new ChartData { x = 2017, y = 20.0 },
        new ChartData { x = 2018, y = 20.2 },
        new ChartData { x = 2019, y = 18.4 },
        new ChartData { x = 2020, y = 16.8 },
        new ChartData { x = 2021, y = 18.5 },
        new ChartData { x = 2022, y = 18.4 },
        new ChartData { x = 2023, y = 16.3 },
        new ChartData { x = 2024, y = 13.7 }
    };

    ViewBag.vietnamData = vietnamData;
    ViewBag.franceData = franceData;
    ViewBag.mexicoData = mexicoData;

    return View();
}

public class ChartData
{
    public double x;
    public double y;
}