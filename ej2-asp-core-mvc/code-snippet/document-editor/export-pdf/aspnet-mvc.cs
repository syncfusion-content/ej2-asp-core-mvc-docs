using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Pdf;
using Syncfusion.DocToPDFConverter;

[HttpPost]
public void ExportPdf([FromBody] SaveParameter data)
{
    // Converts the sfdt to stream
    Stream document = WordDocument.Save(data.Content, Syncfusion.EJ2.DocumentEditor.FormatType.Docx);
    Syncfusion.DocIO.DLS.WordDocument doc = new Syncfusion.DocIO.DLS.WordDocument(document, Syncfusion.DocIO.FormatType.Docx);
    //Instantiation of DocIORenderer for Word to PDF conversion
    DocToPDFConverter render = new DocToPDFConverter();
    //Converts Word document into PDF document
    PdfDocument pdfDocument = render.ConvertToPDF(doc);
    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "sample.pdf");
    // Saves the document to server machine file system, you can customize here to save into databases or file servers based on requirement.
    FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    //Saves the PDF file
    pdfDocument.Save(fileStream);
    pdfDocument.Close();
    fileStream.Close();
    document.Close();
}