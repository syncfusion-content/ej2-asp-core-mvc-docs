public IActionResult Index()
{
    List<StockData> chartData = new List<StockData>
    {
        new StockData { date = new DateTime(2012, 4,  2),  open = 85.9757, high = 90.6657, low = 85.7685, close = 90.5257, volume = 660187068  },
        new StockData { date = new DateTime(2012, 4,  9),  open = 89.4471, high = 92.0000, low = 86.2157, close = 86.4614, volume = 912634864  },
        new StockData { date = new DateTime(2012, 4,  16), open = 87.1514, high = 88.6071, low = 81.4885, close = 81.8543, volume = 1221746066 },
        new StockData { date = new DateTime(2012, 4,  23), open = 81.5157, high = 88.2857, low = 79.2857, close = 86.1428, volume = 965935749  },
        new StockData { date = new DateTime(2012, 4,  30), open = 85.4000, high = 85.4857, low = 80.7385, close = 80.7500, volume = 615249365  },
        new StockData { date = new DateTime(2012, 5,  7),  open = 80.2143, high = 82.2685, low = 79.8185, close = 80.9585, volume = 541742692  },
        new StockData { date = new DateTime(2012, 5,  14), open = 80.3671, high = 81.0728, low = 74.5971, close = 75.7685, volume = 708126233  },
        new StockData { date = new DateTime(2012, 5,  21), open = 76.3571, high = 82.3571, low = 76.2928, close = 80.3271, volume = 682076215  },
        new StockData { date = new DateTime(2012, 5,  28), open = 81.5571, high = 83.0714, low = 80.0743, close = 80.1414, volume = 480059584  },
        new StockData { date = new DateTime(2012, 6,  4),  open = 80.2143, high = 82.9405, low = 78.3571, close = 82.9028, volume = 517577005  },
        new StockData { date = new DateTime(2012, 6,  11), open = 83.9600, high = 84.0714, low = 80.9571, close = 82.0185, volume = 499693120  },
        new StockData { date = new DateTime(2012, 6,  18), open = 81.5657, high = 84.2857, low = 81.4814, close = 83.1571, volume = 442172142  },
        new StockData { date = new DateTime(2012, 6,  25), open = 82.4714, high = 83.4285, low = 80.8014, close = 83.4285, volume = 371529102  },
        new StockData { date = new DateTime(2012, 7,  2),  open = 83.5328, high = 87.7628, low = 83.3714, close = 86.5543, volume = 385906790  },
        new StockData { date = new DateTime(2012, 7,  9),  open = 86.4714, high = 88.5528, low = 84.6685, close = 86.4243, volume = 524235196  },
        new StockData { date = new DateTime(2012, 7,  16), open = 86.4457, high = 87.9071, low = 86.1643, close = 86.3285, volume = 419537217  },
        new StockData { date = new DateTime(2012, 7,  23), open = 84.9143, high = 87.0971, low = 81.4285, close = 83.5943, volume = 680773023  },
        new StockData { date = new DateTime(2012, 7,  30), open = 84.4171, high = 88.2828, low = 83.9743, close = 87.9571, volume = 475109323  },
        new StockData { date = new DateTime(2012, 8,  6),  open = 88.1843, high = 89.2857, low = 87.8943, close = 88.8143, volume = 312826308  },
        new StockData { date = new DateTime(2012, 8,  13), open = 89.0557, high = 92.5985, low = 89.0357, close = 92.5871, volume = 392867193  },
        new StockData { date = new DateTime(2012, 8,  20), open = 92.8585, high = 96.4114, low = 92.5871, close = 94.7460, volume = 708614692  },
        new StockData { date = new DateTime(2012, 8,  27), open = 97.1414, high = 97.2671, low = 93.8928, close = 95.0343, volume = 383807217  },
        new StockData { date = new DateTime(2012, 9,  3),  open = 95.1085, high = 97.4971, low = 94.9285, close = 97.2057, volume = 355722047  },
        new StockData { date = new DateTime(2012, 9,  10), open = 97.2071, high = 99.5685, low = 93.7143, close = 98.7543, volume = 724042207  },
        new StockData { date = new DateTime(2012, 9,  17), open = 99.9071, high = 100.7243,low = 99.0885, close = 100.0135,volume = 500166040  },
        new StockData { date = new DateTime(2012, 9,  24), open = 98.1228, high = 99.3028, low = 94.3357, close = 95.3007, volume = 714507994  },
        new StockData { date = new DateTime(2012, 10, 1),  open = 95.8800, high = 96.6785, low = 92.9500, close = 93.2271, volume = 638543622  },
        new StockData { date = new DateTime(2012, 10, 8),  open = 92.4114, high = 92.5085, low = 89.0785, close = 89.9591, volume = 747127724  },
        new StockData { date = new DateTime(2012, 10, 15), open = 90.3357, high = 93.2557, low = 87.0885, close = 87.1200, volume = 646996264  },
        new StockData { date = new DateTime(2012, 10, 22), open = 87.4885, high = 90.7685, low = 84.4285, close = 86.2857, volume = 866040680  }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class StockData
{
    public DateTime date   { get; set; }
    public double   open   { get; set; }
    public double   high   { get; set; }
    public double   low    { get; set; }
    public double   close  { get; set; }
    public double   volume { get; set; }
}