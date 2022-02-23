public ActionResult Insert(CRUDModel Object)
{
    var ord = Object.Value;
    OrdersDetails.GetAllRecords().Insert(0, ord);
    return Json(Object.Value);
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