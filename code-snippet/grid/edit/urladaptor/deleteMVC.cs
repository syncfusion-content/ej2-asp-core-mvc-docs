public ActionResult Delete(int key)
{
    var orddata = OrdersDetails.GetAllRecords();
    orddata.Remove(orddata.Where(or => or.OrderID == key).FirstOrDefault());
    return Json(new { result = orddata, count = orddata.Count });
}

public class CRUDModel
{
    public List<OrdersDetails> Added { get; set; }

    public List<OrdersDetails> Changed { get; set; }

    public List<OrdersDetails> Deleted { get; set; }

    public OrdersDetails Value { get; set; }

    public int key { get; set; }
    
    public string action { get; set; }
}
