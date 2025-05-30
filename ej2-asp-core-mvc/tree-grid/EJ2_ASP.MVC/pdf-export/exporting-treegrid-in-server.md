---
layout: post
title: Exporting Tree Grid in Server in Syncfusion ##Platform_Name## Tree Grid Component
description: Learn here all about Exporting Tree Grid in Server in Syncfusion ##Platform_Name## Tree Grid Component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting Tree Grid in Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting Tree Grid in Server

The Tree Grid have an option to export the data to PDF in server side using tree grid server export library.

## Server dependencies

The Server side export functionality is shipped in the Syncfusion.EJ2.TreeGridExport package, which is available in Essential Studio<sup style="font-size:70%">&reg;</sup> and [nuget.org](https://www.nuget.org/).The following list of dependencies is required for tree grid server side PDF exporting action.

* Syncfusion.EJ2
* Syncfusion.EJ2.TreeGridExport

## Server configuration

The following code snippet shows server configuration using ASP.NET Core Controller Action.

To Export the tree grid in server side, You need to call the [`serverPdfExport`](https://ej2.syncfusion.com/documentation/api/treegrid/#serverpdfexport) method for passing the tree grid properties to server exporting action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/server-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/tree-grid/pdf-export/server-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportMvc.cs" %}
{% include code-snippet/tree-grid/pdf-export/server-export/server-exportMvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Rotate a header text to a certain degree in the exported tree grid on the server side

The Tree Grid has support to customize the column header styles such as changing text orientation, the font color, and so on in the exported PDF file. To achieve this requirement, define the `BeginCellLayout` event of the `PdfExportProperties` with an event handler to perform the required action.

The `PdfHeaderCellRendering` will be triggered when creating a column header for the pdf document to be exported. Collect the column header details in this event and handle the custom in the BeginCellLayout event handler.

In the following demo, the `DrawString` method from the `Graphics` is used to rotate the header text of the column header inside the `BeginCellLayout` event handler.

N> A PDF exporting is not supported to rotate the column header on the client side.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/rotate-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate-Header.cs" %}
{% include code-snippet/tree-grid/pdf-export/rotate-header/rotate-header.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/pdf-export/rotate-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rotate-Header.cs" %}
{% include code-snippet/tree-grid/pdf-export/rotate-header/rotate-header.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}