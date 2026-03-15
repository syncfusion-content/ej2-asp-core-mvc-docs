public ActionResult Index()
{
    List<PriceData> chartData = new List<PriceData>
    {
        new PriceData { Date = new DateTime(2025, 1,  1), Open = 103.9, High = 106.8, Low = 102.5, Close = 105.6, Volume = 182540000 },
        new PriceData { Date = new DateTime(2025, 2,  1), Open = 105.2, High = 108.1, Low = 103.4, Close = 106.9, Volume = 176310000 },
        new PriceData { Date = new DateTime(2025, 3,  1), Open = 106.7, High = 110.6, Low = 105.1, Close = 108.7, Volume = 189250000 },
        new PriceData { Date = new DateTime(2025, 4,  1), Open = 108.9, High = 110.9, Low = 106.8, Close = 107.6, Volume = 171900000 },
        new PriceData { Date = new DateTime(2025, 5,  1), Open = 107.8, High = 112.3, Low = 106.9, Close = 111.4, Volume = 196700000 },
        new PriceData { Date = new DateTime(2025, 6,  1), Open = 111.2, High = 114.9, Low = 110.0, Close = 113.6, Volume = 205600000 },
        new PriceData { Date = new DateTime(2025, 7,  1), Open = 113.5, High = 117.3, Low = 112.2, Close = 116.0, Volume = 213400000 },
        new PriceData { Date = new DateTime(2025, 8,  1), Open = 116.1, High = 119.2, Low = 114.6, Close = 118.1, Volume = 221900000 },
        new PriceData { Date = new DateTime(2025, 9,  1), Open = 117.9, High = 120.7, Low = 116.0, Close = 116.8, Volume = 198300000 },
        new PriceData { Date = new DateTime(2025, 10, 1), Open = 116.7, High = 121.6, Low = 116.1, Close = 119.9, Volume = 234600000 },
        new PriceData { Date = new DateTime(2025, 11, 1), Open = 120.2, High = 123.9, Low = 118.8, Close = 122.5, Volume = 226100000 }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class PriceData
{
    public DateTime Date   { get; set; }
    public double   Open   { get; set; }
    public double   High   { get; set; }
    public double   Low    { get; set; }
    public double   Close  { get; set; }
    public double   Volume { get; set; }
}