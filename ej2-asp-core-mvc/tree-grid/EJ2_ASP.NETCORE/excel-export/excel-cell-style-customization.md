---
layout: post
title: Excel Cell Style Customization in Syncfusion ##Platform_Name## Tree Grid Component
description: Learn here all about Excel Cell Style Customization in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Excel Cell Style Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Excel Cell Style Customization

## Conditional Cell Formatting

TreeGrid cells in the exported Excel can be customized or formatted using [`excelQueryCellInfo`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ExcelQueryCellInfo.html) event. In this event, we can format the treegrid cells of exported PDF document based on the column cell value.

In the below sample, we have set the background color for **Duration** column in the exported excel by **args.cell** and **backgroundColor** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Conditional-cell.cs" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/conditional-cell.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Conditional-cell.cs" %}
{% include code-snippet/tree-grid/excel-export/conditional-cell/conditional-cell.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Theme

The excel export provides an option to include theme for exported excel document.

To apply theme in exported Excel, define the theme in exportProperties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/tree-grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/excel-export/theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Theme.cs" %}
{% include code-snippet/tree-grid/excel-export/theme/theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, material theme is applied to exported excel document.
> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.