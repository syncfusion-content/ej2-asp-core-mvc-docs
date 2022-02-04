public ActionResult Index()
    {
        List<object> menuItems = new List<object>();
        menuItems.Add(new
        {
            text = "Cut"
        });
        menuItems.Add(new
        {
            text = "Copy"
        });
        menuItems.Add(new
        {
            text = "Paste"
        });
        ViewBag.menuItems = menuItems;
        return View();
    }