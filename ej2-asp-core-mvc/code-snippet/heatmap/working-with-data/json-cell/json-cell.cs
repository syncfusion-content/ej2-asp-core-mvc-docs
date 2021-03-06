public ActionResult JsonCell()
{
    ViewBag.textStyle = new
     {
         size= "15px",
         fontWeight= "500",
         fontStyle= "Normal",
         fontFamily= "Segoe UI"
         };
         ViewBag.border = new
            {
                width = 1,
                radius = 4,
                color = "white"
            };
         string[] xlabels = new string[10] { "Austria", "China", "France", "Germany", "Italy", "Mexico", "Spain", "Thailand", "UK", "USA" };
         ViewBag.xLabels = xlabels;
         string[] yLabels = new string[7] { "2010", "2011", "2012", "2013", "2014", "2015", "2016" };
         ViewBag.yLabels = yLabels;
         return View();
}