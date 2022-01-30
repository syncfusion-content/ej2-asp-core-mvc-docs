public ActionResult Delete([FromBody]ICRUDModel<OrdersDetails> value)
{
    OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == int.Parse(value.key.ToString())).FirstOrDefault());
    return Json(value);
}

public class ICRUDModel<T> where T : class
{
    public string action { get; set; }

    public string table { get; set; }

    public string keyColumn { get; set; }

    public object key { get; set; }

    public T value { get; set; }

    public List<T> added { get; set; }

    public List<T> changed { get; set; }

    public List<T> deleted { get; set; }

    public IDictionary<string, object> @params { get; set; }
}
