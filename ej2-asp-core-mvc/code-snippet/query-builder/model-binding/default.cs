public ActionResult Index()
    {
            List<string> values = new List<string> { "Mr.", "Mrs." };
            ViewBag.values = values;
            var fieldModel = new { allowFiltering = true, popupHeight = "380px" };
            var operatorModel = new { allowFiltering = true, popupHeight = "380px" };
            ViewBag.fieldModel = fieldModel;
            ViewBag.operatorModel = operatorModel;
            return View();
    }