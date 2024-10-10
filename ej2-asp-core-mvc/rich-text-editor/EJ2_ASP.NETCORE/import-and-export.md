---
layout: post
title: Import/Export in ##Platform_Name## Rich Text Editor Component | Syncfusion
description: Learn here all about Import/Export in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Import/Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Import/Export in ##Platform_Name## Rich Text Editor component

## Import from Microsoft Word

The Rich Text Editor allows you to import content from Word documents, preserving the original formatting and structure, including headings, lists, tables, and text styles. This ensures that documents are accurately represented within the editor for seamless editing and enhancement

To integrate an `ImportWord` option into the Rich Text Editor toolbar using the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

To enable the `ImportWord` functionality, the `ServiceUrl` property must be correctly configured within the `ImportWord`. This API endpoint facilitates the file upload process and manages the server-side conversion of the document.

The following code block provides a detailed explanation of the API endpoint used for the import functionality:

```csharp

    public IActionResult ImportFromWord(IList<IFormFile> UploadFiles)
        {
            string HtmlString = string.Empty;
            if (UploadFiles != null)
            {
                foreach (var file in UploadFiles)
                {
                    string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    filename = _webHostEnvironment.WebRootPath + $@"\{filename}";
                    using (FileStream fs = System.IO.File.Create(filename))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }
                    using (var mStream = new MemoryStream())
                    {
                        new WordDocument(file.OpenReadStream(), FormatType.Rtf).Save(mStream, FormatType.Html);
                        mStream.Position = 0;
                        HtmlString = new StreamReader(mStream).ReadToEnd();
                    };
                    HtmlString = ExtractBodyContent(HtmlString);
                    HtmlString = SanitizeHtml(HtmlString);
                    System.IO.File.Delete(filename);
                }
                return Ok(HtmlString);
            }
            else
            {
                Response.Clear();
                // Return an appropriate status code or message
                return BadRequest("No files were uploaded.");
            }
        }

        private string ExtractBodyContent(string html)
        {
            if (html.Contains("<html") && html.Contains("<body"))
            {
                return html.Remove(0, html.IndexOf("<body>") + 6).Replace("</body></html>", "");
            }
            return html;
        }

        private string SanitizeHtml(string html)
        {
            // Remove or replace non-ASCII or control characters
            // For example, you can use regular expressions to replace them with spaces
            // Regex pattern to match non-ASCII or control characters: [^\x20-\x7E]
            return Regex.Replace(html, @"[^\x20-\x7E]", " ");
        }


```

The `ImportWord` functionality is integrated within the `ActionBegin` and `ActionComplete` events. If the cancel property is set to true in the `ActionBegin` event argument, the execution of the `ImportWord` functionality can be prevented.

The following example illustrates how to set up the `ImportWord` in the Rich Text Editor to facilitate content importation from Word documents:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/import/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/import/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/import/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/import/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Export to PDF / Microsoft Word

The Rich Text Editor's export functionality allows users to convert their edited content into PDF or Word documents with a single click, preserving all text styles, images, tables, and other formatting elements.

You can add `ExportWord` and `ExportPdf` tools to the Rich Text Editor toolbar using the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

To enable the `ExportWord` and `ExportPdf` functionality, the `ServiceUrl` property must be correctly configured within the `ExportWordModel` and `ExportPdfModel`. These API endpoints handle the export process and manage the server-side generation of Word and PDF files, respectively.

The following code block provides a detailed explanation of the API endpoint used for the content export functionality:

```csharp

    public class ExportParam
        {
            public string html { get; set; }
        }

        [AcceptVerbs("Post")]
        [EnableCors("AllowAllOrigins")]
        [Route("ExportToPdf")]
        public ActionResult ExportToPdf([FromBody] ExportParam args)
        {
            string htmlString = args.html;
            if (htmlString == null && htmlString == "")
            {
                return null;
            }
            using (WordDocument wordDocument = new WordDocument())
            {
                //This method adds a section and a paragraph in the document
                wordDocument.EnsureMinimal();
                wordDocument.HTMLImportSettings.ImageNodeVisited += OpenImage;
                //Append the HTML string to the paragraph.
                wordDocument.LastParagraph.AppendHTML(htmlString);
                DocIORenderer render = new DocIORenderer();
                //Converts Word document into PDF document
                PdfDocument pdfDocument = render.ConvertToPDF(wordDocument);
                wordDocument.HTMLImportSettings.ImageNodeVisited -= OpenImage;
                MemoryStream stream = new MemoryStream();
                pdfDocument.Save(stream);
                return File(stream.ToArray(), System.Net.Mime.MediaTypeNames.Application.Pdf, "Sample.pdf");
            }
        }

        [AcceptVerbs("Post")]
        [EnableCors("AllowAllOrigins")]
        [Route("ExportToDocx")]
        public FileStreamResult ExportToDocx([FromBody] ExportParam args)
        {
            string htmlString = args.html;
            if (htmlString == null && htmlString == "")
            {
                return null;
            }
            using (WordDocument document = new WordDocument())
            {
                document.EnsureMinimal();
                //Hooks the ImageNodeVisited event to open the image from a specific location
                document.HTMLImportSettings.ImageNodeVisited += OpenImage;
                //Validates the Html string
                bool isValidHtml = document.LastSection.Body.IsValidXHTML(htmlString, XHTMLValidationType.None);
                //When the Html string passes validation, it is inserted to the document
                if (isValidHtml)
                {
                    //Appends the Html string to first paragraph in the document
                    document.Sections[0].Body.Paragraphs[0].AppendHTML(htmlString);
                }
                //Unhooks the ImageNodeVisited event after loading HTML
                document.HTMLImportSettings.ImageNodeVisited -= OpenImage;
                //Creates file stream.
                MemoryStream stream = new MemoryStream();
                document.Save(stream, FormatType.Docx);
                stream.Position = 0;
                //Download Word document in the browser
                return File(stream, "application/msword", "Result.docx");
            }
        }

```

The `FileName` and `Stylesheet` properties within the `ExportWord` and `ExportPdf` allow for the customization of file names and stylesheets for the exported documents, respectively.

The `ExportWord` and `ExportPdf` functionality is integrated within the `ActionBegin` and `ActionComplete` events. If the cancel property is set to true in the `ActionBegin` event argument, the execution of the `ExportWord` and `ExportPdf` functionality can be prevented.

The `ActionBegin` event argument includes an `ExportValue` property, which contains the content to be exported. This content can be modified by configuring the `ActionBegin` event.

The following example demonstrates how to configure the `ExportWord` and `ExportPdf` tools in the Rich Text Editor, facilitating the export of content into Word or PDF documents:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/export/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/export/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}