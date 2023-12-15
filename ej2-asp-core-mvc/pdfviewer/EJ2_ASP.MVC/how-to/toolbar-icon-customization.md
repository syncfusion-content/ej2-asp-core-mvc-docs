---
layout: post
title: Toolbar customization in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Toolbar customization in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ej2-asp-core-mvc
documentation: ug
---

# Customize toolbar in PDF Viewer component

## How to customize existing toolbar in PDF Viewer component

PDF Viewer allows you to customize(add, show, hide, enable, and disable) existing items in a toolbar.

* Add - New items can defined by **CustomToolbarItemModel** and with existing items in [**toolbarItems**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerToolbarSettings.html#Syncfusion_EJ2_PdfViewer_PdfViewerToolbarSettings_ToolbarItems) property. Newly added item click action can be defined in `toolbarclick`.

* Show, Hide - Existing items can be shown or hidden using the [`toolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerToolbarSettings.html#Syncfusion_EJ2_PdfViewer_PdfViewerToolbarSettings_ToolbarItems) property. Pre-defined toolbar items are available with `ToolbarItem`.

* Enable, Disable - Toolbar items can be enabled or disable using `enabletoolbaritem`.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

<div id="documenteditor" style="width:100%;height:100%">
    @Html.EJS().DocumentEditorpdfviewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Created("toolbarIcons").Render()
</div>

<script>
    function toolbarIcons() {
        var pdfviewer = document.getElementById("pdfviewer").ej2_instances[0];
        var toolItem = {
            prefixIcon: 'e-icons e-paste',
            id: 'print',
            tooltipText: 'Custom toolbar item',
            align: 'left'
        };
        pdfviewer.toolbarItems = [toolItem, 'OpenOption', 'PageNavigationTool', 'MagnificationTool', 'PanTool', 'SelectionTool', 'SearchOption', 'PrintOption', 'DownloadOption', 'UndoRedoTool', 'AnnotationEditTool', 'FormDesignerEditTool', 'CommentTool', 'SubmitForm'];
        pdfviewer.toolbarClick = function (args) {
           if (args.item && args.item.id === 'print') {
              viewer.printModule.print();
            }
           else if (args.item && args.item.id === 'download') {
              viewer.download();
            }
        };
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<div id="documenteditor" style="width:100%;height:100%">
    @Html.EJS().DocumentEditorpdfviewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Created("toolbarIcons").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).Render()
</div>

<script>
    function toolbarIcons() {
        var pdfviewer = document.getElementById("pdfviewer").ej2_instances[0];
        var toolItem = {
            prefixIcon: 'e-icons e-paste',
            id: 'print',
            tooltipText: 'Custom toolbar item',
            align: 'left'
        };
        pdfviewer.toolbarItems = [toolItem, 'OpenOption', 'PageNavigationTool', 'MagnificationTool', 'PanTool', 'SelectionTool', 'SearchOption', 'PrintOption', 'DownloadOption', 'UndoRedoTool', 'AnnotationEditTool', 'FormDesignerEditTool', 'CommentTool', 'SubmitForm'];
        pdfviewer.toolbarClick = function (args) {
           if (args.item && args.item.id === 'print') {
              viewer.printModule.print();
            }
           else if (args.item && args.item.id === 'download') {
              viewer.download();
            }
        };
    }
</script>

{% endhighlight %}
{% endtabs %}

>Note : Default value of toolbar items is ['OpenOption', 'PageNavigationTool','MagnificationTool', 'PanTool', 'SelectionTool', 'SearchOption', 'PrintOption', 'DownloadOption','UndoRedoTool', 'AnnotationEditTool', 'FormDesignerEditTool', 'CommentTool', 'SubmitForm']