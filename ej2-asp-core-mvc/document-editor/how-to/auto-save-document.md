---
layout: post
title: Auto Save Document in ##Platform_Name## Document Editor Component
description: Learn here all about Auto save document in document editor in Syncfusion ##Platform_Name## Document Editor component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Auto Save Document In Document Editor
publishingplatform: ##Platform_Name##
documentation: ug
---


# Auto save document in ##Platform_Name## Document editor control

In this article, we are going to see how to autosave the document to server. You can automatically save the edited content in regular intervals of time. It helps reduce the risk of data loss by saving an open document automatically at customized intervals.

The following example illustrates how to auto save the document in server.

* In the client-side, using content change event, we can automatically save the edited content in regular intervals of time. Based on `contentChanged` boolean, the document send as Docx format to server-side using [`saveAsBlob`] method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/auto-save-server/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-save-server.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/auto-save-server/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Auto-save-server.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



* In server-side, Receives the stream content from client-side and process it to save the document in Server or Database from the received stream. Add Web API in controller file like below to save the document.

```c#
[AcceptVerbs("Post")]
[HttpPost]
[EnableCors("AllowAllOrigins")]
[Route("AutoSave")]
public string AutoSave()
{
    IFormFile file = HttpContext.Request.Form.Files[0];
    Stream stream = new MemoryStream();    
    file.CopyTo(stream);
    //Save the stream to database or server as per the requirement.
    stream.Close();
    return "Sucess";
}
```

## See Also
* [Autosave document in DocumentEditor](../../document-editor/how-to/auto-save-document-in-document-editor)
