   public ActionResult Index()
        {
            List<EmptyPointsChartData> chartData = new List<EmptyPointsChartData>
            {

                new EmptyPointsChartData { xValue = "Rice",  yValue = 80   },
                new EmptyPointsChartData { xValue = "Wheat", yValue = null },
                new EmptyPointsChartData { xValue = "Oil",   yValue = 70   },
                new EmptyPointsChartData { xValue = "Corn",  yValue = 60   },
                new EmptyPointsChartData { xValue = "Gram",  yValue = null },
                new EmptyPointsChartData { xValue = "Milk",  yValue = 70   },
                new EmptyPointsChartData { xValue = "Peas",  yValue = 80   },
                new EmptyPointsChartData { xValue = "Fruit", yValue = 60   },
                new EmptyPointsChartData { xValue = "Butter",yValue = null },            

            };
            ViewBag.dataSource = chartData;      
            return View();
        }
        public class EmptyPointsChartData
        {
            public string xValue;
            public Nullable<double> yValue;
        }
 