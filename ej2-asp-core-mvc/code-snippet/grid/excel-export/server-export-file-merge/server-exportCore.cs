using Syncfusion.XlsIO;

// get the file stream of local file.
public FileStream fs1 = new FileStream("D:/ExcelDoc.xlsx", FileMode.Open, FileAccess.Read); // ExcelDoc.xlsx is a local file which is located in local disk D.

public IActionResult Index()
{
    ViewBag.DataSource = orddata;
    return View();
}

public object ExcelExport([FromForm] string gridModel)
{
    GridExcelExport exp = new GridExcelExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    MemoryStream ms1 = (MemoryStream)exp.ExcelExport<OrdersDetails>(gridProperty, orddata, true);
    ExcelEngine excelEngine = new ExcelEngine();
    IApplication application = excelEngine.Excel;
    application.DefaultVersion = ExcelVersion.Xlsx;
    //fs1 and ms1 represents the local file's stream and Grid's stream.
    IWorkbook sourceWorkbook = application.Workbooks.Open(fs1);
    IWorkbook destinationWorkbook = application.Workbooks.Open(ms1);
    for (int i = 0; i < sourceWorkbook.Worksheets.Count; i++)
    {
        destinationWorkbook.Worksheets.AddCopy(sourceWorkbook.Worksheets[i]);
    }
    destinationWorkbook.ActiveSheetIndex = 1;
    MemoryStream ms3 = new MemoryStream();
    destinationWorkbook.SaveAs(ms3);
    ms3.Position = 0;
    return ms3;
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