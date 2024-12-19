private List<string> headerValues = new List<string>();

public ActionResult Index()
{
    ViewBag.DataSource = OrdersDetails.GetAllRecords();
    return View();
}
public ActionResult ExcelExport(string gridModel)
{
    GridExcelExport excelExporter = new GridExcelExport();
    Grid gridProperties = ConvertGridObject(gridModel);
    gridProperties.ServerExcelHeaderQueryCellInfo = ExcelHeaderQueryCellInfo;
    var result = excelExporter.ExcelExport<dynamic>(gridProperties, OrdersDetails.GetAllRecords());
    return result;
}
private void ExcelHeaderQueryCellInfo(object excel)
{
    ServerExcelHeaderQueryCellInfoEventArgs name = (ServerExcelHeaderQueryCellInfoEventArgs)excel;
    headerValues.Add(name.Column.HeaderText);
    var longestHeaderText = headerValues.Where(s => s.Length == headerValues.Max(m => m.Length)).First();
    GridExcelExport excelExporter = new GridExcelExport();
    var size = excelExporter.ExcelTextSize(name.Style.Font.FontName, (float)name.Style.Font.Size, longestHeaderText);
    name.Cell.RowHeight = size.Width;
    excelExporter.HeaderCellRotate(name, 45); // Give the rotate degree value by the user.  
    name.Style.Borders.LineStyle = Syncfusion.XlsIO.ExcelLineStyle.None;
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

