public ActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { ItemCode= "I231",  ItemName= "Chinese Combo Noodle",  Quantity= "2",  Rate= "125",  Amount= "=PRODUCT(C2,D2)"},
        new { ItemCode= "I245",  ItemName= "Chinese Combo Rice",  Quantity= "3",  Rate= "125",  Amount= "=PRODUCT(C3,D3)"},
        new { ItemCode= "I237",  ItemName= "Amritsari Chola",  Quantity= "2",  Rate= "225",  Amount= "=PRODUCT(C4,D4)"},
        new { ItemCode= "I291",  ItemName= "Asian Mixed Entree Platt",  Quantity= "3",  Rate= "165",  Amount= "=PRODUCT(C5,D5)"},
        new { ItemCode= "I268",  ItemName= "Chinese Combo Chicken",  Quantity= "3",  Rate= "125",  Amount= "=PRODUCT(C6,D6)"},
        new { ItemCode= "I251",  ItemName= "Chivas Regal",  Quantity= "1",  Rate= "325",  Amount= "=PRODUCT(C7,D7)"},
        new { ItemCode= "I256",  ItemName= "Chicken Drumsticks",  Quantity= "2",  Rate= "180",  Amount= "=PRODUCT(C8,D8)"},
        new { ItemCode= "I232",  ItemName= "Manchow Soup",  Quantity= "2",  Rate= "160",  Amount= "=PRODUCT(C9,D9)"},
        new { ItemCode= "I290",  ItemName= "Schezuan Chicken",  Quantity= "3",  Rate= "180",  Amount= "=PRODUCT(C10,D10)"},
    };
    ViewBag.DefaultData = data;
    return View();
}