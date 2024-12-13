public ActionResult Index()
        {
            List<AxisLabelData> chartData = new List<AxisLabelData>
            {
               new AxisLabelData { x= "Sun", low= 2.5, high= 9.8 },
               new AxisLabelData { x= "Mon", low= 4.7, high= 11.4 },
               new AxisLabelData { x= "Tue", low= 6.4, high= 14.4 },
               new AxisLabelData { x= "Wed", low= 9.6, high= 17.2 },
               new AxisLabelData { x= "Thu", low= 7.5, high= 15.1 },
               new AxisLabelData { x= "Fri", low= 3.0, high= 10.5 },
               new AxisLabelData { x= "Sat", low= 1.2, high= 7.9 }
            };
            ViewBag.dataSource = chartData;
            ChartBorder border = new ChartBorder();
            border.Width = 2;
            border.Color = "#962D18";
            border.DashArray="5,5";
            ViewBag.seriesBorder = border;
            return View();
        }
        public class AxisLabelData
        {
            public string x;
            public double low;
            public double high;
        }