public IActionResult Annotation()
{
    var Order = OrderDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
}


public class OrdersDetails
    {
      
        [Display(Name = "Order ID")]
        [Key]
        public int? OrderID { get; set; }

        [ScaffoldColumn(false)]        
        public string CustomerID { get; set; }

        [Range(2, 9)]        
        public int? EmployeeID { get; set; }

        [Editable(false)]
        [DisplayFormat(DataFormatString = "C2")]
        public double? Freight { get; set; }


        [Required(ErrorMessage = "Ship City  is required.")]
        public string ShipCity { get; set; }
   

        [Compare(nameof(ShipCity), ErrorMessage = "ShipCity do not match")]
        public string ShipName { get; set; }

        [Display(Name = "Country")]
        [MinLength(3, ErrorMessage = "Need atleast 3 characters")]
        [MaxLength(10, ErrorMessage = "Characters exceed")]
        public string ShipCountry { get; set; }
    }
}