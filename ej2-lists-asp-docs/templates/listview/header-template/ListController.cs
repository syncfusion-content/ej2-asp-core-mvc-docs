public class ListViewController : Controller
{
    public IActionResult List()
    {
        //define the array of JSON
        List<object> fruitsdata = new List<object>();
        fruitsdata.Add(new { text = "Date", id = "1", imgUrl = "./dates.jpg" });
        fruitsdata.Add(new { text = "Fig", id = "2", imgUrl = "./fig.jpg" });
        fruitsdata.Add(new { text = "Apple", id = "3", imgUrl = "./apple.png" });
        fruitsdata.Add(new { text = "Apricot", id = "4", imgUrl = "./apricot.jpg" });
        fruitsdata.Add(new { text = "Grape", id = "5", imgUrl = "./grape.jpg" });
        fruitsdata.Add(new { text = "Strawberry", id = "6", imgUrl = "./strawberry.jpg" });
        fruitsdata.Add(new { text = "Pineapple", id = "7", imgUrl = "./pineapple.jpg" });
        fruitsdata.Add(new { text = "Melon", id = "8", imgUrl = "./melon.jpg" });
        fruitsdata.Add(new { text = "Lemon", id = "9", imgUrl = "./lemon.jpg" });
        fruitsdata.Add(new { text = "Cherry", id = "10", imgUrl = "./cherry.jpg" });
        ViewBag.fruitsdata = fruitsdata;
        return View();
    }
}