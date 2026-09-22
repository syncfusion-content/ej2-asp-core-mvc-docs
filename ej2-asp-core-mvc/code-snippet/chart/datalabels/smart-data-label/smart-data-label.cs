using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<Data> dataA = new List<Data>
        {
            new Data { x = "Period 1", y = 35, text = "35%" },
            new Data { x = "Period 2", y = 30, text = "30%" },
            new Data { x = "Period 3", y = 32, text = "32%" }
        };

        List<Data> dataB = new List<Data>
        {
            new Data { x = "Period 1", y = 22, text = "22%" },
            new Data { x = "Period 2", y = 25, text = "25%" },
            new Data { x = "Period 3", y = 24, text = "24%" }
        };

        List<Data> dataC = new List<Data>
        {
            new Data { x = "Period 1", y = 14, text = "14%" },
            new Data { x = "Period 2", y = 16, text = "16%" },
            new Data { x = "Period 3", y = 15, text = "15%" }
        };

        List<Data> dataD = new List<Data>
        {
            new Data { x = "Period 1", y = 10, text = "10%" },
            new Data { x = "Period 2", y = 11, text = "11%" },
            new Data { x = "Period 3", y = 12, text = "12%" }
        };

        List<Data> dataE = new List<Data>
        {
            new Data { x = "Period 1", y = 7, text = "7%" },
            new Data { x = "Period 2", y = 8, text = "8%" },
            new Data { x = "Period 3", y = 6, text = "6%" }
        };

        List<Data> dataF = new List<Data>
        {
            new Data { x = "Period 1", y = 5, text = "5%" },
            new Data { x = "Period 2", y = 5, text = "5%" },
            new Data { x = "Period 3", y = 5, text = "5%" }
        };

        List<Data> dataG = new List<Data>
        {
            new Data { x = "Period 1", y = 4, text = "4%" },
            new Data { x = "Period 2", y = 3, text = "3%" },
            new Data { x = "Period 3", y = 4, text = "4%" }
        };

        List<Data> dataH = new List<Data>
        {
            new Data { x = "Period 1", y = 3, text = "3%" },
            new Data { x = "Period 2", y = 2, text = "2%" },
            new Data { x = "Period 3", y = 2, text = "2%" }
        };

        ViewBag.dataA = dataA;
        ViewBag.dataB = dataB;
        ViewBag.dataC = dataC;
        ViewBag.dataD = dataD;
        ViewBag.dataE = dataE;
        ViewBag.dataF = dataF;
        ViewBag.dataG = dataG;
        ViewBag.dataH = dataH;

        return View();
    }

    public class Data
    {
        public string x;
        public double y;
        public string text;
    }
}