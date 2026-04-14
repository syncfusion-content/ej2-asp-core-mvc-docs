public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    return View();
}

public class PivotData
{
    public int Product_ID { get; set; }
    public DateTime Date { get; set; }
    public string Products { get; set; }
    public int Sold { get; set; }
    public double Amount { get; set; }

}

public List<PivotData> GetPivotData()
{
    var pivotData = new List<PivotData>
     {
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Accessories", Product_ID = 1001, Sold = 2, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Accessories", Product_ID = 1002, Sold = 3, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Accessories", Product_ID = 1003, Sold = 5, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Bikes",       Product_ID = 1004, Sold = 1, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Bikes",       Product_ID = 1005, Sold = 1, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Clothings",   Product_ID = 1007, Sold = 2, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Clothings",   Product_ID = 1008, Sold = 1, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 1, 20, 18, 15), Products = "Clothings",   Product_ID = 1009, Sold = 3, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 5, 20, 19, 15), Products = "Accessories", Product_ID = 1003, Sold = 3, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 5, 20, 19, 15), Products = "Bikes",       Product_ID = 1004, Sold = 3, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 1, 5, 20, 19, 15), Products = "Clothings",   Product_ID = 1008, Sold = 8, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 2, 10, 22, 07), Products = "Accessories", Product_ID = 1002, Sold = 4, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 2, 10, 22, 07), Products = "Bikes",       Product_ID = 1005, Sold = 2, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 2, 10, 22, 07), Products = "Clothings",   Product_ID = 1009, Sold = 1, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 10, 10, 23, 07), Products = "Accessories", Product_ID = 1002, Sold = 1, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 10, 10, 23, 07), Products = "Bikes",       Product_ID = 1006, Sold = 4, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 10, 10, 23, 07), Products = "Clothings",   Product_ID = 1010, Sold = 6, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 20, 11, 25, 07), Products = "Clothings",   Product_ID = 1002, Sold = 8, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 20, 11, 25, 07), Products = "Bikes",       Product_ID = 1002, Sold = 8, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 2, 20, 11, 25, 07), Products = "Accessories", Product_ID = 1002, Sold = 8, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 3, 7, 5, 11, 50), Products = "Accessories", Product_ID = 1001, Sold = 4, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 3, 7, 5, 11, 50), Products = "Clothings",   Product_ID = 1001, Sold = 4, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 3, 7, 5, 11, 50), Products = "Bikes",       Product_ID = 1001, Sold = 4, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 3, 13, 5, 11, 55), Products = "Bikes",       Product_ID = 1005, Sold = 2, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 3, 13, 5, 11, 55), Products = "Clothings",   Product_ID = 1005, Sold = 2, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 3, 13, 5, 11, 55), Products = "Accessories", Product_ID = 1005, Sold = 2, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 9, 1, 4, 14, 43), Products = "Bikes",       Product_ID = 1004, Sold = 1, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 9, 1, 4, 14, 43), Products = "Clothings",   Product_ID = 1010, Sold = 2, Amount = 0.00 },
        new PivotData { Date = new DateTime(2015, 9, 1, 4, 14, 43), Products = "Accessories", Product_ID = 1004, Sold = 1, Amount = 0.00 },
    };
    return pivotData;
}