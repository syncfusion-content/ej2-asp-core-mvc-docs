---
layout: post
title: Exporting Selected Data in ##Platform_Name## Grid Component
description: Learn here all about Exporting Selected Data in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Exporting Selected Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting the Selected Records

You can export the selected records data by passing it to [`dataSource`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#datasource) of [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties) in the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event.

In the below exporting demo, We can get the selected records using **getSelectedRecords** method and pass the selected data to **PdfExport** or **excelExport** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/export-selected-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-data.cs" %}
{% include code-snippet/grid/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/export-selected-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selected-data.cs" %}
{% include code-snippet/grid/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

