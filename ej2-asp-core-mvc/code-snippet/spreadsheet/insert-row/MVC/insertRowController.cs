public ActionResult Index()
{
  List<object> data = new List<object>()
    {
        new { ProductId= "1",  ProductName= "Chai",  SupplierId= "1",  QuantityPerUnit= "10 boxes x 20 bags",  UnitPrice= "18.00",  UnitsInStock= "39",  Discontinued= "false" },
        new { ProductId= "2",  ProductName= "Chang",  SupplierId= "1",  QuantityPerUnit= "24 - 12 oz bottles",  UnitPrice= "19.00",  UnitsInStock= "17",  Discontinued= "true" },
        new { ProductId= "3",  ProductName= "Aniseed Syrup",  SupplierId= "1",  QuantityPerUnit= "12 - 550 ml bottles",  UnitPrice= "10.00",  UnitsInStock= "13",  Discontinued= "false" },
        new { ProductId= "4",  ProductName= "Chef Anton\'s Cajun Seasoning",  SupplierId= "2",  QuantityPerUnit= "48 - 6 oz jars",  UnitPrice= "22.00",  UnitsInStock= "53",  Discontinued= "true" },
        new { ProductId= "5",  ProductName= "Chef Anton\'s Gumbo Mix",  SupplierId= "2",  QuantityPerUnit= "36 boxes', 'Unit Price",  UnitPrice= "21.35",  UnitsInStock= "0",  Discontinued= "true" },
        new { ProductId= "6",  ProductName= "Grandma\'s Boysenberry Spread",  SupplierId= "3",  QuantityPerUnit= "12 - 8 oz jars",  UnitPrice= "25.00",  UnitsInStock= "120",  Discontinued= "false" },
        new { ProductId= "7",  ProductName= "Uncle Bob\'s Organic Dried Pears",  SupplierId= "3",  QuantityPerUnit= "12 - 1 lb pkgs.",  UnitPrice= "30.00",  UnitsInStock= "15",  Discontinued= "true" },
        new { ProductId= "10",  ProductName= "Queso Cabrales",  SupplierId= "5",  QuantityPerUnit= "1 kg pkg.",  UnitPrice= "21.00",  UnitsInStock= "22",  Discontinued= "false" },
    };
    ViewBag.DefaultData = data;
    return View();
}