    public IActionResult Index()
    {
        List<CategoryData> chartData = new List<CategoryData>
        {
            new CategoryData { x = "SUV", y = 25 },
            new CategoryData { x = "Car", y = 37 },
            new CategoryData { x = "Pickup", y = 15 },
            new CategoryData { x = "Minivan", y = 23 },

            };
        ViewBag.datalabel = new
        {
            visible = true,
            position = "Inside",
            name = "text",
            font = new
            {
                fontWeight = "600"
            }
        };
        ViewBag.dataSource = chartData;

        return View();
    }
    public class CategoryData
    {
        public string x;
        public double y;
    }