// Menu Navigation
public ActionResult MenuNavigation()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "Appliances",
        items = new List<object>()
                {
                    new { text= "Washing Machine", url= "https://www.google.com/search?q=washing+machine"},
                    new {text= "Air Conditioners", url= "https://www.google.com/search?q=air+conditioners" }
                }
    });
    menuItems.Add(new
    {
        text = "Mobile",
        items = new List<object>()
                {
                    new { text= "Headphones", url= "https://www.google.com/search?q=headphones" },
                    new { text= "Memory Cards", url= "https://www.google.com/search?q=memory+cards" },
                    new { text= "Power Banks", url= "https://www.google.com/search?q=power+banks" }
                }
    });
    menuItems.Add(new
    {
        text = "Entertainment",
        items = new List<object>()
                {
                    new { text= "Televisions", url= "https://www.google.com/search?q=televisions" },
                    new { text= "Home Theatres", url= "https://www.google.com/search?q=home+theatres" },
                    new { text= "Gaming Laptops", url= "https://www.google.com/search?q=gaming+laptops" }
                }
    });
    menuItems.Add(new
    {
        text = "Fashion",
        url = "https://www.google.com/search?q=fashion"
    });
    menuItems.Add(new
    {
        text = "Offers",
        url = "https://www.google.com/search?q=offers"
    });

    ViewBag.menuItems = menuItems;
    return View();
}