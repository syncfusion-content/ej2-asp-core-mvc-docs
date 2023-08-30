public ActionResult Index()
{
    return View();
}

public class AppointmentData
{
    public int Id { get; set; }
    public string ShipName { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public string ShipCountry { get; set; }
    public string ShipAddress { get; set; }
    public string ShipRegion { get; set; }
}