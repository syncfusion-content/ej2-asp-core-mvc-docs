  public IActionResult Index()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            { 
                id=1,
                text = "View"
            });
            menuItems.Add(new
            {
                id = 2,
                text = "Sort By"
            });
            menuItems.Add(new
            {
                id = 5,
                text = ""
            });
            menuItems.Add(new
            {
                id = 3,
                text = "New"
            });
            menuItems.Add(new
            {
                id = 4,
                text = "Ascending",
                parentId = 2
            });
            ViewBag.menuItems = menuItems;
            return View();
        }