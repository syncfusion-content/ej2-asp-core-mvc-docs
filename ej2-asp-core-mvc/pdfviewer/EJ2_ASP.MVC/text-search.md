---
layout: post
title: Text_search in ##Platform_Name## Pdfviewer Component | Syncfusion
description: Learn here all about Text_search in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Text_search
publishingplatform: ##Platform_Name##
documentation: ug
---

# Text Search in PDF Viewer component

The Text Search option in PDF Viewer is used to find and highlight the text content from the document. You can enable/disable the text search using the following code snippet.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").EnableTextSearch(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
    </div>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).EnableTextSearch(true).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
    </div>
{% endhighlight %}
{% endtabs %}

![Alt text](./images/search.png)

## Test search Features

### Real time search suggestion while typing
Entering text into the search input dynamically displays search suggestions based on the provided input. The suggestions are updated in real-time as text is typed, offering relevant matches from the available content. This feature enhances the search experience by allowing quick access to potential results while typing.

![Alt text](./images/SingleSearchPopup.png)

### Selecting Search Suggestions from the Popup
Entering text into the search input triggers a popup displaying relevant suggestions based on the input. Selecting a suggestion from the popup enables direct navigation to its occurrences in the document.

![Alt text](./images/SearchResultFromPopup.png)

### Search Text with enabling 'Match Case' checkbox 
By enabling the 'Match Case' option and entering text into the search input, only the exact case-sensitive matches in the document are highlighted. This feature allows navigation through each occurrence of the exact text match within the document.

![Alt text](./images/SearchNavigationMatchCase.png)

### Search Text without enabling 'Match Case' checkbox
When text is entered into the search input without enabling the 'Match Case' option, all instances of the text, regardless of case, are highlighted in the document. This allows easy navigation through every occurrence of the search term.

![Alt text](./images/SearchNavigationNoMatchCase.png)

### Search list of text by enabling 'Match Any Word' checkbox
When the 'Match Any Word' option is enabled, the entered text in the search input is split into individual words based on spaces. As the text is typed, the popup dynamically displays search suggestions for each word in real time, highlighting potential matches within the document.

![Alt text](./images/MultiSearchPopup.png)

## Find text method
Searches for the specified text or an array of strings within the document and returns the bounding rectangles for each occurrence. The search can be case-sensitive based on the provided parameters. If a specific page index is provided, it returns the bounding rectangles for these search strings on that page; otherwise, it returns the bounding rectangles for all pages in the document where the strings were found.

### Find and get the bounds of a text
Searches for the specified text within the document and returns the bounding rectangles of the matched text. The search can be case-sensitive based on the provided parameter. It returns the bounding rectangles for all pages in the document where the text was found. The below code snippet shows how to get the bounds of the given text:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText('pdf', false));
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-backed" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText('pdf', false));
    }
</script>

{% endhighlight %}
{% endtabs %}

### Find and get the bounds of a text on the desired page
Searches for the specified text within the document and returns the bounding rectangles of the matched text. The search can be case-sensitive based on the provided parameter. It returns the bounding rectangles for that page in the document where the text was found. The below code snippet shows how to get the bounds of the given text from the desired page:

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText('pdf', false, 7));
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-backed" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText('pdf', false, 7));
    }
</script>

{% endhighlight %}
{% endtabs %}

### Find and get the bounds of the list of text
Searches for an array of strings within the document and returns the bounding rectangles for each occurrence. The search can be case-sensitive based on the provided parameters. It returns the bounding rectangles for all pages in the document where the strings were found.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText(['pdf', 'adobe'], false));
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-backed" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText(['pdf', 'adobe'], false));
    }
</script>

{% endhighlight %}
{% endtabs %}

### Find and get the bounds of the list of text on desired page
Searches for an array of strings within the document and returns the bounding rectangles for each occurrence. The search can be case-sensitive based on the provided parameters. It returns the bounding rectangles for these search strings on that particular page where the strings were found.

{% tabs %}
{% highlight cshtml tabtitle="standalone" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText(['pdf', 'adobe'], false, 7));
    }
</script>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-backed" %}

<button type="button" onclick="findTextBounds()">FindTextBounds</button>
<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").Render()
</div>

<script>
    function findTextBounds() {
        var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
        console.log(viewer.textSearch.findText(['pdf', 'adobe'], false, 7));
    }
</script>

{% endhighlight %}
{% endtabs %}

## See also

* [Toolbar items](./toolbar)
* [Feature Modules](./feature-module)