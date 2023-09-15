public IActionResult PdfExport(string treeGridModel)
{
    if (treeGridModel == null)
    {
        return View();
    }
    TreeGridPdfExport exp = new TreeGridPdfExport();
    TreeGrid gridProperty = ConvertTreeGridObject(treeGridModel);
    gridProperty.PdfHeaderCellRendering = PdfHeaderQueryCellInfo;
    PdfGrid grid = new PdfGrid();
    Syncfusion.EJ2.TreeGridExport.PdfExportProperties pdfExportProperties = new Syncfusion.EJ2.TreeGridExport.PdfExportProperties();
    pdfExportProperties.IsRepeatHeader = true;
    exp.BeginCellLayout = new PdfGridBeginCellLayoutEventHandler(BeginCellEvent);
    System.Collections.IEnumerable data = Syncfusion.EJ2.Base.Dat.DataTableToJson(ViewBag.dataSource);
    var result = exp.PdfExport<dynamic>(gridProperty, data, pdfExportProperties);
    return View();
}

public void BeginCellEvent(object sender, PdfGridBeginCellLayoutEventArgs args)
{
    PdfGrid grid = (PdfGrid)sender;
    var brush = new PdfSolidBrush(new PdfColor(Color.DimGray));
    args.Graphics.Save();
    args.Graphics.TranslateTransform(args.Bounds.X + 50, args.Bounds.Height + 40); // give the value for bounds x and Y by the user
    args.Graphics.RotateTransform(-60);   // give the rotate degree value by the user
                                          // Draw the text at particular bounds.
    args.Graphics.DrawString(headerValues[args.CellIndex], new PdfStandardFont(PdfFontFamily.Helvetica, 10), brush, new PointF(0, 0));
    if (args.IsHeaderRow)
    {
        grid.Headers[0].Cells[args.CellIndex].Value = string.Empty;
    }
    args.Graphics.Restore();
}

private void PdfHeaderQueryCellInfo(object pdf)
{
    Syncfusion.EJ2.TreeGridExport.PdfHeaderCellEventArgs name = (Syncfusion.EJ2.TreeGridExport.PdfHeaderCellEventArgs)pdf;
    PdfGrid grid = new PdfGrid();
    headerValues.Add(name.Column.HeaderText);
    var longestString = headerValues.Where(s => s.Length == headerValues.Max(m => m.Length)).First();
    PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 6);
    SizeF size = font.MeasureString(longestString);
    name.Headers[0].Height = size.Width * 2;
}
