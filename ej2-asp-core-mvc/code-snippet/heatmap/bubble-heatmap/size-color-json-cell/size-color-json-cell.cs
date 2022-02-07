public ActionResult Gradient()
{
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            string[] xlabels = new string[3] { "2017", "2016", "2015" };
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[6] { "Jan-Feb", "Mar-Apr", "May-Jun", "Jul-Aug", "Sep-Oct", "Nov-Dec" };
            ViewBag.yLabels = yLabels;
            return View();
}