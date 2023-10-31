---
layout: post
title: Show Bookmark in ##Platform_Name## Pdfviewer Component
description: Learn here all about Show Bookmark in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Show Bookmark
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Bookmark

The PDF Viewer server library allows you to show the bookmark programmatically by setting the [**enableBookmark**](https://ej2.syncfusion.com/javascript/documentation/api/pdfviewer/#enablebookmark) property to `true`. We can also disable the bookmark by setting the property to `false`.

N>Default value of `enableBookmark` property is true.

The following steps are used to show the bookmark.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to Show the Bookmark.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   enableBookmark="true">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   serviceUrl='/Index'
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   enableBookmark="true">
    </ejs-pdfviewer>
</div>

{% endhighlight %}
{% endtabs %}

[View sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to/Show%20Bookmark)