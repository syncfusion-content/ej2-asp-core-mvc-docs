public ActionResult Index()
{
    var Order = OrdersDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
}

public object PdfExport(string gridModel)
{
    GridPdfExport exp = new GridPdfExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    // pass thrid parameter as true to get the Memory Stream of exported grid data
    return (MemoryStream)exp.PdfExport<OrdersDetails>(gridProperty, OrdersDetails.GetAllRecords(), true);
}

private Grid ConvertGridObject(string gridProperty)
{
    Grid GridModel = (Grid)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(Grid));
    GridColumnModel cols = (GridColumnModel)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(GridColumnModel));
    GridModel.Columns = cols.columns;
    return GridModel;
}

public class GridColumnModel
{
    public List<GridColumn> columns { get; set; }
}