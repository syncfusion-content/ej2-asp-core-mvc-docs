public ActionResult Open(OpenRequest openRequest)
{
    return Content(Workbook.Open(openRequest));
}

public void Save(SaveSettings saveSettings)
{
    Workbook.Save(saveSettings);
}

public IActionResult Index()
{
    List<object> data = new List<object>()
            {
                new { ItemName= "Casual Shoes", Date= "02/14/2014", Time= "11:34:32 AM", Quantity= "10", Price= "20", Amount= "200", Discount= "1", Profit= "10" },
                new { ItemName= "Sports Shoes", Date= "06/11/2014", Time= "05:56:32 AM", Quantity= "20", Price= "30", Amount= "600", Discount= "5", Profit= "50" },
                new { ItemName= "Formal Shoes", Date= "07/27/2014", Time= "03:32:44 AM", Quantity= "20", Price= "15", Amount= "300", Discount= "7", Profit= "27" },
                new { ItemName= "Sandals & Floaters", Date= "11/21/2014", Time= "06:23:54 AM", Quantity= "15", Price= "20", Amount= "300", Discount= "11", Profit= "67" },
                new { ItemName= "Flip- Flops & Slippers", Date= "06/23/2014", Time= "12:43:59 AM", Quantity= "30", Price= "10", Amount= "300", Discount= "10", Profit= "70" },
                new { ItemName= "Sneakers", Date= "07/22/2014", Time= "10:55:53 AM", Quantity= "40", Price= "20", Amount= "800", Discount= "13", Profit= "66" },
                new { ItemName= "Running Shoes", Date= "02/04/2014", Time= "03:44:34 AM", Quantity= "20", Price= "10", Amount= "200", Discount= "3", Profit= "14" },
                new { ItemName= "Loafers", Date= "11/30/2014", Time= "03:12:52 AM", Quantity= "31", Price= "10", Amount= "310", Discount= "6", Profit= "29" },
                new { ItemName= "Cricket Shoes", Date= "07/09/2014", Time= "11:32:14 AM", Quantity= "41", Price= "30", Amount= "1210", Discount= "12", Profit= "166" },
                new { ItemName= "T-Shirts", Date= "10/31/2014", Time= "12:01:44 AM", Quantity= "50", Price= "10", Amount= "500", Discount= "9", Profit= "55" }
            };
    ViewBag.DefaultData = data;
    return View();

}