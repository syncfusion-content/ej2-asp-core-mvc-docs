public ActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { OrderId= "SF1001",  Product= "Laptop Backpack (Blue)",  OrderedDate= "02/14/2014",  OrderedBy= "Rahul Sharma",  Shipment= "Delivered"},
        new { OrderId= "SF1002",  Product= "Oppo F1 S mobile back cover",  OrderedDate= "06/11/2014",  OrderedBy= "Adi Pathak",  Shipment= "Delivered"},
        new { OrderId= "SF1003",  Product= "Tupperware 4 bottle set",  OrderedDate= "07/27/2014",  OrderedBy= "Himani Arora",  Shipment= "Pending"},
        new { OrderId= "SF1004",  Product= "Tupperware Lunch box",  OrderedDate= "11/21/2014",  OrderedBy= "Samuel Samson",  Shipment= "Shipped"},
        new { OrderId= "SF1005",  Product= "Panosonic Hair Dryer",  OrderedDate= "06/23/2014",  OrderedBy= "Neha",  Shipment= "Cancelled"},
        new { OrderId= "SF1006",  Product= "Philips LED 2 bulb set",  OrderedDate= "07/22/2014",  OrderedBy= "Christine J",  Shipment= "Pending"},
        new { OrderId= "SF1007",  Product= "Moto G4 plus headphone",  OrderedDate= "02/04/2014",  OrderedBy= "Shiv Nagar",  Shipment= "Delivered"},
        new { OrderId= "SF1008",  Product= "Lakme Eyeliner Pencil",  OrderedDate= "11/30/2014",  OrderedBy= "Cherry",  Shipment= "Shipped"},
        new { OrderId= "SF1009",  Product= "Listerine mouthwash",  OrderedDate= "07/09/2014",  OrderedBy= "Siddartha Mishra",  Shipment= "Pending"},
        new { OrderId= "SF1010",  Product= "Protinex original",  OrderedDate= "10/31/2014",  OrderedBy= "Ravi Chugh",  Shipment= "Delivered"},
    };
    ViewBag.DefaultData = data;
    return View();
}