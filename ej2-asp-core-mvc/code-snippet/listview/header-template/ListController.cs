public class ListViewController : Controller
{
    public IActionResult List()
    {
        //define the array of JSON
        List<object> fruitsdata = new List<object>();
        fruitsdata.Add(new { text = "Date", id = "1" });
        fruitsdata.Add(new { text = "Fig", id = "2" });
        fruitsdata.Add(new { text = "Apple", id = "3" });
        fruitsdata.Add(new { text = "Apricot", id = "4" });
        fruitsdata.Add(new { text = "Grape", id = "5" });
        fruitsdata.Add(new { text = "Strawberry", id = "6" });
        fruitsdata.Add(new { text = "Pineapple", id = "7" });
        fruitsdata.Add(new { text = "Melon", id = "8" });
        fruitsdata.Add(new { text = "Lemon", id = "9" });
        fruitsdata.Add(new { text = "Cherry", id = "10" });
        ViewBag.fruitsdata = fruitsdata;
        return View();
    }
}