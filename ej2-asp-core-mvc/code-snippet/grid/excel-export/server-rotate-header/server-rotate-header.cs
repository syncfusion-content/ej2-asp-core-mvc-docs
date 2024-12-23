public ActionResult ExcelExport(string gridModel)
{
    GridExcelExport excelExporter = new GridExcelExport();
    Grid gridProperties = ConvertGridObject(gridModel);
    gridProperties.ServerExcelHeaderQueryCellInfo = ExcelHeaderQueryCellInfo;
    IEnumerable data = Utils.DataTableToJson(ordersDataTable);
    var result = exp.ExcelExport<dynamic>(gridProperty, data);
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