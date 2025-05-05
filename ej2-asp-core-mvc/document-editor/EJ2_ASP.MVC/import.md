---
layout: post
title: Import in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about Import in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Import
publishingplatform: ##Platform_Name##
documentation: ug
---


# Importing in the ##Platform_Name## Document Editor Component

In Document Editor, the documents are stored in its own format called **Syncfusion Document Text (SFDT)**.

> The **Syncfusion Document Text** (SFDT) format is only used for Syncfusion. The JSON SFDT structure is used in the Document Editor and has a predefined set of keys. Any customization data provided in the SFDT will not be recognized by the Document Editor. So, we strongly advise against making modifications to the SFDT string, as such alterations can lead to scripting issues during the document processing phase.

> If you want to know more about the structure of our SFDT, you can implement various elements in the document and save it in the SFDT format by setting the optimizeSFDT property to false. You can access the optimizeSFDT property as given below: **"documentEditor.documentEditorSettings.optimizeSfdt = false"**.
So, while rendering the elements, the Document Editor will read the values based on the predefined keys in SFDT format, and the values of the unrecognized keys will be ignored. The SFDT structure we use in our document editor is mostly similar to the Docx XML specifications of MS Word.

To know about optimize-sfdt, please refer this [page](../document-editor/how-to/optimize-sfdt).

The following example shows how to open SFDT data in Document Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Import document from local machine

The following example shows how to import document from local machine.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-sfdt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-sfdt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-sfdt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-sfdt/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Convert word documents into SFDT

You can convert word documents into SFDT format using the [`Syncfusion.EJ2.WordEditor.AspNet.MVC5`](<https://www.nuget.org/packages/Syncfusion.EJ2.WordEditor.AspNet.MVC5/>) by the web API service implementation. This library helps you to convert word documents (.dotx,.docx,.docm,.dot,.doc), rich text format documents (.rtf), and text documents (.txt) into SFDT format. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-docx/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-docx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/import-docx/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/import-docx/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

* [Feature modules](../document-editor/feature-module)
