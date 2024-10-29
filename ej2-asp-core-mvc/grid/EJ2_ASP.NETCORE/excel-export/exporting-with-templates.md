---
layout: post
title: Exporting Templates in ##Platform_Name## Grid Component
description: Learn here all about Exporting grids with templates in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Exporting grid with templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Exporting grid with templates in ##Platform_Name## Grid control

The grid offers the option to export the column, detail, and caption templates to an Excel document. The template contains images, hyperlinks, and customized text.

## Exporting with column template

The Excel export functionality allows you to export Grid columns that include images, hyperlinks, and custom text to an Excel document.

In the following sample, the hyperlinks and images are exported to Excel using [hyperlink](https://ej2.syncfusion.com/documentation/api/grid/excelQueryCellInfoEventArgs/#hyperlink) and [image](https://ej2.syncfusion.com/documentation/api/grid/excelQueryCellInfoEventArgs/#image) properties in the [excelQueryCellInfo](https://ej2.syncfusion.com/documentation/api/grid/#excelquerycellinfo event.

> Excel Export supports base64 string to export the images.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/column-template-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Column-template-export.cs" %}
{% include code-snippet/grid/excel-export/column-template-export/column-template-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/column-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Column-template-export.cs" %}
{% include code-snippet/grid/excel-export/column-template-export/column-template-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ColumnTemplateExport](../images/colTemp_excel_expt.gif)

## Exporting with detail template

By default, the grid will export the parent grid with expanded detail rows alone. Change the exporting option by using the `ExcelExportProperties.hierarchyExportMode` property. The available options are:

| Mode     | Behavior    |
|----------|-------------|
| Expanded | Exports the parent grid with expanded detail rows. |
| All      | Exports the parent grid with all the detail rows. |
| None     | Exports the parent grid alone. |

The detail rows in the exported Excel can be customized or formatted using the [exportDetailTemplate](https://ej2.syncfusion.com/documentation/api/grid/#exportdetailtemplate) event. In this event, the detail rows of the Excel document are formatted in accordance with their parent row details.

In the following sample, the detail row content is formatted by specifying the [columnHeader](https://ej2.syncfusion.com/documentation/api/grid/detailTemplateProperties/#columnheader) and [rows](https://ej2.syncfusion.com/documentation/api/grid/detailTemplateProperties/#rows) properties using its [parentRow](https://ej2.syncfusion.com/documentation/api/grid/exportDetailTemplateEventArgs/#parentrow) details. This allows for the creation of detail rows in the Excel document. Additionally, custom styles can be applied to specific cells using the [style](https://ej2.syncfusion.com/documentation/api/grid/detailTemplateCell/#style) property.

> When using [rowSpan](https://ej2.syncfusion.com/documentation/api/grid/detailTemplateCell/#rowspan), it is essential to provide the cell's [index](https://ej2.syncfusion.com/documentation/api/grid/detailTemplateCell/#index) for proper functionality.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/detail-template-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dsetail-template-export.cs" %}
{% include code-snippet/grid/excel-export/detail-template-export/detail-template-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/detail-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Detail-template-export.cs" %}
{% include code-snippet/grid/excel-export/detail-template-export/detail-template-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![DetailTemplateExport](../images/detailTemp_excel_expt.gif)

## Exporting with caption template

The Excel export feature enables exporting of Grid with a caption template to an Excel document.

In the following sample, the customized caption text is exported to Excel using [captionText](https://ej2.syncfusion.com/documentation/api/grid/exportGroupCaptionEventArgs/#captiontext) property in the [exportGroupCaption](https://ej2.syncfusion.com/documentation/api/grid/#exportgroupcaption) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/caption-template-export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Caption-template-export.cs" %}
{% include code-snippet/grid/excel-export/caption-template-export/caption-template-export.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/excel-export/caption-template-export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Caption-template-export.cs" %}
{% include code-snippet/grid/excel-export/caption-template-export/caption-template-export.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![CaptionTemplateExport](../images/captionTemp_excel_expt.gif)