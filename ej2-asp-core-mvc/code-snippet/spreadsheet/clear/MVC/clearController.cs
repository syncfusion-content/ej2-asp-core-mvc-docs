public ActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { OrderID= "10248",  CustomerID= "VINET",  EmployeeID= "5",  ShipName= "Vins et alcools Chevalier",  ShipCity= "Reims",  Website= "https://www.amazon.com/" },
        new { OrderID= "10249",  CustomerID= "TOMSP",  EmployeeID= "6",  ShipName= "Toms Spezialitäten",  ShipCity= "Münster",  Website= "https://www.overstock.com/" },
        new { OrderID= "10250",  CustomerID= "HANAR",  EmployeeID= "4",  ShipName= "Hanari Carnes",  ShipCity= "Rio de Janeiro",  Website= "https://www.aliexpress.com/" },
        new { OrderID= "10251",  CustomerID= "VICTE",  EmployeeID= "3",  ShipName= "Victuailles en stock",  ShipCity= "Lyon",  Website= "http://www.alibaba.com/" },
        new { OrderID= "10252",  CustomerID= "SUPRD",  EmployeeID= "4",  ShipName= "Suprêmes délices",  ShipCity= "Charleroi",  Website= "https://taobao.com/" },
        
    };
    List<object> items = new List<object>();
    items.Add(new
    {
        text = "Clear All"
    });
    items.Add(new
    {
        text = "Clear Formats"
    });
    items.Add(new
    {
        text = "Clear Contents"
    });
    items.Add(new
    {
        text = "Clear Hyperlinks"
    });
    ViewBag.items = items;
    ViewBag.DefaultData = data;
    return View();
}