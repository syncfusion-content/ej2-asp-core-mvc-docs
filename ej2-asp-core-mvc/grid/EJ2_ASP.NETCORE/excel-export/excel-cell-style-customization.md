---
layout: post
title: Excel Cell Style Customization in ##Platform_Name## Grid Component
description: Learn here all about Excel Cell Style Customization in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Cell Style Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Cell Style Customization

## Conditional cell formatting

Grid cells in the exported Excel can be customized or formatted using [`excelQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event. In this event, we can format the grid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for **Freight** column in the exported excel by **args.cell** and **backColor** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/cell-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/cell-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-format.cs" %}
{% include code-snippet/grid/excel-export/cell-format/cell-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the **theme** in **exportProperties** .

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, material theme is applied to exported excel document.

## Grid cell customization in Excel export

The DataGrid has support to customize the column header styles such as changing text orientation, the font color, and so on in the exported Excel file. To achieve this requirement, use the [excelHeaderQueryCellInfo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelHeaderQueryCellInfo) event of the Grid.

The `excelHeaderQueryCellInfo` will be triggered when creating a column header for the excel document to be exported. Customize the column header in this event.

In the following demo, using the `rotation` property of the style argument in the `excelHeaderQueryCellInfo` event, you can rotate the header text of the column header in the excel exported document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/header-rotate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Header-rotate.cs" %}
{% include code-snippet/grid/excel-export/header-rotate/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/header-rotate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Header-rotate.cs" %}
{% include code-snippet/grid/excel-export/header-rotate/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}