// Customize Menu Items
public ActionResult CustomizeMenuItems()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        continent = "Asia",
        countries = new List<object>()
        {
            new { country = "China" },
            new { country = "India" },
            new { country = "Japan" }
         },
    });
    menuItems.Add(new
    {
        continent = "North America",
        countries = new List<object>()
         {
            new { country = "Canada" },
            new { country = "Mexico" },
            new { country = "USA" }
        },
    });
    menuItems.Add(new
    {
        continent = "South America",
        countries = new List<object>()
        {
            new { country = "Brazil" },
            new { country = "Colombia" },
            new { country = "Argentina" }
        },
    });
    menuItems.Add(new
    {
        continent = "Oceania",
        countries = new List<object>()
        {
            new { country = "Australia" },
            new { country = "New Zealand" },
            new { country = "Samoa" }
        },
    });
    menuItems.Add(new { continent = "Antarctica" });

    MenuFieldSettings menuFields = new MenuFieldSettings()
    {
        Text = new string[] { "continent", "country" },
        Children = new string[] { "countries" }
    };

    ViewBag.menuItems = menuItems;
    ViewBag.menuFields = menuFields;
    return View();
}