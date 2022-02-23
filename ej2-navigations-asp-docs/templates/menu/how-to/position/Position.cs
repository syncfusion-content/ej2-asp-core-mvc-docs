public ActionResult Position()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "File",
        items = new List<object>()
        {
            new { text = "Open" },
            new { text = "Save" },
            new { text = "Exit" }
        }
    });
    menuItems.Add(new
    {
        text = "Edit",
        items = new List<object>()
        {
            new { text = "Cut" },
            new { text = "Copy" },
            new { text = "Paste" }
        }
    });
    menuItems.Add(new
    {
        text = "View",
        items = new List<object>()
        {
            new { text = "Toolbar" },
            new { text = "Sidebar" },
            new { text = "Fullscreen" }
        }
    });
    menuItems.Add(new
    {
        text = "Tools",
        items = new List<object>()
        {
            new { text = "Spelling & Grammar" },
            new { text = "Customize" },
            new { text = "Options" }
        }
    });
    menuItems.Add(new
    {
        text = "Help"
    });

    ViewBag.menuItems = menuItems;
    return View();
}