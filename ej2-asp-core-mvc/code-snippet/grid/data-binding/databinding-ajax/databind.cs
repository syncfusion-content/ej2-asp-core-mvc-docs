public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    public ActionResult Getdata()
    {
        IEnumerable DataSource = OrdersDetails.GetAllRecords();
        return Json(DataSource);
    }
    public ActionResult Update(OrdersDetails value)
    {
        var ord = value;
        OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
        val.OrderID = ord.OrderID;
        val.EmployeeID = ord.EmployeeID;
        val.CustomerID = ord.CustomerID;
        val.Freight = ord.Freight;
        val.OrderDate = ord.OrderDate;
        val.ShipCity = ord.ShipCity;
        val.ShipCountry = ord.ShipCountry;
        return Json(value);
    }
    //insert the record
    public ActionResult Insert(OrdersDetails value)
    {
        OrdersDetails.GetAllRecords().Insert(0, value);
        return Json(value);
    }
    //Delete the record
    public ActionResult Delete(int key)
    {
        OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == key).FirstOrDefault());
        var data = OrdersDetails.GetAllRecords();
        return Json(data);
    }
}
