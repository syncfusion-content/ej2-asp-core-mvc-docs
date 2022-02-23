public ActionResult Index()
{
    ViewBag.headerTextOne = new TabHeader { Text = "India" };
    ViewBag.headerTextTwo = new TabHeader { Text = "Australia" };
    ViewBag.headerTextThree = new TabHeader { Text = "USA" };
    ViewBag.headerTextFour = new TabHeader { Text = "France" };
    List<object> componentList = new List<object>();
    componentList.Add(new
    {
        text = "Hennessey Venom",
        id = "list-01"
    });
    componentList.Add(new
    {
        text = "Bugatti Chiron",
        id = "list-02"
    });
    componentList.Add(new
    {
        text = "Bugatti Veyron Super Sport",
        id = "list-03"
    });
    componentList.Add(new
    {
        text = "SSC Ultimate Aero",
        id = "list-04"
    });
    componentList.Add(new
    {
        text = "Koenigsegg CCR",
        id = "list-05"
    });
    componentList.Add(new
    {
        text = "McLaren F1",
        id = "list-06"
    });
    componentList.Add(new
    {
        text = "Aston Martin One- 77",
        id = "list-07"
    });
    componentList.Add(new
    {
        text = "Jaguar XJ220",
        id = "list-08"
    });
    componentList.Add(new
    {
        text = "McLaren P1",
        id = "list-09"
    });
    componentList.Add(new
    {
        text = "Ferrari LaFerrari",
        id = "list-10"
    });
    ViewBag.data = componentList;
    return View();
}