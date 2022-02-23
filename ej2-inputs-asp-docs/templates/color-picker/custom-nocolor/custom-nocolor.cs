public ActionResult CustomNocolor()
    {
            List<object> custom = new List<object>();
            custom.Add(new
            {
                Custom1 = new string[] {"#f44336", "#e91e63", "#9c27b0", "#673ab7", "#2196f3", "#03a9f4", "#00bcd4",
                "#009688", "#8bc34a", "#cddc39", "#ffeb3b", "#ffc107"}
            });

            ViewBag.customColors = custom[0];
            return View();
    }