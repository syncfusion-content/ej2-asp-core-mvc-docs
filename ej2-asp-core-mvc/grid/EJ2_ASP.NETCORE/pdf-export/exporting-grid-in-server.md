---
layout: post
title: Exporting Grid in Server in ##Platform_Name## Grid Component
description: Learn here all about Exporting Grid in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Exporting Grid in Server
publishingplatform: aspnet-core
documentation: ug
---


# Exporting Grid in Server

The Grid have an option to export the data to PDF in server side using Grid server export library.

## Server dependencies

The Server side export functionality is shipped in the Syncfusion.EJ2.GridExport package, which is available in Essential Studio and [nuget.org](https://www.nuget.org/).The following list of dependencies is required for Grid server side PDF exporting action.

* Syncfusion.EJ2
* Syncfusion.EJ2.GridExport

## Server configuration

The following code snippet shows server configuration using ASP.NET Core Controller Action.

To Export the Grid in server side, You need to call the
 [`serverPdfExport`](https://ej2.syncfusion.com/documentation/api/grid/#serverpdfexport) method for passing the Grid properties to server exporting action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/pdf-export/server-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/server-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Server-exportCore.cs" %}
{% include code-snippet/grid/pdf-export/server-export/server-exportCore.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> **Note:** Refer to the GitHub sample for quick implementation and testing from [here](https://github.com/SyncfusionExamples/Grid-Server-side-export-ASP.Net-Core).