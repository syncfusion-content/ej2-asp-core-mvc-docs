---
layout: post
title: PDF Cell Style Customization in ##Platform_Name## Grid Component
description: Learn here all about PDF Cell Style Customization in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Cell Style Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Cell Style Customization

## Conditional cell formatting

Grid cells in the exported PDF can be customized or formatted using [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event. In this event, we can format the grid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for **Freight** column in the exported document by **args.cell** and **backgroundColor** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/cell-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pdf-export.cs" %}
{% include code-snippet/grid/pdf-export/cell-format/pdf-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/cell-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdf-export.cs" %}
{% include code-snippet/grid/pdf-export/cell-format/pdf-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Theme

PDF export provides an option to include theme for exported PDF document.

To apply theme in exported PDF, define the [`theme`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#theme) in [`PdfExportProperties`](https://ej2.syncfusion.com/documentation/api/grid/pdfExportProperties/#pdfexportproperties).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/grid/pdf-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/grid/pdf-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> By default, material theme is applied to exported PDF document.