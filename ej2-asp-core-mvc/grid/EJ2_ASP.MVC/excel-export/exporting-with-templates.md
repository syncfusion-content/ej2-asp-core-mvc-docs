---
layout: post
title: Exporting Templates in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Exporting grids with templates in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting grid with templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Exporting grid with templates in ASP.NET MVC Grid control

The grid offers the option to export the column, detail, and caption templates to an Excel document. The template contains images, hyperlinks, and customized text.

## Exporting with column template

The Excel export functionality allows you to export Grid columns that include images, hyperlinks, and custom text to an Excel document.

In the following sample, the hyperlinks and images are exported to Excel using `Hyperlink` and `Image` properties in the [ExcelQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExcelQueryCellInfo) event.

> Excel Export supports base64 string to export the images.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/column-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="column-template-export.cs" %}
{% include code-snippet/grid/excel-export/column-template-export/column-template-export.cs %}
{% endhighlight %}
{% endtabs %}

![ColumnTemplateExport](../images/colTemp_excel_expt.gif)

## Exporting with detail template

By default, the grid will export the parent grid with expanded detail rows alone. Change the exporting option by using the `ExcelExportProperties.HierarchyExportMode` property. The available options are:

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the parent grid with expanded detail rows. |
| All      | Exports the parent grid with all the detail rows. |
| None     | Exports the parent grid alone. |

The detail rows in the exported Excel can be customized or formatted using the [ExportDetailTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExportDetailTemplate) event. In this event, the detail rows of the Excel document are formatted in accordance with their parent row details.

In the following sample, the detail row content is formatted by specifying the `ColumnHeader` and `Rows` properties using its `ParentRow` details. This allows for the creation of detail rows in the Excel document. Additionally, custom styles can be applied to specific cells using the `Style` property.

> When using `RowSpan`, it is essential to provide the cell's `Index` for proper functionality.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/detail-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="detail-template-export.cs" %}
{% include code-snippet/grid/excel-export/detail-template-export/detail-template-export.cs %}
{% endhighlight %}
{% endtabs %}

![DetailTemplateExport](../images/detailTemp_excel_expt.gif)

## Exporting with caption template

The Excel export feature enables exporting of Grid with a caption template to an Excel document.

In the following sample, the customized caption text is exported to Excel using `CaptionText` property in the [ExportGroupCaption](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExportGroupCaption) event.


{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/caption-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="caption-template-export.cs" %}
{% include code-snippet/grid/excel-export/caption-template-export/caption-template-export.cs %}
{% endhighlight %}
{% endtabs %}

![CaptionTemplateExport](../images/captionTemp_excel_expt.gif)