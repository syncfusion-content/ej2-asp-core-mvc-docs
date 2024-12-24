public IActionResult Index()
{
    List<object> chartData = new List<object>()
    {
        new { Book= "Classics", Year2016= "19033", Year2017= "78453", Year2018= "24354", Year2019= "18757", Year2020= "34343" },
        new { Book= "Mystery", Year2016= "50400", Year2017= "82311", Year2018= "131003", Year2019= "19899", Year2020= "42200" },
        new { Book= "Romance", Year2016= "18002", Year2017= "49529", Year2018= "79567", Year2019= "12302", Year2020= "21277" },
        new { Book= "Sci-Fi & Fantasy", Year2016= "10033", Year2017= "51200", Year2018= "66211", Year2019= "12899", Year2020= "18779" },
        new { Book= "Horror", Year2016= "23454", Year2017= "78665", Year2018= "81232", Year2019= "19888", Year2020= "20986" }  
    };
    ViewBag.DefaultData = chartData;
    return View();
}