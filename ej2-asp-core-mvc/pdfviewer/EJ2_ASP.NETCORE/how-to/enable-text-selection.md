---
layout: post
title: Enable or Disable Text Selection in ASP.NET Core PDF Viewer | Syncfusion
description: Learn how to enable text selection in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
documentation: ug
domainurl: ##DomainURL##
---

# Enable or Disable Text Selection in Syncfusion PDF Viewer

The Syncfusion PDF Viewer provides the `enableTextSelection` property, which allows you to control whether users can select text within the displayed PDF document. This feature can be toggled programmatically during runtime.

## Configure Text Selection on Initialization

You can set the initial text selection behavior when initializing the PDF Viewer control by configuring the `enableTextSelection` property. By default, text selection is enabled, but you can disable it as shown in the following example:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" 
                  style="height:600px" 
                  resourceUrl="https://cdn.syncfusion.com/ej2/30.1.37/dist/ej2-pdfviewer-lib" 
                  documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf" 
                  enableTextSelection="false">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}

## Toggle Text Selection Dynamically

You can change the text selection behavior at runtime using buttons, menu options, or other UI elements. The following example demonstrates how to toggle text selection with button clicks:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <button onclick="enableTextSelection()">Enable Text Selection</button>
    <button onclick="disableTextSelection()">Disable Text Selection</button>
    <ejs-pdfviewer id="pdfviewer" 
                  style="height:600px" 
                  resourceUrl="https://cdn.syncfusion.com/ej2/30.1.37/dist/ej2-pdfviewer-lib" 
                  documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf" 
                  enableTextSelection="false">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    // You can dynamically toggle text selection with JavaScript
    function enableTextSelection() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.enableTextSelection = true;
    }
    
    function disableTextSelection() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.enableTextSelection = false;
    }
</script>

{% endhighlight %}
{% endtabs %}

## Use Cases and Considerations

- **Document Protection**: Disabling text selection helps prevent unauthorized copying of sensitive content.
- **Read-only Documents**: In scenarios where documents are meant for viewing only, disabling text selection can provide a cleaner user experience.
- **Interactive Applications**: Toggle text selection based on user roles or document states in complex applications.
- **Controlled Access**: Implement conditional text selection depending on user permissions or document sections.

## Default Behavior

By default, text selection is enabled in the PDF Viewer. Set the `enableTextSelection` property to `false` explicitly if you want to disable this functionality.

N> When text selection is disabled, users will not be able to select or copy text from the document, which can be useful for protecting document content in certain scenarios.

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)