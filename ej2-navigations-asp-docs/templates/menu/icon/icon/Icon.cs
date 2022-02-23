// GET: Icons
public ActionResult IconFeatures()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "File",
        iconCss = "em-icons e-file",
        items = new List<object>()
                {
                    new { text = "Open", iconCss= "em-icons e-open" },
                    new { text = "Save", iconCss= "em-icons e-save" },
                    new { separator = true },
                    new { text = "Exit" }
                }
    });
    menuItems.Add(new
    {
        text = "Edit",
        iconCss = "em-icons e-edit",
        items = new List<object>()
                {
                    new { text = "Cut", iconCss= "em-icons e-cut" },
                    new { text = "Copy", iconCss= "em-icons e-copy" },
                    new { text = "Paste", iconCss= "em-icons e-paste" }
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
        text = "Go"
    });
    menuItems.Add(new
    {
        text = "Help"
    });

    ViewBag.menuItems = menuItems;
    return View();
}