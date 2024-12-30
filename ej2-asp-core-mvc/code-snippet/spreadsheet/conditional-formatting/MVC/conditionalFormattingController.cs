public ActionResult Index()
{
    List<object> conditionalFormatData = new List<object>()
    {
        new { EVModel= "BMW I3", JAN= "1224", FEB= "423", MAR= "585", APR= "367", MAY= "729", JUN= "733", TOTAL= "=SUM(B2=G2)" },
        new { EVModel= "Tesla Model S", JAN= "975", FEB= "763", MAR= "723", APR= "483", MAY= "983", JUN= "589", TOTAL= "=SUM(B3=G3)" }, 
        new { EVModel= "Chevrolet Volt", JAN= "113", FEB= "289", MAR= "675", APR= "458", MAY= "391", JUN= "198", TOTAL= "=SUM(B4=G4)" },
        new { EVModel= "Jaguar I-PACE", JAN= "78", FEB= "177", MAR= "244", APR= "99", MAY= "312", JUN= "129", TOTAL= "=SUM(B5=G5)" },
        new { EVModel= "Tesla Model X", JAN= "978", FEB= "1108", MAR= "1604", APR= "879", MAY= "1070", JUN= "1001", TOTAL= "=SUM(B6=G6)" },
        new { EVModel= "Nissan LEAF", JAN= "229", FEB= "978", MAR= "1202", APR= "822", MAY= "135", JUN= "878", TOTAL= "=SUM(B7=G7)" },
        new { EVModel= "Honda Clarity EV", JAN= "671", FEB= "1302", MAR= "466", APR= "989", MAY= "679", JUN= "891", TOTAL= "=SUM(B8=G8)" },
        new { EVModel= "Toyota Prius Prime", JAN= "978", FEB= "1362", MAR= "1872", APR= "678", MAY= "900", JUN= "867", TOTAL= "=SUM(B9=G9)" }
    };
    ViewBag.DefaultData = conditionalFormatData;
    return View();
}