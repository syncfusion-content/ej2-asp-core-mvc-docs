---
layout: post
title: Print in ##Platform_Name## Pdfviewer Component
description: Learn here all about Print in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Print
publishingplatform: ##Platform_Name##
documentation: ug
---

# Migration from Server-Backed PDF Viewer to Standalone PDF Viewer control

## Why Server-Backed PDF Viewer to Standalone PDF Viewer control

The migration to the Standalone PDF Viewer control brings a host of benefits, including improved performance in scrolling, pagination, and printing. These enhancements result in a smoother and more efficient user experience. Additionally, this migration eliminates the need for a Web assembly service dependency, streamlining the system and enhancing maintainability.

* **Enhanced Performance**:
With the Standalone PDF Viewer control, users can expect significant improvements in performance. Scrolling through documents, navigating pages, and printing operations are now optimized for efficiency. Users will experience seamless and fluid interactions, ensuring a more productive and satisfying workflow.

* **Elimination of Web Assembly Service Dependency**:
The migration to the Standalone PDF Viewer control removes the requirement for a Web assembly service dependency.

### Script File

To utilize the Standalone PDF Viewer control in your project, need to add the corresponding script file to the **Layout.cshtml**.

<table>
<tr>
<th>Server-Backed PDF Viewer</th>
</tr>
<tr>
<td>
{% tabs %}
{% highlight C# tabtitle=".csproj" hl_lines="3" %}

<head>
     <!-- Syncfusion ASP.NET Core controls scripts -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>Standalone PDF Viewer</th>
</tr>
<tr>
<td>
{% tabs %}
{% highlight C# tabtitle=".csproj" hl_lines="3" %}

<head>
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}
</td>
</tr>
</table>

### Index.cshtml

To render the Standalone PDF Viewer component, add the following code in the **Index.cshtml**.

<table>
<tr>
<th>Server-Backed PDF Viewer</th>
</tr>
<tr>
<td>
{% tabs %}
{% highlight C# tabtitle=".csproj" hl_lines="8" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" serviceUrl="/Index" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>


{% endhighlight %}
{% endtabs %}
</td>
</tr>
<tr>
<th>Standalone PDF Viewer</th>
</tr>
<tr>
<td>
{% tabs %}
{% highlight C# tabtitle=".csproj" hl_lines="8" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <ejs-pdfviewer id="pdfviewer" style="height:600px" documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}
</td>
</tr>
</table>

## See also

* [Getting Started with Standalone PDF Viewer Component](./getting-started)

* [Getting Started with Server-Backed PDF Viewer Component](./getting-started-with-server-backed)