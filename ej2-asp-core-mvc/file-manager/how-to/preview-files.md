---
layout: post
title: Previewing files in ##Platform_Name## File Manager control | Syncfusion
description: Learn how to preview files of DOCX, PDF, PPTX, and Excel files using ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: File Manager 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Previewing files in ##Platform_Name## File Manager component

This section will help you set up file previews in Syncfusion File Manager, perfect for applications where users need to view document contents without downloading them for various file types, including **DOCX**, **PDF**, **PPTX** and **Excel** files in Document Editor, PDF Viewer and Spreadsheet component. Follow the steps outlined below to integrate file preview functionality using appropriate viewers and conversion processes.

The below steps outline the process of previewing files in the File Manager component.

## Setting up the File Manager and provider

{% if page.publishingplatform == "aspnet-core" %}

To create a basic File Manager component, start by following the easy steps in the [`Getting Started`](https://ej2.syncfusion.com/aspnetcore/documentation/file-manager/getting-started) guide. This will allow you to manage files and folders on your system, whether they are stored physically or in the cloud.

{% elsif page.publishingplatform == "aspnet-mvc" %}

To create a basic File Manager component, start by following the easy steps in the [`Getting Started`](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/getting-started) guide. This will allow you to manage files and folders on your system, whether they are stored physically or in the cloud.

{% endif %}

For connecting the File Manager to a physical file system, check out the [`Physical file provider`](https://ej2.syncfusion.com/documentation/file-manager/file-system-provider#physical-file-system-provider) section. This part of the documentation will help you configure it correctly.

## Integrate Viewer components with File Manager

After setting the File Manager component with the physical file system provider, you can integrate the PDF Viewer, Document Editor, and Spreadsheet components to preview files. 

{% if page.publishingplatform == "aspnet-core" %}

* PDF Viewer : Setting up the PDF Viewer using the [`Getting Started`](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started) guide to preview PDF files with serviceUrl and addition of close button.

* Document Editor : Setting up the Document Editor using the [`Getting Started`](https://ej2.syncfusion.com/aspnetcore/documentation/document-editor/getting-started-core) guide to displays Word documents with the addition of close button.

* SpreadSheet : Setting up the SpreadSheet using the [`Getting Started`](https://ej2.syncfusion.com/aspnetcore/documentation/spreadsheet/getting-started-core) guide to displays Excel files with openUrl and the addition of close button.

The code snippet describes the integration of the above components with File Manager component.

```ts
<div class="file-container">
    <!-- Initialize FileManager -->
    <ejs-filemanager id="file" fileOpen="onFileOpen">
        <e-filemanager-ajaxsettings getImageUrl="http://localhost:{port}/api/FileManager/GetImage"
                                    url="http://localhost:{port}/api/FileManager/FileOperations"
                                    downloadUrl="http://localhost:{port}/api/FileManager/Download"
                                    uploadUrl="http://localhost:{port}/api/FileManager/Upload">
        </e-filemanager-ajaxsettings>
    </ejs-filemanager>
</div>
<div class="doc-container">
    <div class="title-container">
        <span class="doc-title title"></span> 
        <button onclick="onClicked()">close</button>
    </div>
    <!-- Initialize DocumentEditor-->
    <ejs-documenteditorcontainer id="container"></ejs-documenteditorcontainer>
</div>
<div class="pdf-container">
    <div class="title-container">
        <span class="pdf-title title"></span> 
        <button onclick='onClicked()'>close</button>
    </div>
    <!-- Initialize PDF Viewer-->
    <ejs-pdfviewer id="pdfViewer" style="height:600px" 
        serviceUrl="https://ej2services.syncfusion.com/production/web-services/api/pdfviewer">
    </ejs-pdfviewer>
</div>
<div class="excel-container">
    <div class="title-container">
        <span class="excel-title title"></span> 
        <button onclick='onClicked()'>close</button>
    </div>
    <!-- Initialize PDF Viewer-->
    <ejs-spreadsheet id="spreadsheet" 
        openUrl='http://localhost:{port}/api/FileManager/OpenExcel'>
    </ejs-spreadsheet>
</div>
```
{% elsif page.publishingplatform == "aspnet-mvc" %}

* PDF Viewer : Setting up the PDF Viewer using the [`Getting Started`](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) guide to preview PDF files with serviceUrl and addition of close button.

* Document Editor : Setting up the Document Editor using the [`Getting Started`](https://ej2.syncfusion.com/aspnetcore/documentation/document-editor/getting-started-mvc) guide to displays Word documents with the addition of close button.

* SpreadSheet : Setting up the SpreadSheet using the [`Getting Started`](https://ej2.syncfusion.com/aspnetmvc/documentation/spreadsheet/getting-started-mvc) guide to displays Excel files with openUrl and the addition of close button.

The code snippet describes the integration of the above components with File Manager component.

```ts
<div class="file-container">
    <!--  File Manager control declaration -->
    @Html.EJS().FileManager("file").AjaxSettings(new Syncfusion.EJ2.FileManager.FileManagerAjaxSettings
        {
            Url = "http://localhost:{port}/api/FileManager/FileOperations",
            GetImageUrl = "http://localhost:{port}/api/FileManager/GetImage",
            UploadUrl = "http://localhost:{port}/api/FileManager/Upload",
            DownloadUrl = "http://localhost:{port}/api/FileManager/Download"
        }).FileOpen("onFileOpen").Render()
    <!-- end of File Manager control -->
</div>
<div class="doc-container">
    <div class="title-container"><span class="doc-title title"></span> <button onclick="onClicked()">close</button></div>
    <!-- Initialize DocumentEditor-->
    @Html.EJS().DocumentEditor("container").Render()
</div>
<div class="pdf-container">
    <div class="title-container"><span class="pdf-title title"></span> <button onclick='onClicked()'>close</button></div>
    <!-- Initialize PDF Viewer-->
    @Html.EJS().PdfViewer("pdfViewer").ServiceUrl("https://ej2services.syncfusion.com/production/web-services/api/pdfviewer").Render()
</div>
<div class="excel-container">
    <div class="title-container"><span class="excel-title title"></span> <button onclick='onClicked()'>close</button></div>
    <!-- Initialize PDF Viewer-->
    @Html.EJS().Spreadsheet("spreadsheet").OpenUrl("http://localhost:{port}/api/FileManager/OpenExcel").Render()
</div>
```
{% endif %}

## Handling the fileOpen Event

After initializing the previewing components, you can use the [`fileOpen`](https://ej2.syncfusion.com/documentation/api/file-manager/#fileopen) event in Syncfusion File Manager to determine the file type and direct it to the correct viewer or conversion method. Here's how you can manage different file formats.

```ts
function onFileOpen(args) {
    let fileName = args.fileDetails.name;
    let filePath = args.fileDetails.filterPath.replace(/\\/g, "/") + fileName;
    let fileType = args.fileDetails.type;
    switch (fileType) {
        case ".docx":
        case ".txt":
        case ".html":
        case ".rtf":
        case ".xml":
            showDocViewer(fileName);
            getFileStream(filePath, false);
            break;

        case ".pdf":
            showPDFViewer(fileName);
            getFileStream(filePath, true);
            break;

        case ".csv":
            showExcelViewer(fileName);
            getBlob(filePath, fileName, fileType);
            break;

        case ".pptx":
            showPDFViewer(fileName);
            convertPptToPdf(filePath, fileName);
            break;

        default:
            console.log("Unsupported file type");
            break;
    }
}
```

## Previewing PPTX files

Since PPTX files cannot be viewed directly, they need to be converted to PDF and then viewed in the PdfViewer component. For PPTX files, use the below method to convert the file to a PDF format for previewing.

```ts
    function convertPptToPdf(filePath, fileName) {
        fetch('http://localhost:{port}/api/FileManager/ConvertPptToPdf', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ FilePath: filePath }), // Send file path to backend
        })
            .then((response) => {
                if (!response.ok) {
                    throw new Error('Failed to convert PPT to PDF');
                }
                return response.blob(); // Get the PDF blob
            })
            .then((blob) => {
                var pdfviewer = (document.getElementById('pdfViewer')).ej2_instances[0];
                const pdfUrl = URL.createObjectURL(blob); // Create a URL for the PDF blob
                showPDFViewer(fileName);
                pdfviewer.load(pdfUrl, '');
            })
            .catch((error) => {
                console.error('Error converting PPT to PDF:', error);
            });
    }

```

The code snippet defines that the `ConvertPptToPdf` method in `FileManagerController.cs` file to facilitate the conversion of PPT file to PDF file for previewing.

```ts
[HttpPost]
[Route("ConvertPptToPdf")]
public IActionResult ConvertPptToPdf([FromBody] FileRequest fileRequest)
{
    if (fileRequest == null || string.IsNullOrEmpty(fileRequest.FilePath))
    {
        return BadRequest("Invalid file path. Please provide a valid file path.");
    }
    string filePath = this.basePath + "\\wwwroot\\Files" + (fileRequest.FilePath).Replace("/", "\\");

    if (!System.IO.File.Exists(filePath) || Path.GetExtension(filePath).ToLower() != ".pptx")
    {
        return BadRequest("Invalid file. Please ensure the file exists and is a PPTX file.");
    }

    try
    {
        using (FileStream pptStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            // Load the presentation from the file stream
            using (IPresentation presentation = Presentation.Open(pptStream))
            {
                // Convert the presentation to PDF
                using (PdfDocument pdfDocument = PresentationToPdfConverter.Convert(presentation))
                {
                    // Save the PDF to a memory stream
                    using (MemoryStream pdfStream = new MemoryStream())
                    {
                        pdfDocument.Save(pdfStream);
                        pdfStream.Position = 0;

                        // Return the PDF file as a response
                        return File(pdfStream.ToArray(), "application/pdf", "ConvertedPresentation.pdf");
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        return StatusCode(500, $"Error converting PPT to PDF: {ex.Message}");
    }
}
// Create a model to capture the file path from the request
public class FileRequest
{
    public string FilePath { get; set; }
}
```
## Previewing PDF and document files

Determine whether the file is a PDF or another document type and retrieve the relevant file stream.

```ts
function getFileStream(filePath, isPDF) {
    let ajax = new XMLHttpRequest();
    ajax.open("POST", 'http://localhost:{port}/' + "api/FileManager/GetDocument", true);
    ajax.setRequestHeader("content-type", "application/json");
    ajax.onreadystatechange = () => {
        if (ajax.readyState === 4) {
            if (ajax.status === 200 || ajax.status === 304) {
                if (!isPDF) {
                    var container = (document.getElementById('container')).ej2_instances[0];
                    container.documentEditor.open(ajax.responseText);
                } else {
                    var pdfviewer = (document.getElementById('pdfViewer')).ej2_instances[0];
                    pdfviewer.load(ajax.responseText, null);
                }
            }
        }
    };
    ajax.send(JSON.stringify({ "FileName": filePath, "Action": (!isPDF ? "ImportFile" : "LoadPDF") }));
}
```
### Fetch and open Document and PDF file

By constructing a file path using the **FileName** parameter, it decides if the action involves loading a PDF or a different document type. For PDF files, the method reads and converts the file's byte contents into a Base64-encoded string prefixed with the appropriate MIME type, whereas for Word documents, it attempts to open and load the document into a WordDocument object (determining the format based on the file's extension), serialize the document to a JSON format, then release resources before returning the JSON string.

```ts

[Route("GetDocument")]
public string GetDocument([FromBody] CustomParams param)
{
    string path = this.basePath + "\\wwwroot\\Files" + (param.FileName).Replace("/", "\\");
    if (param.Action == "LoadPDF")
    {
        //for PDF Files
        var docBytes = System.IO.File.ReadAllBytes(path);
        //we can convert the document stream to bytes then convert to base64
        string docBase64 = "data:application/pdf;base64," + Convert.ToBase64String(docBytes);
        return (docBase64);
    }
    else
    {
        //for Doc Files
        try
        {
            Stream stream = System.IO.File.Open(path, FileMode.Open, FileAccess.ReadWrite);
            int index = param.FileName.LastIndexOf('.');
            string type = index > -1 && index < param.FileName.Length - 1 ?
                param.FileName.Substring(index) : ".docx";
            WordDocument document = WordDocument.Load(stream, GetFormatType(type.ToLower()));
            string json = JsonConvert.SerializeObject(document);
            document.Dispose();
            stream.Dispose();
            return json;
        }
        catch
        {
            return "Failure";
        }
    }
}
```

To load the different types of documents, add the below code in server-side:

```ts
internal static FormatType GetFormatType(string format)
{
    if (string.IsNullOrEmpty(format))
    {
        throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
    }

    switch (format.ToLower())
    {
        case ".dotx":
        case ".docx":
        case ".docm":
        case ".dotm":
            return FormatType.Docx;
        case ".dot":
        case ".doc":
            return FormatType.Doc;
        case ".rtf":
            return FormatType.Rtf;
        case ".txt":
            return FormatType.Txt;
        case ".xml":
            return FormatType.WordML;
        case ".html":
            return FormatType.Html;
        default:
            throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
    }
}
```

## Previewing Excel Files

Use the **getBlob** method to open Excel files by requesting the file as a blob and loading it into the SpreadSheet component.

```ts
function getBlob(filePath, fileName, fileType) {
    var spreadsheet = (document.getElementById('spreadsheet')).ej2_instances[0];
    let request = new XMLHttpRequest();
    request.responseType = 'blob';
    request.onload = () => {
        let file = new File([request.response], fileName);
        spreadsheet.open({ file: file });
    };
    request.open(
        'GET',
        'http://localhost:{port}/' + 'api/FileManager/GetExcel' + '?FileName=' + filePath
    );
    request.send();
}  
```

### Fetch and open Excel Files

The **GetExcel** method handles requests to retrieve an Excel file from the server. It constructs the full file path using the base path and the file name from the CustomParams object, opens the file with read access using a FileStream, and returns the file as a FileStreamResult with a content type of "APPLICATION/octet-stream", allowing the client to download the file.

The **OpenExcel** method is designed to process an Excel workbook from a form collection received in the request. The method then opens the workbook using Workbook.Open(open), processes the file, and returns the result as content. This setup aids in downloading Excel files from the server and opening Excel workbooks for further processing.

```ts

[Route("GetExcel")]
public IActionResult GetExcel(CustomParams param)
{
    string fullPath = this.basePath + "\\wwwroot\\Files" + (param.FileName).Replace("/", "\\");
    FileStream fileStreamInput = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
    FileStreamResult fileStreamResult = new FileStreamResult(fileStreamInput, "APPLICATION/octet-stream");
    return fileStreamResult;
}

[Route("OpenExcel")]
public IActionResult Open(IFormCollection openRequest)
{
    ExcelEngine excelEngine = new ExcelEngine();
    Stream memStream = (openRequest.Files[0] as IFormFile).OpenReadStream();
    IFormFile formFile = new FormFile(memStream, 0, memStream.Length, "", openRequest.Files[0].FileName); // converting MemoryStream to IFormFile
    OpenRequest open = new OpenRequest();
    open.File = formFile;
    var result = Workbook.Open(open);
    memStream.Close();
    return Content(result);
}

```

> **Note:** The complete [code example](https://github.com/SyncfusionExamples/How-to-preview-files-in-file-manager) along with service.
