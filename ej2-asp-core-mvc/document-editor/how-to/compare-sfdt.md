---
layout: post
title: Compare sfdt in Syncfusion  ##Platform_Name## Document Editor Component
description: Learn here all about how to Compare sfdt in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Compare sfdt
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Compare sfdt in ##Platform_Name## Document editor control

## Comparison of sfdt in server-side using Syncfusion DocIO

The Document Editor does not support document comparison at this time. However, we can utilize the Syncfusion DocIO library to compare documents. DocIO will analyze the original and revised documents, generating a result document that highlights the changes as revisions.

With the help of [`Syncfusion DocIO`](https://help.syncfusion.com/document-processing/word/word-library/net/word-document/compare-word-documents), you can compare existing documents or documents created from scratch using the Compare method in the .NET Word library (DocIO) on the server side.

The following way illustrates how to Compare Document:

The following example code illustrates how to compare the document to call the Compare Web API from server side in client side code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/compare-sfdt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Compare-sfdt.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/compare-sfdt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Compare-sfdt.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


* Using Compare web API in server-side, you can Copare the documents.
* We compare the two different documents using docIO compare API and store the result to the Original document.
Save the document to stream and pass it to EJ2 document editor load API to get the Sfdt string.
The resulting document will be opened on the client side.
* Finally, the compared document will shown in Document Editor User interface (UI).

The following example code illustrates how to compare Documents in server-side.

```csharp
[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("Compare")]
public string Compare([FromBody]CompareParmeter para)
{
    Stream oldStream = WordDocument.Save(para.OldContent, FormatType.Docx);
    Stream newStream = WordDocument.Save(para.NewContent, FormatType.Docx);
    oldStream.Position = 0;
    newStream.Position = 0;
    string sfdtText = "";
    using (WDocument originalDocument = new WDocument(oldStream, WFormatType.Docx))
    {
        using (WDocument revisedDocument = new WDocument(newStream, WFormatType.Docx))
        {
            // Compare the original and revised Word documents.
            originalDocument.Compare(revisedDocument);

            //Save the Word document to MemoryStream
            MemoryStream stream = new MemoryStream();
            originalDocument.Save(stream, WFormatType.Docx);
            stream.Position = 0;

            WordDocument document = WordDocument.Load(stream, FormatType.Docx);
            sfdtText = Newtonsoft.Json.JsonConvert.SerializeObject(document);
            document.Dispose();
            stream.Dispose();
            oldStream.Dispose();
            newStream.Dispose();
        }

    }
    return sfdtText;
}
```