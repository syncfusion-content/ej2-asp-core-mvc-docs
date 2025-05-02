public IActionResult Types()
    {
        ViewBag.range = new int[] { 30, 70 };
        return View();
    }