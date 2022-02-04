public class HomeController : Controller
{
    public ActionResult Index()
    {
        var frameWorkList = new string[] { "Android", "JavaScript", "jQuery", "TypeScript", "Angular", "React", "Vue", "Ionic" };
        ViewBag.dateValue = new DateTime(2018, 11, 23);
        ViewBag.dateTimeValue = new DateTime(2018, 11, 23, 12, 30, 00);
        ViewBag.dateRangeValue = new DateTime[] { new DateTime(2018, 11, 12), new DateTime(2018, 11, 15) };
        ViewBag.dateModelData = new { placeholder = "Select date" };
        ViewBag.dropModelData = new { dataSource = frameWorkList, placeholder = "Select frameworks" };
        ViewBag.maskModelData = new { mask = "000-000-000" };
        ViewBag.rteModelData = new { placeholder = "Enter your content here" };
        ViewBag.numericModelData = new { placeholder = "Enter number" };
        ViewBag.textModelData = new { placeholder = "Enter some text" };
        ViewBag.dropDownValue = "Android";
        ViewBag.maskValue = "123-345-678";
        ViewBag.textValue = "Andrew";
        ViewBag.colorValue = "#81aefd";
        ViewBag.rteValue = "<p>Enter your content here</p>";
        return View();
    }
}