public ActionResult Title()
{
    List<object> menuItems = new List<object>();
    menuItems.Add(new
    {
        id: 'settingIcon',
        iconCss: 'em-icons e-file',
        items = new List<object>()
        {
            new { text = "Open",
            items = new List<object>()
        {
            new { text = "Option 1" },
            new { text = "Option 2" }
        } },
            new { text = "Save" },
            { separator: true },
            new { text = "Exit" }
        }
    });
        ViewBag.menuItems = menuItems;
    return View();
}