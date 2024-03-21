---
layout: post
title: Open and Close Bookmark in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about Open and Close Bookmark in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open and Close Bookmark pane programmatically

The PDF Viewer library allows you to open the Bookmark pane programmatically using the **openBookmarkPane()** method.

The following steps are used to open the Bookmark.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Insert the following code snippet to implement the functionality for opening the Bookmark pane:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="openBookmark()">Open Bookmark Pane</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function openBookmark() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.bookmarkViewModule.openBookmarkPane();
    }
</script>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button type="button" onclick="openBookmark()">Open Bookmark Pane</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function openBookmark() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfViewer.bookmarkViewModule.openBookmarkPane();
    }
</script>

{% endhighlight %}
{% endtabs %}

Similarly, to close the Bookmark pane programmatically, employ the following code snippet:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="closeBookmark()">Close Bookmark Pane</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
 function closeBookmark() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // close Bookmark pane
        pdfViewer.bookmarkViewModule.closeBookmarkPane();
    }
</script>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<button type="button" onclick="closeBookmark()">Close Bookmark Pane</button>

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function closeBookmark() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        // close Bookmark pane
        pdfViewer.bookmarkViewModule.closeBookmarkPane();
    }
</script>

{% endhighlight %}
{% endtabs %}