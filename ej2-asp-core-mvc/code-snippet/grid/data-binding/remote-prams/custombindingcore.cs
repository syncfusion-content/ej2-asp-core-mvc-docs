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
}