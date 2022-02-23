public class HomeController : Controller
{
    public class SubmitModel
    {
        public string Name { get; set; }

        public string PrimaryKey { get; set; }

        public string Value { get; set; }
    }

    public ActionResult Index()
    {
        var frameWorkList = new string[] { "Android", "JavaScript", "jQuery", "TypeScript", "Angular", "React", "Vue", "Ionic" };
        ViewBag.model = new { mode = "Box", dataSource = frameWorkList, placeholder = "Select skill" };
        ViewBag.value = new string[] { "JavaScript", "jQuery" };
        return View();
    }

    public void UpdateData([FromBody]SubmitModel model)
    {
        // User can process data here
    }
}