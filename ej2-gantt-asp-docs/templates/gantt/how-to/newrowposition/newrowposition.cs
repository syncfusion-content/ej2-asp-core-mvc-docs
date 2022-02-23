public IActionResult Index()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Top"
            });
            menuItems.Add(new
            {
                text = "Bottom"
            });
            menuItems.Add(new
            {
                text = "Above"
            });
            menuItems.Add(new
            {
                text = "Below"
            });
            menuItems.Add(new
            {
                text = "Child"
            });
            ViewBag.menuItems = menuItems;

            ViewBag.DataSource = GanttData.ProjectNewData();
            return View();
        }