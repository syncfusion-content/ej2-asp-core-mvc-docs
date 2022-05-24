namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Order = OrdersDetails.GetAllRecords();
            var Order1 = OrdersData.GetAllRecords();
            ViewBag.DataSource = BigData.GetAllRecords();
            return View();
        }
        public ActionResult ForeignKey([FromBody] DataManagerRequest dm)
        {
            IEnumerable DataSource = OrdersData.GetAllRecords();       
            return dm.RequiresCounts ? Json(new { result = DataSource }) : Json(DataSource);
        }
        public IActionResult Update([FromBody]CRUDModel<OrdersDetails> value)
        {
            var data = OrdersDetails.GetAllRecords().Where(or => or.OrderID == value.Value.OrderID).FirstOrDefault();
            if (data != null)
            {
                data.OrderID = value.Value.OrderID;
                data.EmployeeID = value.Value.EmployeeID;
                data.CustomerID = value.Value.CustomerID;
                data.Freight = value.Value.Freight;
                data.OrderDate = value.Value.OrderDate;
                data.ShipName = value.Value.ShipName;
            }
            return Json( new { value.Value});
        }
        public IActionResult Insert([FromBody]CRUDModel<OrdersDetails> value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value.Value);
            return Json(new { value.Value});
        }
        public IActionResult Remove([FromBody]CRUDModel<OrdersDetails> value)
        {
            var data = OrdersDetails.GetAllRecords().Where(or => or.OrderID.Equals(int.Parse(value.Key.ToString()))).FirstOrDefault();
            OrdersDetails.GetAllRecords().Remove(data);
            return Json(new {data});
        }
    }
    
}

