// Underline
public ActionResult Underline()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        text = "File",
        iconCss = "em-icons e-file",
        items = new List<object>()
                {
                    new { text = "Open", iconCss= "em-icons e-open" },
                    new { text = "Save", iconCss= "e-icons e-save" },
                    new { separator = true},
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
        text = "Format",
    });
    menuItems.Add(new
    {
        text = "View"
    });
    menuItems.Add(new
    {
        text = "Bookmarks"
    });
    menuItems.Add(new
    {
        text = "Tools"
    });
    menuItems.Add(new
    {
        separator = true    
    });
    menuItems.Add(new
    {
        text = "Help"
    });

    ViewBag.menuItems = menuItems;
    return View();
}