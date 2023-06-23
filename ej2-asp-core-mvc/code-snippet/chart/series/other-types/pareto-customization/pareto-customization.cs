public ActionResult Index()
        {
            List<ParetoChartData> ChartPoints = new List<ParetoChartData>
            {
                new ParetoChartData { DefectCategory = "Button Defect", Y = 23 },
                new ParetoChartData { DefectCategory = "Pocket Defect", Y = 16 },
                new ParetoChartData { DefectCategory = "Collar Defect", Y = 10 },
                new ParetoChartData { DefectCategory = "Cuff Defect", Y = 7 },
                new ParetoChartData { DefectCategory = "Sleeve Defect", Y = 6 },
                new ParetoChartData { DefectCategory = "Other Defect", Y = 2 }
            };
            ViewBag.ChartPoints = ChartPoints;
            return View();
        }
        public class ParetoChartData
        {
            public string DefectCategory;
            public double Y;
        }