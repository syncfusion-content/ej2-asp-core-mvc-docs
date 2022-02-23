public IActionResult Index()
    {
        ViewBag.range = new int[] { 25, 75 };
        return View();
    }