---
layout: post
title: Exporting Grid in Server in ##Platform_Name## Grid Component
description: Learn here all about Exporting Grid in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting Grid in Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting Hierarchy Grid

The grid have an option to export the hierarchy grid to excel document. By default, grid will exports the visible child grids in expanded state. you can change the exporting option by using the **ExcelExportProperties.hierarchyExportMode** property. The available options are,

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the visible child grids in expanded state. |
| All      | Exports the all the child grids in expanded state. |
| None     | Exports all child grids in collapse state. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/hierarchy/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchy.cs" %}
{% include code-snippet/grid/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/hierarchy/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchy.cs" %}
{% include code-snippet/grid/excel-export/hierarchy/hierarchy.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

* Microsoft Excel permits up to seven nested levels in outlines. So that in the grid we can able to provide only up to seven nested levels and if it exceeds more than seven levels then the document will be exported without outline option.

Refer the [Microsoft Limitation](https://docs.microsoft.com/en-us/sql/reporting-services/report-builder/exporting-to-microsoft-excel-report-builder-and-ssrs?view=sql-server-2017#ExcelLimitations).