public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public JsonResult OnPostGetOrderData()
    {
        IEnumerable<OrdersDetails> dataSource = OrdersDetails.GetAllRecords();
        int totalCount = dataSource.Count();
        return new JsonResult(new { result = dataSource, count = totalCount });
    }
    public JsonResult OnPostAddOrder([FromBody] OrdersDetails orders)
    {
        OrdersDetails.GetAllRecords().Insert(0, orders); 
        return new JsonResult(new { result = orders });
    }
    public JsonResult OnPostUpdateOrder(int OrderID, [FromBody] OrdersDetails value)
    {
        var ord = value;
        OrdersDetails val = OrdersDetails.GetAllRecords().Where(or => or.OrderID == ord.OrderID).FirstOrDefault();
        val.OrderID = ord.OrderID;
        val.CustomerName = ord.CustomerName;
        val.ProductID = ord.ProductID;
        val.ProductName = ord.ProductName;
        return new JsonResult(new { result = value })
    }
    public JsonResult OnPostDeleteOrder(int id)
    {
        OrdersDetails.GetAllRecords().Remove(OrdersDetails.GetAllRecords().Where(or => or.OrderID == id).FirstOrDefault());
        var data = OrdersDetails.GetAllRecords();
        return new JsonResult(new { result = data });
    }
}