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
        public ActionResult UpdateOrder(int OrderID, OrdersDetails value)
        {
            var ord = value;
            OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
            val.OrderID = ord.OrderID;
            val.CustomerName = ord.CustomerName;
            val.ProductID = ord.ProductID;
            val.ProductName = ord.ProductName;
            return Json(new { result=value });
        }
        public ActionResult AddOrder(OrdersDetails value)
        {
            OrdersDetails.GetAllRecords().Insert(0, value);
            return Json(value);
        }
        public ActionResult DeleteOrder(int id)
        {
            OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == id).FirstOrDefault());
            var data = OrdersDetails.GetAllRecords();
            return Json(new { result = data });
        }
    }