public ActionResult Index()
{
    ViewBag.dataSource = OrdersDetails.GetAllRecords();
    return View();
}
public ActionResult ExcelExport(string gridModel)
{
    GridExcelExport excelExporter = new GridExcelExport();
    Grid gridProperties = ConvertGridObject(gridModel);
    return excelExporter.ExcelExport<OrdersDetails>(gridProperties, OrdersDetails.GetAllRecords());
}
private Grid ConvertGridObject(string gridProperty)
{
    Grid GridModel = (Grid)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(Grid));
    GridColumnModel gridColumns = (GridColumnModel)Newtonsoft.Json.JsonConvert.DeserializeObject(gridProperty, typeof(GridColumnModel));
    GridModel.Columns = gridColumns.columns;
    return GridModel;
}

public class GridColumnModel
{
    public List<GridColumn> columns { get; set; }
}