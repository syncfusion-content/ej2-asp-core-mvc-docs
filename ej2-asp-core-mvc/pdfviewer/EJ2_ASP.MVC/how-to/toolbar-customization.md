---
layout: post
title: Toolbar_customization in ##Platform_Name## Pdfviewer Component
description: Learn here all about Toolbar_customization in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Toolbar_customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the toolbar

The PDF Viewer provides API for user interactions options provided in it's built-in toolbar. Using this we can create our own User Interface for toolbar actions in application level by hiding the default toolbar. The following steps are used to create the custom toolbar for PDF Viewer,

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create simple PDF Viewer sample.

**Step 2:** Hide the default toolbar of PDF Viewer using below code snippet,

```html
@Html.EJS().PdfViewer("pdfviewer")
.ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/"))
.EnableToolbar(false).EnableThumbnail(false)
.DocumentLoad("documentLoaded").PageChange("pageChanged")
.DocumentPath("Hive_Succinctly.pdf").Render()
```

**Step 3:** Add EJ2 Toolbar for perform primary actions like Open, Previous page, Next page, Go to page,Print and Download using the following code snippet,

```html
    @Html.EJS().Toolbar("topToolbar").Height("56px").Items(new List<ToolbarItem> {
new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-pv-open-document-icon",TooltipText = "Open",Align=ItemAlign.Left,Click="openFile"},
new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-pv-previous-page-navigation-icon",TooltipText = "Previous Page",Align=ItemAlign.Center,Click="previousClicked",Id="previousPage"},
new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-pv-next-page-navigation-icon", TooltipText = "Next Page",Align=ItemAlign.Center,Click="nextClicked",Id="nextPage"},
new ToolbarItem {Template="<div class=''><input type='text' class='e-input-group e-pv-current-page-number' id='currentPage'/></div>" ,PrefixIcon = "e-pv-next-page-navigation-icon", TooltipText = "Page Number",Align=ItemAlign.Center},
new ToolbarItem { Type = ItemType.Input, Template="<div class=''><span class='e-pv-total-page-number' id='totalPage'>of 0</span></div>" , PrefixIcon = "e-pv-next-page-navigation-icon", TooltipText = "Page Number",Click="currentPageClicked",Align=ItemAlign.Center},
new ToolbarItem { Type = ItemType.Button,  PrefixIcon = "e-pv-print-document-icon" ,TooltipText = "Print",Align=ItemAlign.Right,Click="printClicked"},
new ToolbarItem { Type = ItemType.Button,  PrefixIcon = "e-pv-download-document-icon" ,TooltipText = "Download",Align=ItemAlign.Right,Click="downloadClicked"},
}).Render()
<input type ="file" id="fileUpload" accept=".pdf" style="display:block;visibility:hidden;width:0;height:0;">
```

**Step 3:** Add EJ2 Toolbar for perform magnification actions in PDF Viewer using following code snippet,

```html

@Html.EJS().Toolbar("magnificationToolbar").Items(new List<ToolbarItem> {
new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-pv-fit-page", TooltipText = "Fit to page",Click="pageFitClicked"},
new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-pv-zoom-in-icon",TooltipText = "Zoom in",Click="zoomInClicked" },
new ToolbarItem { Type = ItemType.Button, PrefixIcon = "e-pv-zoom-out-icon", TooltipText = "Zoom out",Click="zoomOutClicked"},
}).Render()

```

**Step 4:** Add the following style to achieve the custom toolbar styling,

