public class ListViewController : Controller
{
    public IActionResult List()
    {
        ViewBag.dataSource = new string[] { "Artwork", "Abstract", "Modern Painting", "Ceramics", "Animation Art", "Oil Painting" };
        return View();
    }
}