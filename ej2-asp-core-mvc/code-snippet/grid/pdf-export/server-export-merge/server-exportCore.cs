using Syncfusion.Pdf;

public IActionResult Index()
{
    ViewBag.DataSource = orddata;
    return View();
}

public ActionResult PdfExport([FromForm] string gridModel)
{
    GridPdfExport exp = new GridPdfExport();
    Grid gridProperty = ConvertGridObject(gridModel);
    // get the memory stream of exported grid data
    MemoryStream ms1 = (MemoryStream)exp.PdfExport<OrdersDetails>(gridProperty, orddata, true);
    // use existing pdf memory stream (or) convert the existing pdf file into stream
    FileStream ms2 = new FileStream("PdfDoc.pdf", FileMode.Open, FileAccess.Read);

    //Creates a PDF document.
    PdfDocument finalDoc = new PdfDocument();

    //Creates a PDF stream for merging. ms1 and ms2 represents the memory streams needs to merge.
    Stream[] streams = { ms1, ms2 };
    //Merges PDFDocument.
    PdfDocumentBase.Merge(finalDoc, streams);
    //Save the document into stream.
    MemoryStream ms3 = new MemoryStream();
    finalDoc.Save(ms3);    
    ms3.Position = 0;
    // Save the MemoryStream into FileStreamResult
    FileStreamResult fileStreamResult = new FileStreamResult(ms3, "application/pdf");
    fileStreamResult.FileDownloadName = "Export.pdf";
    //Close the document.
    finalDoc.Close(true);
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