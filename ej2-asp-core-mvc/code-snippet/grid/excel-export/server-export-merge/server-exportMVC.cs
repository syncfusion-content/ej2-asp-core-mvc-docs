using Syncfusion.XlsIO;

public ActionResult Index()
{
    var Order = OrdersDetails.GetAllRecords();
    ViewBag.DataSource = Order;
    return View();
}
public ActionResult ExcelExport(string gridModel)
{
    GridExcelExport exp = new GridExcelExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    // get the memory stream of exported grid data
    MemoryStream ms1 = (MemoryStream)exp.ExcelExport<OrdersDetails>(gridProperty, orddata, true);

    // use existing xlsx memory stream (or) convert the existing xlsx file into stream
    FileStream ms2 = new FileStream("ExcelDoc.xlsx", FileMode.Open, FileAccess.Read);

    //New instance of ExcelEngine is created equivalent to launching Microsoft Excel with no workbooks open
    ExcelEngine excelEngine = new ExcelEngine();
    //Instantiate the Excel application object
    IApplication application = excelEngine.Excel;
    //Assigns default application version
    application.DefaultVersion = ExcelVersion.Xlsx;
    //Loads or open an existing workbook through Open method of IWorkbooks
    IWorkbook sourceWorkbook = application.Workbooks.Open(ms1);
    IWorkbook destinationWorkbook = application.Workbooks.Open(ms2);

    //Copy all the worksheet from the Source workbook to the destination workbook
    for (int i = 0; i < sourceWorkbook.Worksheets.Count; i++)
    {
        destinationWorkbook.Worksheets.AddCopy(sourceWorkbook.Worksheets[i]);
    }
    destinationWorkbook.ActiveSheetIndex = 1;
    //Saving the workbook as stream
    MemoryStream ms3 = new MemoryStream();
    destinationWorkbook.SaveAs(ms3);
    ms3.Position = 0;
    // Save the MemoryStream into FileStreamResult
    FileStreamResult fileStreamResult = new FileStreamResult(ms3, "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

    fileStreamResult.FileDownloadName = "Export.xlsx";
    //Dispose the instance of ExcelEngine
    excelEngine.Dispose();
    //Disposes the streams.
    ms1.Dispose();
    ms2.Dispose();
    // return the file
    return fileStreamResult;
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