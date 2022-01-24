---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Import of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Import
publishingplatform: ##Platform_Name##
documentation: ug
---


# Import

In Document Editor, the documents are stored in its own format called **Syncfusion Document Text (SFDT)**.

The following example shows how to open SFDT data in Document Editor.

{% aspTab template="document-editor/import", sourceFiles="document-editor.cs" %}

{% endaspTab %}

## Import document from local machine

The following example shows how to import document from local machine.

{% aspTab template="document-editor/import-sfdt", sourceFiles="document-editor.cs" %}

{% endaspTab %}

## Convert word documents into SFDT

You can convert word documents into SFDT format using the [`Syncfusion.EJ2.WordEditor.AspNet.MVC4`](<https://www.nuget.org/packages/Syncfusion.EJ2.WordEditor.AspNet.MVC4//>) or [`Syncfusion.EJ2.WordEditor.AspNet.MVC5`](<https://www.nuget.org/packages/Syncfusion.EJ2.WordEditor.AspNet.MVC5/>) by the web API service implementation. This library helps you to convert word documents (.dotx,.docx,.docm,.dot,.doc), rich text format documents (.rtf), and text documents (.txt) into SFDT format. Refer to the following example.

{% aspTab template="document-editor/import-docx", sourceFiles="document-editor.cs" %}

{% endaspTab %}

Here’s how to handle the server-side action for converting word document in to SFDT.

```csharp
[HttpPost]
public HttpResponseMessage Import()
{
    if (HttpContext.Current.Request.Files.Count == 0)
    return null;

    HttpPostedFile file = HttpContext.Current.Request.Files[0];
    int index = file.FileName.LastIndexOf('.');
    string type = index > -1 && index < file.FileName.Length - 1 ?
    file.FileName.Substring(index) : ".docx";
    Stream stream = file.InputStream;
    stream.Position = 0;

    EJ2WordDocument document = EJ2WordDocument.Load(stream, GetFormatType(type.ToLower()));
    string json = Newtonsoft.Json.JsonConvert.SerializeObject(document);
    document.Dispose();
    stream.Close();
    return new HttpResponseMessage() { Content = new StringContent(json) };
}

internal static FormatType GetFormatType(string format)
{
    if (string.IsNullOrEmpty(format))
        throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
    switch (format.ToLower()) {
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
        default:
            throw new NotSupportedException("EJ2 DocumentEditor does not support this file format.");
    }
}

```

## See Also

* [Feature modules](../../document-editor/feature-module/)
