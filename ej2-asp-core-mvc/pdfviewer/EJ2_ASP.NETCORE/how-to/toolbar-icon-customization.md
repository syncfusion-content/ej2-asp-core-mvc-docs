---
layout: post
title: Toolbar customization in ##Platform_Name## Pdfviewer Control | Syncfusion
description: Learn here all about Toolbar customization in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize toolbar in PDF Viewer component

## How to customize existing toolbar in PDF Viewer component

PDF Viewer allows you to customize(add, show, hide, enable, and disable) existing items in a toolbar.

* Add - New items can defined by **CustomToolbarItemModel** and with existing items in [**ToolbarSettings**](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerToolbarSettings.html) property. Newly added item click action can be defined in `toolbarclick`.

* Show, Hide - Existing items can be shown or hidden using the [`ToolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerToolbarSettings.html) property. Pre-defined toolbar items are available with [`ToolbarItem`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PdfViewer.PdfViewerToolbarSettings.html#Syncfusion_EJ2_PdfViewer_PdfViewerToolbarSettings_ToolbarItems).

* Enable, Disable - Toolbar items can be enabled or disable using `enabletoolbaritem`.

{% tabs %}
{% highlight html tabtitle="Standalone" %}


<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   resourceUrl='https://cdn.syncfusion.com/ej2/24.1.41/dist/ej2-pdfviewer-lib'
                   toolbarClick="toolbarClick">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    window.onload = function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        var toolItem = {
            prefixIcon: 'e-icons e-paste',
            id: 'print',
            tooltipText: 'Custom toolbar item',
            align: 'left'
        };
        pdfViewer.toolbarSettings = {
            showTooltip: true,
            toolbarItems: [
                toolItem,
                "OpenOption",
                "PageNavigationTool",
                "MagnificationTool",
                "PanTool",
                "SelectionTool",
                "SearchOption",
                "PrintOption",
                "DownloadOption",
                "UndoRedoTool",
                "AnnotationEditTool",
                "FormDesignerEditTool",
                "CommentTool",
                "SubmitForm"
            ]
        };
    }

    // Define the toolbarClick event handler
    function toolbarClick(args) {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];

        if (args.item && args.item.id === 'print') {
            pdfViewer.printModule.print();
        } else if (args.item && args.item.id === 'download') {
            pdfViewer.download();
        }
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   serviceUrl="/Index"
                   toolbarClick="toolbarClick">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
    window.onload = function () {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        var toolItem = {
            prefixIcon: 'e-icons e-paste',
            id: 'print',
            tooltipText: 'Custom toolbar item',
            align: 'left'
        };
        pdfViewer.toolbarSettings = {
            showTooltip: true,
            toolbarItems: [
                toolItem,
                "OpenOption",
                "PageNavigationTool",
                "MagnificationTool",
                "PanTool",
                "SelectionTool",
                "SearchOption",
                "PrintOption",
                "DownloadOption",
                "UndoRedoTool",
                "AnnotationEditTool",
                "FormDesignerEditTool",
                "CommentTool",
                "SubmitForm"
            ]
        };
    }

    // Define the toolbarClick event handler
    function toolbarClick(args) {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];

        if (args.item && args.item.id === 'print') {
            pdfViewer.printModule.print();
        } else if (args.item && args.item.id === 'download') {
            pdfViewer.download();
        }
    }
</script>

{% endhighlight %}
{% endtabs %}

>Note : Default value of toolbar items is ['OpenOption', 'PageNavigationTool','MagnificationTool', 'PanTool', 'SelectionTool', 'SearchOption', 'PrintOption', 'DownloadOption','UndoRedoTool', 'AnnotationEditTool', 'FormDesignerEditTool', 'CommentTool', 'SubmitForm']