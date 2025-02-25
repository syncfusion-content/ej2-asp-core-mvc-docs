// Customize Menu Items
public ActionResult CustomizeMenuItems()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "Home",
        htmlAttributes = new
        {
            role = "menuitem",
            aria_label = "Home",
            tabindex = "1"
        }
    });
    menuItems.Add(new
    {
        text = "Book Categories",
        items = new List<object>()
        {
            new
            {
                text = "Cookbooks",
                htmlAttributes = new
                {
                    role = "menuitem",
                    aria_label = "Cookbooks",
                    tabindex = "1"
                }
            },
            new
            {
                text = "Children",
                htmlAttributes = new
                {
                    role = "menuitem",
                    aria_label = "Children",
                    tabindex = "1"
                }
            }
        },
        htmlAttributes = new
        {
            role = "menuitem",
            aria_label = "Book Categories",
            tabindex = "1"
        }
    });
    menuItems.Add(new
    {
        text = "Purchase",
        htmlAttributes = new
        {
            role = "menuitem",
            aria_label = "Purchase",
            tabindex = "1"
        }
    });

    menuItems.Add(new
    {
        text = "Contact Us",
        htmlAttributes = new
        {
            role = "menuitem",
            aria_label = "Contact Us",
            tabindex = "1"
        }
    });
    menuItems.Add(new
    {
        separator = true
    });
    menuItems.Add(new
    {
        text = "Login",
        id = "login",
        htmlAttributes = new
        {
            role = "menuitem",
            aria_label = "Login",
            tabindex = "1"
        }
    });
    ViewBag.menuItems = menuItems;
    return View();
}