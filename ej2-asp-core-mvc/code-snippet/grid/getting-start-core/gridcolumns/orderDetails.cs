   public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }
 
        public class OrdersDetails
        {
            public static List<OrdersDetails> order = new List<OrdersDetails>();
            public OrdersDetails()
            {
 
            }
            public OrdersDetails(int OrderID, string CustomerId, DateTime OrderDate, string ShipCountry, double Freight)
            {
                this.OrderID = OrderID;
                this.CustomerID = CustomerId;
                this.OrderDate = OrderDate;
                this.ShipCountry = ShipCountry;
                this.Freight = Freight;
            }
            public static List<OrdersDetails> GetAllRecords()
            {
                if (order.Count() == 0)
                {
                    order.Add(new OrdersDetails(10248, "Ana Trujillo", new DateTime(2025, 1, 12), "France", 32.38));
                    order.Add(new OrdersDetails(10249, "Martin Sommer", new DateTime(2025, 1, 15), "Germany", 11.61));
                    order.Add(new OrdersDetails(10250, "Thomas Hardy", new DateTime(2025, 2, 5), "Brazil", 65.83));
                    order.Add(new OrdersDetails(10251, "Elizabeth Lincoln", new DateTime(2025, 2, 18), "France", 41.34));
                    order.Add(new OrdersDetails(10252, "Victoria Ashworth", new DateTime(2025, 3, 10), "Belgium", 51.30));
                    order.Add(new OrdersDetails(10253, "Martine Rance", new DateTime(2025, 3, 22), "Brazil", 58.17));
                }
                return order;
            }
            public int? OrderID { get; set; }
            public string CustomerID { get; set; }
            public DateTime OrderDate { get; set; }
            public string ShipCountry { get; set; }
            public double Freight { get; set; }
        }
    }
