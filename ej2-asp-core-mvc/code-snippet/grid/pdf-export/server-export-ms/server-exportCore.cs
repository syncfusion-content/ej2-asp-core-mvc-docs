public IActionResult Index()
{
    ViewBag.DataSource = orddata;
    return View();
}

public object PdfExport([FromForm] string gridModel)
{
    GridPdfExport exp = new GridPdfExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    // pass thrid parameter as true to get the Memory Stream of exported grid data
    return (MemoryStream)exp.PdfExport<OrdersDetails>(gridProperty, orddata, true);
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