public IActionResult Index()
{
    List<RadialGradientData> chartData = new List<RadialGradientData>
    {
        new RadialGradientData { Category = "Electronics",       Share = 22.5, DataLabel = "Electronics: 22.5%" },
        new RadialGradientData { Category = "Fashion",           Share = 18.0, DataLabel = "Fashion: 18.0%" },
        new RadialGradientData { Category = "Home & Kitchen",    Share = 15.5, DataLabel = "Home & Kitchen: 15.5%" },
        new RadialGradientData { Category = "Beauty & Health",   Share = 10.0, DataLabel = "Beauty & Health: 10.0%" },
        new RadialGradientData { Category = "Sports & Outdoors", Share = 9.5,  DataLabel = "Sports & Outdoors: 9.5%" },
        new RadialGradientData { Category = "Books",             Share = 8.0,  DataLabel = "Books: 8.0%" },
        new RadialGradientData { Category = "Toys & Games",      Share = 7.0,  DataLabel = "Toys & Games: 7.0%" },
        new RadialGradientData { Category = "Groceries",         Share = 6.0,  DataLabel = "Groceries: 6.0%" },
        new RadialGradientData { Category = "Other",             Share = 3.5,  DataLabel = "Other: 3.5%" }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class RadialGradientData
{
    public string Category { get; set; }
    public double Share { get; set; }
    public string DataLabel { get; set; }
}