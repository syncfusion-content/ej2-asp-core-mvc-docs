---
layout: post
title: Managing Local Storage in EJ2 ASP.NET Core PDF Viewer Control | Syncfusion
description: Learn how to manage local storage in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-angular
control: PDF Viewer
documentation: ug
domainurl: ##DomainURL##
---

# Managing Local Storage in Syncfusion PDF Viewer

The Syncfusion PDF Viewer provides the `enableLocalStorage` property, which allows you to control how session-specific data is stored. You can choose to store this data in an internal collection or rely on the default session storage.

### Using the enableLocalStorage Property

Set the `enableLocalStorage` property to manage whether the PDF Viewer uses session storage (default) or an internal collection. When set to `true`, session-specific data is kept in memory. Otherwise, session storage is used.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" resourceUrl="https://cdn.syncfusion.com/ej2/28.1.33/dist/ej2-pdfviewer-lib" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf" enableLocalStorage="true">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
</script>

{% endhighlight %}
{% endtabs %}

### Impact and Considerations

- **Increased Memory Usage**: Setting `enableLocalStorage` to `true` can increase memory usage, particularly with larger documents or those containing many interactive elements, such as form fields and annotations.
- **Avoiding Memory Leaks**: It is crucial to properly dispose of the PDF Viewer instance when it's no longer needed to prevent memory leaks, especially when using in-memory storage.
- **Default Behavior**: By default, this property is set to `false`, meaning the session storage mechanism is utilized unless explicitly changed.

### Enhanced Control

Leveraging the `enableLocalStorage` property provides greater flexibility in managing how data is stored during a session, allowing you to optimize performance and storage based on your application’s specific requirements.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)