public ActionResult Index()
    {
            List<string> values = new List<string> { "Mr.", "Mrs." };
            ViewBag.values = values;
            return View();
    }