public ActionResult Index()
{
    ViewBag.data = new List<DataSource>
    {
        new DataSource { xval = new DateTime(2024, 01, 01), yval = 3 },
        new DataSource { xval = new DateTime(2024, 01, 02), yval = 5 },
        new DataSource { xval = new DateTime(2024, 02, 01), yval = 2 },
        new DataSource { xval = new DateTime(2024, 03, 01), yval = 4 },
        new DataSource { xval = new DateTime(2024, 04, 01), yval = 6 }
    };

    return View();
}

public class DataSource
{
    public DateTime xval { get; set; }
    public double yval { get; set; }
}