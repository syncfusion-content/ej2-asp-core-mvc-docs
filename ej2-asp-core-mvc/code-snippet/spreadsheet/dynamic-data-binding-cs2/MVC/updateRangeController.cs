public ActionResult Index()
{
    List<object> data = new List<object>()
    {
        new { CustomerName= "Romona Heaslip",  Model= "Taurus",  Color= "Aquamarine"},
        new { CustomerName= "Clare Batterton",  Model= "Sparrow",  Color= "Pink"},
        new { CustomerName= "Eamon Traise",  Model= "Grand Cherokee",  Color= "Blue" },
        new { CustomerName= "Julius Gorner",  Model= "GTO",  Color= "Aquamarine" },
        new { CustomerName= "Jenna Schoolfield",  Model= "LX",  Color= "Yellow" },
        new { CustomerName= "Marylynne Harring",  Model= "Catera",  Color= "Pink"},
        new { CustomerName= "Vilhelmina Leipelt",  Model= "7 Series",  Color= "Goldenrod"},
        new { CustomerName= "Barby Heisler",  Model= "Corvette",  Color= "Red"},
        new { CustomerName= "Karyn Boik",  Model= "Regal",  Color= "Pink"},
        new { CustomerName= "Jeanette Pamplin",  Model= "S4",  Color= "Fuscia"},
        new { CustomerName= "Cristi Espinos",  Model= "TL",  Color= "Aquamarine"},
        new { CustomerName= "Issy Humm",  Model= "Club Wagon",  Color= "Pink" },
        new { CustomerName= "Tuesday Fautly",  Model= "V8 Vantage",  Color= "Crimson"},
        new { CustomerName= "Rosemaria Thomann",  Model= "Caravan",  Color= "Violet"},
    };
    ViewBag.DefaultData = data;
    return View();
}