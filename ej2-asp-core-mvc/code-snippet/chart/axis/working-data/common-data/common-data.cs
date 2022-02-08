public ActionResult Index()
        {
            List<GroupingChartData> chartData = new List<GroupingChartData>
            {

                new GroupingChartData {  month= "Jan", sales= 35, sales1= 28 },
                new GroupingChartData { month= "Feb", sales= 28, sales1= 35 },
                new GroupingChartData { month= "Mar", sales= 34, sales1= 32 },
                new GroupingChartData { month= "Apr", sales= 32, sales1= 34 },
                new GroupingChartData { month= "May", sales= 40, sales1= 32  },
                new GroupingChartData { month= "Jun", sales= 32, sales1= 40  },
                new GroupingChartData { month= "Jul", sales= 35, sales1= 55  },
                new GroupingChartData { month= "Aug", sales= 55, sales1= 35 },
                new GroupingChartData { month= "Sep", sales= 38, sales1= 30 },
                new GroupingChartData { month= "Oct", sales= 30, sales1= 38  },
                new GroupingChartData { month= "Nov", sales= 25, sales1= 32 },
                new GroupingChartData { month= "Dec", sales= 32, sales1= 25 }

            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class GroupingChartData
        {
            public string month;
            public double sales;
            public double sales1;
        }