 public IActionResult Index()
        {
            ViewBag.toolBarItems = new String[] { "Zoom", "Pan", "Reset" };
            return View();
        }