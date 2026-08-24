public IActionResult Index()
{
    List<PointRadialData> chartData = new List<PointRadialData>
    {
        new PointRadialData { Category = "Electronics",       Share = 22.5, DataLabel = "Electronics: 22.5%" },
        new PointRadialData { Category = "Fashion",           Share = 18.0, DataLabel = "Fashion: 18.0%" },
        new PointRadialData { Category = "Home & Kitchen",    Share = 15.5, DataLabel = "Home & Kitchen: 15.5%" },
        new PointRadialData { Category = "Beauty & Health",   Share = 10.0, DataLabel = "Beauty & Health: 10.0%" },
        new PointRadialData { Category = "Sports & Outdoors", Share = 9.5,  DataLabel = "Sports & Outdoors: 9.5%" },
        new PointRadialData { Category = "Books",             Share = 8.0,  DataLabel = "Books: 8.0%" },
        new PointRadialData { Category = "Toys & Games",      Share = 7.0,  DataLabel = "Toys & Games: 7.0%" },
        new PointRadialData { Category = "Groceries",         Share = 6.0,  DataLabel = "Groceries: 6.0%" },
        new PointRadialData { Category = "Other",             Share = 3.5,  DataLabel = "Other: 3.5%" }
    };
    ViewBag.dataSource = chartData;
    return View();
}

public class PointRadialData
{
    public string Category { get; set; }
    public double Share { get; set; }
    public string DataLabel { get; set; }
}