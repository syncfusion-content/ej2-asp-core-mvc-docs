---
layout: post
title: Organize Pages with EJ2 ASP.NET Core PDF Viewer | Syncfusion
description: Learn here all about Organize Pages in ASP.NET Core Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Organize Pages Feature in ASP.NET Core PDF Viewer control
 
## Introduction

Welcome to the User Guide for the Organize Pages feature in EJ2 PDF Viewer. This powerful feature allows you to manage your PDF documents efficiently by organizing pages seamlessly. Whether you need to add new pages, remove unnecessary ones, or adjust page orientation, this feature has got you covered.
 
## Getting Started

To access the Organize Pages feature, simply open the PDF document in the EJ2 PDF Viewer and navigate to the toolbar. Look for the `Organize Pages` option to begin utilizing these capabilities.
 
## Key Functionalities

- **Add New Pages:** Easily integrate additional content by adding new pages to your document. Simply select the option to insert new pages and customize them as needed.

- **Remove Pages:** Streamline your document management process by removing unnecessary pages with ease. Select the pages you wish to delete and confirm to remove them from the document.
 
- **Rotate Pages:** Resolve orientation issues by rotating pages clockwise or counterclockwise as required. This feature ensures that your document displays correctly, maintaining clarity and readability.
 
- **Select All Pages:** Make uniform adjustments and modifications by conveniently selecting all pages at once. This allows for efficient editing and formatting across the entire document.
 
- **Real-Time Updates:** Experience instant updates as any changes made to the page organization are instantly reflected within the PDF Viewer. Simply click the **Save** button to ensure that your modifications are preserved.
 
- **Save As Feature:** Preserve your edits by utilizing the **Save As** feature. This allows you to download the modified version of the PDF document for future reference, ensuring that your changes are stored securely.

## Organize Pages Features

Organize pages support allows you to rotate, rearrange, insert, rearrange, copy and delete from a PDF document using a miniature preview of the PDF pages.

* Click the `organize pages` button in the left pane, this displays the organize pages pane in the PDF Viewer.

### Rotating PDF Pages

You can rotate PDF pages to ensure they are oriented correctly. The Rotate icon allows you to:

* `Rotate Clockwise`: Rotate the selected pages 90 degrees clockwise.

* `Rotate Counterclockwise`: Rotate the selected pages 90 degrees counterclockwise.

### Rearrange PDF Pages

* `Drag and Drop` : Click on a page thumbnail and drag it to the desired position within the document. Release it to rearrange the order of the pages.

### Inserting New Pages

You can add new pages to your document effortlessly

* `Insert Blank Pages Left` : Use the icon to insert a blank page to the left of the selected page.

* `Insert Blank Pages Right`: Use the icon to insert a blank page to the right of the selected page.

### Deleting PDF Pages

Removing unwanted pages from your document is simple

* `Select Pages to Delete`: Click on the page thumbnails you wish to remove. You can select multiple pages at once.

* `Delete Selected Pages`: Use the delete option in the organize pages delete icon to remove the selected pages from the document.

### Copying PDF Pages

For documentation purposes or to duplicate content within your PDF

* `Select Pages to Copy`: Click on the image on the organize PDF thumbnails you wish to copy. Use the copy option to duplicate the selected pages. When a page is copied, the duplicate is automatically added to the right of the selected page. Multiple copies can be achieved using the toolbar action.

## API's supported

**enablePageOrganizer:** This API enables or disables the page organizer feature in the PDF Viewer. By default, it is set to `true`, indicating that the page organizer is enabled.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   enablePageOrganizer="true">
    </ejs-pdfviewer>
</div>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   enablePageOrganizer="true">
    </ejs-pdfviewer>
</div>
{% endhighlight %}
{% endtabs %}

**isPageOrganizerOpen:** This API determines whether the page organizer dialog will be displayed automatically when a document is loaded into the PDF Viewer. By default, it is set to `false`, meaning the dialog is not displayed initially.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   isPageOrganizerOpen="true">
    </ejs-pdfviewer>
</div>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   isPageOrganizerOpen="true">
    </ejs-pdfviewer>
</div>
{% endhighlight %}
{% endtabs %}

**pageOrganizerSettings:** This API allows control over various page management functionalities within the PDF Viewer. It includes options to enable or disable actions such as deleting, inserting, rotating, and rearranging pages. By default, all these actions are enabled.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   pageOrganizerSettings= pageOrganizerSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerPageOrganizerSettings
                   {canDelete: true, canInsert: true, canRotate: true, canCopy: true, canRearrange: true })">
    </ejs-pdfviewer>
</div>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl="/api/PdfViewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   pageOrganizerSettings= pageOrganizerSettings="@(new Syncfusion.EJ2.PdfViewer.PdfViewerPageOrganizerSettings
                   {canDelete: true, canInsert: true, canRotate: true, canCopy: true, canRearrange: true })">
    </ejs-pdfviewer>
</div>
{% endhighlight %}
{% endtabs %}

**openPageOrganizer:** This API opens the page organizer dialog within the PDF Viewer, providing access to manage PDF pages.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="closePageOrganizer()">Close PageOrganizer Pane</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   resourceUrl="https://cdn.syncfusion.com/ej2/24.1.41/dist/ej2-pdfviewer-lib">
    </ejs-pdfviewer>
</div>

<script>
    function closePageOrganizer() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Close Page Organizer panel.
        pdfViewer.pageOrganizer.closePageOrganizer(););
    }
</script>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button type="button" onclick="closePageOrganizer()">Close PageOrganizer Pane</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl='/Index'
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    function openPageOrganizer() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Close Page Organizer panel.
        pdfViewer.pageOrganizer.openPageOrganizer();
    }
</script>

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="openPageOrganizer()">Open PageOrganizer Pane</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
 function openPageOrganizer() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Open Page Organizer panel.
        pdfViewer.pageOrganizer.openPageOrganizer();
    }
</script>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button type="button" onclick="openPageOrganizer()">Open PageOrganizer Pane</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function openPageOrganizer() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Open Page Organizer panel.
        pdfViewer.pageOrganizer.openPageOrganizer();
    }
</script>

{% endhighlight %}
{% endtabs %}

**closePageOrganizer:** This API closes the currently open page organizer dialog within the PDF Viewer, if it is present. It allows users to dismiss the dialog when done with page organization tasks.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="closePageOrganizer()">Close PageOrganizer Pane</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   resourceUrl="https://cdn.syncfusion.com/ej2/24.1.41/dist/ej2-pdfviewer-lib">
    </ejs-pdfviewer>
</div>

<script>
    function closePageOrganizer() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Close Page Organizer panel.
        pdfViewer.pageOrganizer.closePageOrganizer(););
    }
</script>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button type="button" onclick="closePageOrganizer()">Close PageOrganizer Pane</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl='/Index'
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script>
    function closePageOrganizer() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // Close Page Organizer panel.
        pdfViewer.pageOrganizer.closePageOrganizer();
    }
</script>

{% endhighlight %}
{% endtabs %}

## Keyboard shortcuts

The following keyboard shortcuts are available at miniature preview mode to organize the PDF pages

* **Ctrl+Z** : Undo the last action performed.
* **Ctrl+Y** : Redo the action that was undone

#### Conclusion

With the Organize Pages feature in EJ2 PDF Viewer, managing your PDF documents has never been easier. Whether you're adding new content, adjusting page orientation, or removing unnecessary pages, this feature provides the tools you need to streamline your document management workflow. Explore these capabilities today and take control of your PDF documents with ease!

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Organize%20pdf)