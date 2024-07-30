public IActionResult Index()
        {
            List<object> defaultData = new List<object>()
            {
                new { Item Name= "Casual Shoes", Date= "02/14/2014", Time= "11:34:32 AM", Quantity= "10", Price= "20", Amount= "200", Discount= "1", Profit= "10" },
                new { Item Name= "Sports Shoes", Date= "06/11/2014", Time= "05:56:32 AM", Quantity= "20", Price= "30", Amount= "600", Discount= "5", Profit= "50" },
                new { Item Name= "Formal Shoes", Date= "07/27/2014", Time= "03:32:44 AM", Quantity= "20", Price= "15", Amount= "300", Discount= "7", Profit= "27" },
                new { Item Name= "Sandals & Floaters", Date= "11/21/2014", Time= "06:23:54 AM", Quantity= "15", Price= "20", Amount= "300", Discount= "11", Profit= "67" },
                new { Item Name= "Flip- Flops & Slippers", Date= "06/23/2014", Time= "12:43:59 AM", Quantity= "30", Price= "10", Amount= "300", Discount= "10", Profit= "70" },
                new { Item Name= "Sneakers", Date= "07/22/2014", Time= "10:55:53 AM", Quantity= "40", Price= "20", Amount= "800", Discount= "13", Profit= "66" },
                new { Item Name= "Running Shoes", Date= "02/04/2014", Time= "03:44:34 AM", Quantity= "20", Price= "10", Amount= "200", Discount= "3", Profit= "14" },
                new { Item Name= "Loafers", Date= "11/30/2014", Time= "03:12:52 AM", Quantity= "31", Price= "10", Amount= "310", Discount= "6", Profit= "29" },
                new { Item Name= "Cricket Shoes", Date= "07/09/2014", Time= "11:32:14 AM", Quantity= "41", Price= "30", Amount= "1210", Discount= "12", Profit= "166" },
                new { Item Name= "T-Shirts", Date= "10/31/2014", Time= "12:01:44 AM", Quantity= "50", Price= "10", Amount= "500", Discount= "9", Profit= "55" }
            };
            ViewBag.DefaultData = defaultData;

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
            ViewBag.ProductData = data;
            return View();

        }