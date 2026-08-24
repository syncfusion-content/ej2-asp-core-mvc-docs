public IActionResult Index()
{
    List<StockData> chartData = new List<StockData>
    {
        new StockData { Date = new DateTime(2012, 4,  2),  Open = 85.9757, High = 90.6657, Low = 85.7685, Close = 90.5257, Volume = 660187068  },
        new StockData { Date = new DateTime(2012, 4,  9),  Open = 89.4471, High = 92.0000, Low = 86.2157, Close = 86.4614, Volume = 912634864  },
        new StockData { Date = new DateTime(2012, 4,  16), Open = 87.1514, High = 88.6071, Low = 81.4885, Close = 81.8543, Volume = 1221746066 },
        new StockData { Date = new DateTime(2012, 4,  23), Open = 81.5157, High = 88.2857, Low = 79.2857, Close = 86.1428, Volume = 965935749  },
        new StockData { Date = new DateTime(2012, 4,  30), Open = 85.4000, High = 85.4857, Low = 80.7385, Close = 80.7500, Volume = 615249365  },
        new StockData { Date = new DateTime(2012, 5,  7),  Open = 80.2143, High = 82.2685, Low = 79.8185, Close = 80.9585, Volume = 541742692  },
        new StockData { Date = new DateTime(2012, 5,  14), Open = 80.3671, High = 81.0728, Low = 74.5971, Close = 75.7685, Volume = 708126233  },
        new StockData { Date = new DateTime(2012, 5,  21), Open = 76.3571, High = 82.3571, Low = 76.2928, Close = 80.3271, Volume = 682076215  },
        new StockData { Date = new DateTime(2012, 5,  28), Open = 81.5571, High = 83.0714, Low = 80.0743, Close = 80.1414, Volume = 480059584  }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class StockData
{
    public DateTime Date   { get; set; }
    public double   Open   { get; set; }
    public double   High   { get; set; }
    public double   Low    { get; set; }
    public double   Close  { get; set; }
    public double   Volume { get; set; }
}