```html
<style>
    #pdfviewer {
        display: block;
        height: 641px;
    }
    #magnificationToolbar {
        background: transparent;
        height: auto;
        width: 200px;
        position: absolute;
        z-index: 1001;
        top: calc(100% - 110px);
        left: calc(100% - 120px);
        transform: rotate(90deg);
        border-width: 0px;
    }
    .e-pv-zoom-out-icon {
        transform: rotate(-90deg);
    }
    .material .e-pv-current-page-number {
        border-width: 1px;
    }
    div#magnificationToolbar.e-toolbar .e-toolbar-items {
        background: transparent;
    }

    #magnificationToolbar.e-toolbar .e-tbar-btn {
        border-radius: 50%;
        min-height: 30px;
        min-width: 30px;
    }

    #topToolbar {
        top: 0px;
        z-index: 1001;
    }

    .e-pv-current-page-number {
        width: 46px;
        height: 28px;
        text-align: center;
    }

    .e-icons {
        font-family: "e-icons";
        font-style: normal;
        font-variant: normal;
        font-weight: normal;
        line-height: 1;
        text-transform: none;
    }

    .e-pv-icon::before {
        font-family: 'e-icons';
    }

    .e-pv-icon-search::before {
        font-family: 'e-icons';
        font-size: 12px;
    }
    .e-pv-download-document-icon::before {
        content: '\e914';
    }

    .e-pv-print-document-icon::before {
        content: '\e917';
    }

    .e-pv-previous-page-navigation-icon::before {
        content: '\e910';
    }

    .e-pv-next-page-navigation-icon::before {
        content: '\e911';
    }

    .e-pv-zoom-out-icon::before {
        content: '\e912';
    }

    .e-pv-zoom-in-icon::before {
        content: '\e91d';
    }
    .e-pv-fit-page::before {
        content: '\e91b';
    }
    .e-pv-open-document-icon::before {
        content: '\e91c';
    }
    @@font-face {
        font-family: "e-icons";
        font-style: normal;
        font-weight: normal;
        src: url(data:application/x-font-ttf;charset=utf-8;base64,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ZWd1bGFyY3VzdG9tLXRvb2xiYXJbMTkwOF1jdXN0b20tdG9vbGJhclsxOTA4XVZlcnNpb24gMS4wY3VzdG9tLXRvb2xiYXJbMTkwOF1Gb250IGdlbmVyYXRlZCB1c2luZyBTeW5jZnVzaW9uIE1ldHJvIFN0dWRpb3d3dy5zeW5jZnVzaW9uLmNvbQAgAGMAdQBzAHQAbwBtAC0AdABvAG8AbABiAGEAcgBbADEAOQAwADgAXQBSAGUAZwB1AGwAYQByAGMAdQBzAHQAbwBtAC0AdABvAG8AbABiAGEAcgBbADEAOQAwADgAXQBjAHUAcwB0AG8AbQAtAHQAbwBvAGwAYgBhAHIAWwAxADkAMAA4AF0AVgBlAHIAcwBpAG8AbgAgADEALgAwAGMAdQBzAHQAbwBtAC0AdABvAG8AbABiAGEAcgBbADEAOQAwADgAXQBGAG8AbgB0ACAAZwBlAG4AZQByAGEAdABlAGQAIAB1AHMAaQBuAGcAIABTAHkAbgBjAGYAdQBzAGkAbwBuACAATQBlAHQAcgBvACAAUwB0AHUAZABpAG8AdwB3AHcALgBzAHkAbgBjAGYAdQBzAGkAbwBuAC4AYwBvAG0AAAAAAgAAAAAAAAAKAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAOAQIBAwEEAQUBBgEHAQgBCQEKAQsBDAENAQ4BDwAIVG9wLWljb24LZG93bi1hcnJvdzIKUFZfWm9vbW91dAlQVl9ab29taW4LUFZfRG93bmxvYWQLUFZfQm9va21hcmsJUFZfU2VhcmNoCFBWX1ByaW50C1BWX1ByZXZpb3VzB1BWX05leHQIUFZfQ2xvc2UMUFZfRml0VG9QYWdlB1BWX09wZW4AAA==) format('truetype');
    }
</style>
```

>The icons are embedded in the font file used in above code snippet.

**Step 5:** Add the following scripts for performing user interaction in PDF Viewer in code behind

