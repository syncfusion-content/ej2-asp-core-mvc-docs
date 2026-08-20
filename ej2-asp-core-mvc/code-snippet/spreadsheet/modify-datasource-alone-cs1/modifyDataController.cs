public IActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { CustomerName= "Romona Heaslip",  Model= "Taurus",  Color= "Aquamarine",  PaymentMode= "Debit Card",  DeliveryDate= "07/11/2015",  Amount= "8529.22" },
        new { CustomerName= "Clare Batterton",  Model= "Sparrow",  Color= "Pink",  PaymentMode= "Cash On Delivery",  DeliveryDate= "7/13/2016",  Amount= "17866.19" },
        new { CustomerName= "Eamon Traise",  Model= "Grand Cherokee",  Color= "Blue",  PaymentMode= "Net Banking",  DeliveryDate= "09/04/2015",  Amount= "13853.09" },
        new { CustomerName= "Julius Gorner",  Model= "GTO",  Color= "Aquamarine",  PaymentMode= "Credit Card",  DeliveryDate= "12/15/2017",  Amount= "2338.74" },
        new { CustomerName= "Jenna Schoolfield",  Model= "LX",  Color= "Yellow",  PaymentMode= "Credit Card",  DeliveryDate= "10/08/2014",  Amount= "9578.45" },
        new { CustomerName= "Marylynne Harring",  Model= "Catera",  Color= "Green",  PaymentMode= "Cash On Delivery",  DeliveryDate= "7/01/2017",  Amount= "19141.62" },
        new { CustomerName= "Vilhelmina Leipelt",  Model= "7 Series",  Color= "Goldenrod",  PaymentMode= "Credit Card",  DeliveryDate= "12/20/2015",  Amount= "6543.30" },
        new { CustomerName= "Barby Heisler",  Model= "Corvette",  Color= "Red",  PaymentMode= "Credit Card",  DeliveryDate= "11/24/2014",  Amount= "13035.06" },
        new { CustomerName= "Karyn Boik",  Model= "Regal",  Color= "Indigo",  PaymentMode= "Debit Card",  DeliveryDate= "05/12/2014",  Amount= "18488.80" },
        new { CustomerName= "Jeanette Pamplin",  Model= "S4",  Color= "Fuscia",  PaymentMode= "Net Banking",  DeliveryDate= "12/30/2014",  Amount= "12317.04" },
        new { CustomerName= "Cristi Espinos",  Model= "TL",  Color= "Aquamarine",  PaymentMode= "Credit Card",  DeliveryDate= "12/18/2013",  Amount= "6230.13" },
        new { CustomerName= "Issy Humm",  Model= "Club Wagon",  Color= "Pink",  PaymentMode= "Cash On Delivery",  DeliveryDate= "02/02/2015",  Amount= "9709.49" },
        new { CustomerName= "Tuesday Fautly",  Model= "V8 Vantage",  Color= "Crimson",  PaymentMode= "Debit Card",  DeliveryDate= "11/19/2014",  Amount= "9766.10" },
        new { CustomerName= "Rosemaria Thomann",  Model= "Caravan",  Color= "Violet",  PaymentMode= "Net Banking",  DeliveryDate= "02/08/2014",  Amount= "7685.49" },
    };

    List<object> itemData = new List<object>()
    {
        new { ItemName= "Casual Shoes", Date= "02/14/2014", Time= "11:34:32 AM", Quantity= "10", Price= "20", Amount= "200", Discount= "1", Profit= "10" },
        new { ItemName= "Sports Shoes", Date= "06/11/2014", Time= "05:56:32 AM", Quantity= "20", Price= "30", Amount= "600", Discount= "5", Profit= "50" },
        new { ItemName= "Formal Shoes", Date= "07/27/2014", Time= "03:32:44 AM", Quantity= "20", Price= "15", Amount= "300", Discount= "7", Profit= "27" },
        new { ItemName= "Sandals & Floaters", Date= "11/21/2014", Time= "06:23:54 AM", Quantity= "15", Price= "20", Amount= "300", Discount= "11", Profit= "67" },
        new { ItemName= "Flip- Flops & Slippers", Date= "06/23/2014", Time= "12:43:59 AM", Quantity= "30", Price= "10", Amount= "300", Discount= "10", Profit= "70" },
        new { ItemName= "Sneakers", Date= "07/22/2014", Time= "10:55:53 AM", Quantity= "40", Price= "20", Amount= "800", Discount= "13", Profit= "66" },
        new { ItemName= "Running Shoes", Date= "02/04/2014", Time= "03:44:34 AM", Quantity= "20", Price= "10", Amount= "200", Discount= "3", Profit= "14" },
        new { ItemName= "Loafers", Date= "11/30/2014", Time= "03:12:52 AM", Quantity= "31", Price= "10", Amount= "310", Discount= "6", Profit= "29" },
        new { ItemName= "Cricket Shoes", Date= "07/09/2014", Time= "11:32:14 AM", Quantity= "41", Price= "30", Amount= "1210", Discount= "12", Profit= "166" },
        new { ItemName= "T-Shirts", Date= "10/31/2014", Time= "12:01:44 AM", Quantity= "50", Price= "10", Amount= "500", Discount= "9", Profit= "55" }
    };
    ViewBag.DefaultData = data;
    ViewBag.ItemData = itemData;
    return View();
}