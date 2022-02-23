public ActionResult JsonRow()
{
    ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewBag.border = new
            {
                width = 0,
                radius = 4,
                color = "white"
            };
            string[] xlabels = new string[9] { "China", "France", "GBR", "Germany", "Italy", "Japan", "KOR", "Russia", "USA" };
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[5] { "2000", "2004", "2008", "2012", "2016" };
            ViewBag.yLabels = yLabels;
            ViewBag.title = new { text = "Olympic Year" };
            return View();
}