```html
<script>
    var currentPageBox;
    var matchCase = false;
    var filename;
    window.onload = function () {
        currentPageBox = document.getElementById('currentPage');
        currentPageBox.value = '1';
        document.getElementById('fileUpload').addEventListener('change', readFile, false);
        currentPageBox.addEventListener('keypress', () => {
            var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
            var currentPage = document.getElementById('currentPage');
            if ((event.which < 48 || event.which > 57) && event.which !== 8 && event.which !== 13) {
                event.preventDefault();
                return false;
            } else {
                var currentPageNumber = parseInt((currentPage).value);
                if (event.which === 13) {
                    if (currentPageNumber > 0 && currentPageNumber <= pdfViewer.pageCount) {
                        pdfViewer.navigation.goToPage(currentPageNumber);
                    } else {
                        (currentPage).value = pdfViewer.currentPageNumber.toString();
                    }
                }
                return true;
            }
        });
    }
    function openFile() {
        document.getElementById('fileUpload').click();
    }
    function readFile(evt) {
        var upoadedFiles = evt.target.files;
        var uploadedFile = upoadedFiles[0];
        filename = upoadedFiles[0].name;
        var reader = new FileReader();
        reader.readAsDataURL(uploadedFile);
        reader.onload = function () {
            var obj = document.getElementById('pdfviewer').ej2_instances[0];
            var uploadedFileUrl = this.result;
            obj.load(uploadedFileUrl, null);
            obj.fileName = filename;
            var currentPageBox = document.getElementById('currentPage');
            currentPageBox.value = '1';
            var pageCount = document.getElementById('totalPage');
            pageCount.textContent = 'of ' + obj.pageCount;
        }
    }
    function previousClicked() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.navigation.goToPreviousPage();
    }
    function nextClicked() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.navigation.goToNextPage();
    }
    function printClicked() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.print.print();
    }
    function downloadClicked() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.download();
    }
    function pageFitClicked() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.magnification.fitToPage();
    }
    function zoomInClicked() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.magnification.zoomIn();
    }
    function zoomOutClicked() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.magnification.zoomOut();
    }
    function pageChanged() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        var currentPage = document.getElementById('currentPage');
        (currentPage).value = pdfViewer.currentPageNumber;
        updatePageNavigation();
    }
    function onCurrentPageBoxKeypress(event) {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        var currentPageBox = document.getElementById('currentPage');
        if ((event.which < 48 || event.which > 57) && event.which !== 8 && event.which !== 13) {
            event.preventDefault();
            return false;
        }
        else {
            var currentPageNumber = parseInt(currentPageBox.value);
            if (event.which === 13) {
                if (currentPageNumber > 0 && currentPageNumber <= viewer.pageCount) {
                    viewer.navigation.goToPage(currentPageNumber);
                }
                else {
                    currentPageBox.value = viewer.currentPageNumber.toString();
                }
            }
            return true;
        }
    }

    function currentPageClicked() {
        var currentPage = document.getElementById('currentPage');
        (currentPage).select();
    }
    function documentLoaded() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        var pageCount = document.getElementById('totalPage');
        pageCount.textContent = 'of ' + pdfViewer.pageCount;
        updatePageNavigation();
    }
    function updatePageNavigation() {
        var toolbarObj = document.getElementById('topToolbar').ej2_instances[0];
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        if (pdfViewer.currentPageNumber === 1) {
            toolbarObj.enableItems(document.getElementById('previousPage'), false);
            toolbarObj.enableItems(document.getElementById('nextPage'), true);
        } else if (pdfViewer.currentPageNumber === pdfViewer.pageCount) {
            toolbarObj.enableItems(document.getElementById('previousPage'), true);
            toolbarObj.enableItems(document.getElementById('nextPage'), false);
        } else {
            toolbarObj.enableItems(document.getElementById('previousPage'), true);
            toolbarObj.enableItems(document.getElementById('nextPage'), true);
        }
    }
    function updateZoomButtons() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        var toolbarObj = document.getElementById('topToolbar').ej2_instances[0];
        if (pdfViewer.zoomPercentage <= 50) {
            toolbarObj.enableItems(document.getElementById('zoomIn'), true);
            toolbarObj.enableItems(document.getElementById('zoomOut'), false);
            toolbarObj.enableItems(document.getElementById('fitPage'), true);
        } else if (viewer.zoomPercentage >= 400) {
            toolbarObj.enableItems(document.getElementById('zoomIn'), false);
            toolbarObj.enableItems(document.getElementById('zoomOut'), true);
            toolbarObj.enableItems(document.getElementById('fitPage'), true);
        } else {
            toolbarObj.enableItems(document.getElementById('zoomIn'), true);
            toolbarObj.enableItems(document.getElementById('zoomOut'), true);
            toolbarObj.enableItems(document.getElementById('fitPage'), true);
        }
    }
</script>

```

Sample :
[https://ej2.syncfusion.com/aspnetcore/PdfViewer/Default#/material](https://ej2.syncfusion.com/aspnetcore/PdfViewer/Default#/material)