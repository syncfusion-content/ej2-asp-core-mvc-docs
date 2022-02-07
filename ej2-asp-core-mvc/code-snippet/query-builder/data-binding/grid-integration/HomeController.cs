public class HomeController : Controller
{
    private NORTHWNDContext _context;
    public HomeController(NORTHWNDContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    private IQueryable<Records> GetDataSource()
    {
        IQueryable<Records> transactions = _context.Records;

        return transactions;
    }

    public IActionResult UrlDatasource([FromBody] DataManagerRequest dm)
    {
        IQueryable<Records> DataSource = GetDataSource();
        QueryableOperation operation = new QueryableOperation();
        if (dm.Where != null && dm.Where.Count > 0) //Filtering
        {
            DataSource = operation.PerformFiltering(DataSource, dm.Where, dm.Where[0].Condition);  //filtering
        }
        if (dm.Search != null && dm.Search.Count > 0)
        {
            DataSource = operation.PerformSearching(DataSource, dm.Search);  //Search
        }
        int count = DataSource.Cast<Records>().Count();
        if (dm.Skip != 0)
        {
            DataSource = operation.PerformSkip(DataSource, dm.Skip);
        }
        if (dm.Take != 0)
        {
            DataSource = operation.PerformTake(DataSource, dm.Take);
        }
        return dm.RequiresCounts ? Json(new { result = DataSource, count = count }) : Json(DataSource);
    }
}
