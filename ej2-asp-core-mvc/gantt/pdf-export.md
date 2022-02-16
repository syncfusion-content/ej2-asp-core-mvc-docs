---
layout: post
title: Pdf Export in ##Platform_Name## Gantt Component
description: Learn here all about Pdf Export in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Pdf Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# PDF Export

PDF export allows exporting Gantt data to PDF document. You need to use the `pdfExport` method for exporting. To enable PDF export in the Gantt, set the [`allowPdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowPdfExport) to true.

To export data to PDF document, inject the `PdfExport` module in Gantt.

> Currently, we don't have support for exporting the manually scheduled tasks.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfexport.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport/pdfexport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/pdfexport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfexport.cs" %}
{% include code-snippet/gantt/pdf-export/pdfexport/pdfexport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple exporting

PDF export provides an option for exporting multiple Gantt to same file. In this exported document, each Gantt will be exported to a new page of the document in same file.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdfmultipleexport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfmultipleexport.cs" %}
{% include code-snippet/gantt/pdfmultipleexport/pdfmultipleexport.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdfmultipleexport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pdfmultipleexport.cs" %}
{% include code-snippet/gantt/pdfmultipleexport/pdfmultipleexport.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## To customize PDF export

PDF export provides an option to customize the mapping of Gantt to exported PDF document.

### File name for exported document

You can assign a file name for the exported document by defining the `fileName` property in `pdfExportProperties`.

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



### How to change page orientation

Page orientation can be changed to `Portrait` (Default Landscape) for the exported document using the property `pdfExportProperties.pageOrientation`.

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



### How to change page size

Page size can be customized for the exported document using the property `pdfExportProperties.pageSize`.
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



### Export current view data

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



### Enable footer

By default, we render the default footer for a PDF file, this can be enabled or disabled by using the `enableFooter` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Footer.cs" %}
{% include code-snippet/gantt/pdf-export/footer/footer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/footer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Footer.cs" %}
{% include code-snippet/gantt/pdf-export/footer/footer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Export hidden columns

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



### Export predecessor lines

By using `showPredecessorLines`, you can hide or show predecessor lines in the exported PDF document.

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



### Show or hide columns on exported PDF

You can show a hidden column or hide a visible column while exporting the Gantt using the [`toolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ToolbarClick) and [`beforePdfExport`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_BeforePdfExport) events.

You can show or hide columns by setting the `column.visible` property to `true` or `false` respectively.

In the following example, there is a hidden column `Duration` in the Gantt. While exporting, we have changed `Duration` to visible column and `StartDate` to hidden column.

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



### Conditional cell formatting

TreeGrid cells in the exported PDF can be customized or formatted using the [`pdfQueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_PdfQueryCellInfo) event. In this event, you can format the treegrid cells of exported PDF document based on the column cell value.

In the following sample, the background color is set for `Progress` column in the exported document by using the `args.style` and `backgroundColor` properties.

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



### Timeline cell formatting

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



### Taskbar formatting

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



### Theme

PDF export provides an option to include theme for the exported PDF document.
To apply theme in exported PDF, define the `theme` in `pdfExportProperties`.
The available themes are:

* Material
* Fabric
* Bootstrap
* Bootstrap 4

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/themes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Themes.cs" %}
{% include code-snippet/gantt/pdf-export/themes/themes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/pdf-export/themes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Themes.cs" %}
{% include code-snippet/gantt/pdf-export/themes/themes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customized Theme

PDF export provides an option to customize the Gantt style for the exported PDF document.
To customize Gantt style in exported PDF, define the `ganttStyle` in `pdfExportProperties`.

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

