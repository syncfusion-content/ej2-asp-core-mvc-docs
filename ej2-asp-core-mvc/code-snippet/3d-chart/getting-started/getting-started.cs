public IActionResult Index()
{
    List<Data> data = new List<Data>
    {
        new Data { X= "Tesla", Y= 137429 },
        new Data { X= "Aion",  Y= 80308  }
    };
    ViewBag.dataSource = data;
    return View();
}
public class Data
{
    public string X;
    public double Y;
}