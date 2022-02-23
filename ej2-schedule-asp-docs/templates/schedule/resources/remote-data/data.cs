public ActionResult Index()
{
    string[] resources = new string[] { "Owners" };
    ViewBag.Resources = resources;
    return View();
}

public JsonResult GetResourceData()
{
    List<OwnerRes> owners = new List<OwnerRes>();
    owners.Add(new OwnerRes { text = "Nancy", id = 1, color = "#ffaa00" });
    owners.Add(new OwnerRes { text = "Steven", id = 2, color = "#f8a398" });
    owners.Add(new OwnerRes { text = "Michael", id = 3, color = "#7499e1" });
    return Json(owners);
}
public class OwnerRes
{
    public string text { set; get; }
    public int id { set; get; }
    public string color { set; get; }
}