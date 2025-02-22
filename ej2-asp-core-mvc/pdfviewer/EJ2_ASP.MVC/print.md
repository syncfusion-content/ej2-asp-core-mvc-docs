---
layout: post
title: Print in ##Platform_Name## PDF Viewer Component | Syncfusion
description: Learn here all about print support in Syncfusion ##Platform_Name## PDF Viewer component, it's elements and more.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to print the loaded PDF file

The PDF Viewer supports printing the loaded PDF file. You can enable/disable the print using the following code snippet.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").EnablePrint(true).DocumentLoad("print").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function print() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.print.print();
    }
</script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnablePrint(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function print() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.print.print();
    }
</script>
```
{% endhighlight %}
{% endtabs %}

![Alt text](images/print.png)

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)