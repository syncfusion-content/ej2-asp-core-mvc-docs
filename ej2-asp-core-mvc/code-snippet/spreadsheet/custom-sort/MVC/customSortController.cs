public ActionResult Index()
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
    ViewBag.DefaultData = data;
    return View();
}