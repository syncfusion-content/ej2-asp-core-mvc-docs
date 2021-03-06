namespace DataAnnotation.Controllers
{
    public class HomeController : Controller
    {
        public static List<Orders> order = new List<Orders>();
        public ActionResult Index()
        {
            ViewBag.DataSource = Orders.getAllRecords().ToList();
            ViewBag.Type = typeof(Orders);
            return View();
        }
        public class Orders
        {

            public Orders(long OrderId, string Customerid, int EmployeeId, double Freight, string ShipCity)
            {
                this.OrderID = OrderId;
                this.CustomerID = Customerid;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.ShipCity = ShipCity;
            }

            public static List<Orders> getAllRecords()
            {
                if (order.Count == 0)
                {
                    int code = 10000;
                    for (int i = 1; i < 2; i++)
                    {
                        order.Add(new Orders(code + 1, "ALFKI", i + 0, 2.3 * i, "Berlin"));
                        order.Add(new Orders(code + 2, "ANATR", i + 2, 3.3 * i, "Madrid"));
                        order.Add(new Orders(code + 3, "ANTON", i + 1, 4.3 * i, "Cholchester"));
                        order.Add(new Orders(code + 4, "BLONP", i + 3, 5.3 * i, "Marseille"));
                        order.Add(new Orders(code + 5, "BOLID", i + 4, 6.3 * i, "Tsawassen"));
                        code += 5;
                    }
                }
                return order;
            }
            [Key]
            [Display(Name = "Order ID")]
            [Required(ErrorMessage = "Order ID is required")]
            public long OrderID { get; set; }
            [Display(Name = "Customer ID")]
            [Required(ErrorMessage = "Customer ID is required")]
            [StringLength(8, MinimumLength = 3, ErrorMessage = "Customer ID length should between 3 and 8")]
            public string CustomerID { get; set; }
            [Display(Name = "Employee ID")]
            [Range(1, 10, ErrorMessage = "Employee ID should be between 1 and 10")]
            public int EmployeeID { get; set; }
            [DisplayFormat(DataFormatString = "c2")]
            [Range(1, 1000, ErrorMessage = "Freight should be between 1 and 1000")]
            public double Freight { get; set; }
            [Display(Name = "Ship City")]
            [Editable(false)]
            public string ShipCity { get; set; }
        }
    }
}
