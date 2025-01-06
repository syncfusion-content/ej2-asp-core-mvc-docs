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

The grid offers the option to export the column, detail, and caption templates to a PDF document. The template contains images, hyperlinks, and customized text.

## Exporting with column template

The PDF export functionality allows you to export Grid columns that include images, hyperlinks, and custom text to a PDF document.

In the following sample, the hyperlinks and images are exported to PDF using `Hyperlink` and `Image` properties in the [PdfQueryCellInfo](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_PdfQueryCellInfo) event.

> PDF Export supports base64 string to export the images.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/column-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-template-export.cs" %}
{% include code-snippet/grid/pdf-export/column-template-export/column-template-export.cs %}
{% endhighlight %}
{% endtabs %}

![ColumnTemplateExport](../images/colTemp_pdf_expt.gif)

## Exporting with detail template

By default, the grid will export the parent grid with expanded detail rows alone. Change the exporting option by using the `PdfExportProperties.HierarchyExportMode` property. The available options are:

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the parent grid with expanded detail rows. |
| All      | Exports the parent grid with all the detail rows. |
| None     | Exports the parent grid alone. |

The detail rows in the exported PDF can be customized or formatted using the [ExportDetailTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExportDetailTemplate) event. In this event, the detail rows of the PDF document are formatted in accordance with their parent row details.

In the following sample, the detail row content is formatted by specifying the `ColumnCount`, `ColumnHeader`, and `Rows`properties using its `ParentRow` details. This allows for the creation of detail rows in the PDF document. Additionally, custom styles can be applied to specific cells using the `Style` property.

> If `ColumnCount` is not provided, the columns in the detail row of the PDF grid will be generated based on the count of the `ColumnHeader`/`Rows` first row's `Cells`.
> When using `RowSpan`, it is essential to provide the cell's `Index` for proper functionality.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/detail-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Detail-template-export.cs" %}
{% include code-snippet/grid/pdf-export/detail-template-export/detail-template-export.cs %}
{% endhighlight %}
{% endtabs %}

![DetailTemplateExport](../images/detailTemp_pdf_expt.gif)

## Exporting with caption template

The PDF export feature enables exporting of Grid with a caption template to an PDF document.

In the following sample, the customized caption text is exported to PDF using `CaptionText`property in the [ExportGroupCaption](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ExportGroupCaption) event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/pdf-export/caption-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Caption-template-export.cs" %}
{% include code-snippet/grid/pdf-export/caption-template-export/caption-template-export.cs %}
{% endhighlight %}
{% endtabs %}

![CaptionTemplateExport](../images/captionTemp_pdf_expt.gif)