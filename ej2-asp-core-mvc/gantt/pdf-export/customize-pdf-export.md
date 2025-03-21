---
layout: post
title: Customize PDF exporting in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Customize PDF exporting in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# To customize PDF export

PDF export provides an option to customize the mapping of Gantt to exported PDF document.

## File name for exported document

The file name of the exported PDF document can be specified using the `fileName` property in `pdfExportProperties`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/filename/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="File-name.cs" %}
{% include code-snippet/gantt/pdf-export/filename/file-name.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/filename/razor %}
{% endhighlight %}
{% highlight c# tabtitle="File-name.cs" %}
{% include code-snippet/gantt/pdf-export/filename/file-name.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to change page orientation

The page orientation of the exported PDF document can be customized using the `pageOrientation` property in `pdfExportProperties`. By default, the exported PDF document is in Landscape orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pageorientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page-orientation.cs" %}
{% include code-snippet/gantt/pdf-export/pageorientation/page-orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pageorientation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Page-orientation.cs" %}
{% include code-snippet/gantt/pdf-export/pageorientation/page-orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## How to change page size

Page size can be customized for the exported document using the  `pageSize` property in `pdfExportProperties`.
 The supported page sizes are:

* Letter
* Note
* Legal
* A0
* A1
* A2
* A3
* A5
* A6
* A7
* A8
* A9
* B0
* B1
* B2
* B3
* B4
* B5
* Archa
* Archb
* Archc
* Archd
* Arche
* Flsa
* HalfLetter
* Letter11x17
* Ledger

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/page-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page-size.cs" %}
{% include code-snippet/gantt/pdf-export/page-size/page-size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/page-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Page-size.cs" %}
{% include code-snippet/gantt/pdf-export/page-size/page-size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export current view data

PDF export provides an option to export the current view data into PDF. To export current view data alone, define the `exportType` to `CurrentViewData`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/currentviewdata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Current-view-data.cs" %}
{% include code-snippet/gantt/pdf-export/currentviewdata/current-view-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/currentviewdata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Current-view-data.cs" %}
{% include code-snippet/gantt/pdf-export/currentviewdata/current-view-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export hidden columns

PDF export provides an option to export hidden columns of Gantt by defining the `includeHiddenColumn` to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/hiddencolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hidden-columns.cs" %}
{% include code-snippet/gantt/pdf-export/hiddencolumns/hidden-columns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Hidden-columns.cs" %}
{% include code-snippet/gantt/pdf-export/hiddencolumns/hidden-columns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Export predecessor lines

The visibility of predecessor lines in the exported PDF document can be controlled using the `showPredecessorLines` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/connectorlines/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Connector-lines.cs" %}
{% include code-snippet/gantt/pdf-export/connectorlines/connector-lines.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/connectorlines/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Connector-lines.cs" %}
{% include code-snippet/gantt/pdf-export/connectorlines/connector-lines.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Show or hide columns on exported PDF

A hidden column can be shown, or a visible column can be hidden while exporting the Gantt chart by using the  [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ToolbarClick) and [`beforePdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_BeforePdfExport) events.

Columns can be shown or hidden by setting the `column.visible` property to true or false, respectively.

In the following example, the `Duration` column is initially hidden in the Gantt chart. During export, the `Duration` column is made visible and the StartDate column is hidden.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/showhidecolumns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Showhide-columns.cs" %}
{% include code-snippet/gantt/pdf-export/showhidecolumns/showhide-columns.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/showhidecolumns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Showhide-columns.cs" %}
{% include code-snippet/gantt/pdf-export/showhidecolumns/showhide-columns.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Conditional cell formatting

TreeGrid cells in the exported PDF can be customized or formatted using the [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryCellInfo) event. In this event, you can format the treegrid cells of exported PDF document based on the column cell value.

In the following sample, the background color is set for `Progress` column in the exported document by using the `args.style.backgroundColor` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/cellcustomization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-customization.cs" %}
{% include code-snippet/gantt/pdf-export/cellcustomization/cell-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/cellcustomization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cell-customization.cs" %}
{% include code-snippet/gantt/pdf-export/cellcustomization/cell-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Timeline cell formatting

Timeline cells in the exported PDF document can be customized or formatted using the [`pdfQueryTimelineCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryTimelineCellInfo) event.

In the following sample, the header background color is set for timeline cells in the exported document by using the `args.headerBackgroundColor` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/timelinecustomization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timeline-customization.cs" %}
{% include code-snippet/gantt/pdf-export/timelinecustomization/timeline-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/timelinecustomization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Timeline-customization.cs" %}
{% include code-snippet/gantt/pdf-export/timelinecustomization/timeline-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Taskbar formatting

Taskbars in the exported PDF document can be customized or formatted using the [`pdfQueryTaskbarInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryTaskbarInfo) event.

In the following sample, the taskbar background color is customized in the chart side of the exported document by using the `args.taskbar` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/taskbarcustomization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Taskbar-customization.cs" %}
{% include code-snippet/gantt/pdf-export/taskbarcustomization/taskbar-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/taskbarcustomization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Taskbar-customization.cs" %}
{% include code-snippet/gantt/pdf-export/taskbarcustomization/taskbar-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Customize Gantt Chart Appearance in PDF Export

PDF export allows to customize the Gantt chart's appearance in the exported PDF documents. To customize the appearance of Gantt charts in exported PDF documents, define `ganttStyle`. By using `ganttStyle`, can customize `columnHeader`, `fontFamily`, `cell`, `taskbar`, `label`, `timeline`, `chartGridLineColor`, `connectorLineColor`, `criticalConnectorLineColor`, `footer`, `font`, `eventMarker` and `holiday` regardless of the theme. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/customtheme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-theme.cs" %}
{% include code-snippet/gantt/pdf-export/customtheme/custom-theme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/customtheme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-theme.cs" %}
{% include code-snippet/gantt/pdf-export/customtheme/custom-theme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Customize Split Taskbar Segment Colors in PDF

The PDF export feature in the Gantt Chart allows you to customize the colors of split taskbar segments using the `taskSegmentStyles` property inside the [`PdfQueryTaskbarInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryTaskbarInfo) event.

The `taskSegmentStyles` property contains a collection of style properties for task segments. By specifying the index of corresponding segment index in this collection you can customize that segment taskbar color, progress color, and its border color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdf-customize-segment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="pdf-customize-segment.cs" %}
{% include code-snippet/gantt/pdf-export/pdf-customize-segment/pdf-customize-segment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdf-customize-segment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="pdf-customize-segment.cs" %}
{% include code-snippet/gantt/pdf-export/pdf-customize-segment/pdf-customize-segment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting with template

### Exporting with column template

The PDF export functionality allows to export Grid columns that include images, hyperlinks, and custom text to an PDF document using [pdfQueryCellInfo](https://helpej2.syncfusion.com/documentation/api/gantt/pdfQueryCellInfoEventArgs/) event.

In the following sample, the hyperlinks and images are exported to PDF using [hyperlink](https://helpej2.syncfusion.com/documentation/api/gantt/pdfQueryCellInfoEventArgs/#hyperlink) and [image](https://helpej2.syncfusion.com/documentation/api/gantt/pdfQueryCellInfoEventArgs/#image) properties in the [pdfQueryCellInfo](https://helpej2.syncfusion.com/documentation/api/gantt/pdfQueryCellInfoEventArgs/) event.

>Note: PDF Export supports base64 string to export the images.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdf-columnTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PDF-columnTemplate.cs" %}
{% include code-snippet/gantt/pdf-export/pdf-columnTemplate/pdf-columnTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdf-columnTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PDF-columnTemplate.cs" %}
{% include code-snippet/gantt/pdf-export/pdf-columnTemplate/pdf-columnTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Exporting with taskbar template

The PDF export functionality allows to export taskbar templates that include `images` and `text` to an PDF document using [pdfQueryTaskbarInfo](https://ej2.syncfusion.com/react/documentation/api/gantt/#pdfquerytaskbarinfo) event. Taskbars in the exported PDF document can be customized or formatted using the `pdfQueryTaskbarInfo` event for parent taskbar templates, taskbar template and milestone templates.

In the following sample, taskbar templates with images and text are exported to PDF using [taskbarTemplate](https://ej2.syncfusion.com/react/documentation/api/gantt/pdfQueryTaskbarInfoEventArgs/#taskbarTemplate) properties in the [pdfQueryTaskbarInfo](https://ej2.syncfusion.com/react/documentation/api/gantt/#pdfquerytaskbarinfo) event.

>Note: PDF Export supports base64 string to export the images.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport-taskbar-Template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="pdfexport-taskbar-Template.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport-taskbar-Template/pdfexport-taskbar-Template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport-taskbar-Template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="pdfexport-taskbar-Template.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport-taskbar-Template/pdfexport-taskbar-Template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Exporting with task label template

The PDF export functionality allows to export task label template that include `images` and `text` to an PDF document using [pdfQueryTaskbarInfo](https://ej2.syncfusion.com/react/documentation/api/gantt/#pdfquerytaskbarinfo) event.

In the following sample, task label template with images and text are exported to PDF using [labelSettings](https://ej2.syncfusion.com/react/documentation/api/gantt/pdfQueryTaskbarInfoEventArgs/#labelSettings) properties in the [pdfQueryTaskbarInfo](https://ej2.syncfusion.com/react/documentation/api/gantt/#pdfquerytaskbarinfo) event.

>Note: PDF Export supports base64 string to export the images.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport-tasklabel-Template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="pdfexport-tasklabel-Template.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport-tasklabel-Template/pdfexport-tasklabel-Template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport-tasklabel-Template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="pdfexport-tasklabel-Template.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport-tasklabel-Template/pdfexport-tasklabel-Template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Exporting with header template

The PDF export functionality allows to export header template that include `images` and `text` to an PDF document using [pdfColumnHeaderQueryCellInfo](https://ej2.syncfusion.com/react/documentation/api/gantt/pdfColumnHeaderQueryCellInfoEventArgs/) event.

In the following sample, header template with images and text are exported to PDF using [headerTemplate](https://ej2.syncfusion.com/react/documentation/api/gantt/pdfColumnHeaderQueryCellInfoEventArgs/#headerTemplate) properties in the [pdfColumnHeaderQueryCellInfo](https://ej2.syncfusion.com/react/documentation/api/gantt/pdfColumnHeaderQueryCellInfoEventArgs/) event.

>Note: PDF Export supports base64 string to export the images.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport-header-Template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="pdfexport-header-Template.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport-header-Template/pdfexport-header-Template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport-header-Template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="pdfexport-header-Template.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport-header-Template/pdfexport-header-Template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
