using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public class spacingModel
        {
            public double[] cellSpacing { get; set; }
        }
        public class ChartData
        {
            public string month;
            public double sales;
        }
        public class LineData
        {
            public double x;
            public double y;
        }

        public class PieData
        {
            public string x;
            public double y;
            public string text;
        }
        public ActionResult Index()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData {
                    month = "Jan",
                    sales = 35,
                },
                new ChartData {
                    month = "Feb",
                    sales = 28,
                },
                new ChartData {
                    month = "Mar",
                    sales = 34,
                },
                 new ChartData {
                    month = "Apr",
                    sales = 32,
                },
                new ChartData {
                    month = "May",
                    sales = 40,
                },
                new ChartData {
                    month = "Jun",
                    sales = 32,
                },
                new ChartData {
                    month = "Jul",
                    sales = 35,
                },
                new ChartData {
                    month = "Aug",
                    sales = 55,
                },
                new ChartData {
                    month = "Sep",
                    sales = 38,
                },
                 new ChartData {
                    month = "Oct",
                    sales = 30,
                },
                new ChartData {
                    month = "Nov",
                    sales = 25,
                },
                new ChartData {
                    month = "Dec",
                    sales = 32,
                }
            };
            ViewBag.chartSource = chartData;

            List<LineData> lineData = new List<LineData>
            {
                new LineData {
                    x = 2013,
                    y = 28,
                },
                new LineData {
                    x = 2014,
                    y = 25,
                },
                new LineData {
                    x = 2015,
                    y = 26,
                },
                new LineData {
                    x = 2016,
                    y = 27,
                },
                new LineData {
                    x = 2017,
                    y = 32,
                },
                new LineData {
                    x = 2018,
                    y = 35,
                }
            };
            ViewBag.lineSource = lineData;

            List<PieData> pieData1 = new List<PieData>
            {
                new PieData {
                    x = "Chrome",
                    y = 37,
                    text = "37%",
                },
                new PieData {
                    x = "UC Browser",
                    y = 17,
                    text = "17%",
                },
                new PieData {
                    x = "iPhone",
                    y = 19,
                    text = "19%",
                },
                new PieData {
                    x = "Others",
                    y = 4,
                    text = "4%",
                },
                new PieData {
                    x = "Opera",
                    y = 11,
                    text = "11%",
                },
                new PieData {
                    x = "Android",
                    y = 12,
                    text = "12%",
                }
            };
            ViewBag.pieSource1 = pieData1;

            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            return View(modelValue);
        }
    }
}