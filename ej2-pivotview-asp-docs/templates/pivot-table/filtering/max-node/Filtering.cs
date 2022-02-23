public ActionResult Index()
{
    var data = GetProductData();
    ViewBag.DataSource = data;
    ViewBag.filterMembers = new string[] { "United States" };
    return View();
}
public class ProductDetails
{
    public string ProductID { get; set; }
    public int Sold { get; set; }
    public DateTime DeliveryDate { get; set; }

}
public static List<ProductDetails> GetProductData()
{
    List<ProductDetails> productData = new List<ProductDetails>();
    for (int i = 0; i < 5000; i++)
    {
        int RandomNumber = new Random().Next(1, 10);
        productData.Add(new ProductDetails { Sold = RandomNumber, ProductID = "PRO-" + (i + 1001), DeliveryDate = new DateTime(2019, 1, 1).AddDays(RandomNumber) });
    }
    return productData;
}