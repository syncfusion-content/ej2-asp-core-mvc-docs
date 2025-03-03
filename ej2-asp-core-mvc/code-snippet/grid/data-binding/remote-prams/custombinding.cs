public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    
    public ActionResult GetOrderData()
    {
        IEnumerable<OrdersDetails> dataSource = OrdersDetails.GetAllRecords();
        int totalCount = dataSource.Count();
        return Json(new { result = dataSource, count = totalCount });
    }
}