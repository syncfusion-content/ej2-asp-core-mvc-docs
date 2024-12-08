---
layout: post
title: Controlling File Downloads in EJ2 ASP.NET Core PDF Viewer| Syncfusion
description: Learn here how to Controlling File Downloads in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Controlling File Downloads in Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer

In the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer, we've introduced a new feature that enables you to manage file downloads more effectively. This feature allows you to intercept and potentially skip the download process of a PDF document, providing enhanced control over user interactions within your application.

### Using the downloadStart Event

The key to this functionality lies in the downloadStart event, which offers a mechanism to intercept the initiation of the download process. Within the event handler, you can set the cancel argument to true to programmatically prevent the download action from proceeding.

{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   downloadStart="downloadStart">
    </ejs-pdfviewer>
</div>

<script>
    function downloadStart(args) { 
        // Your custom logic here
        args.cancel = true; // Prevent download action
    };
</script>
{% endhighlight %}
{% highlight cshtml tabtitle="Server-Backed" %}

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl='/Index'
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf"
                   downloadStart="downloadStart">
    </ejs-pdfviewer>
</div>

<script>
    function downloadStart(args) { 
        // Your custom logic here
        args.cancel = true; // Prevent download action
    };
</script>

{% endhighlight %}
{% endtabs %}

By default, the cancel argument is set to `false`, indicating that the download action will proceed unless explicitly canceled by your custom logic.

### Enhanced Flexibility

By leveraging the `downloadStart` event and its cancel argument, you gain the ability to implement custom logic to control and potentially prevent download actions based on your application's specific requirements. This enhancement provides greater flexibility in managing user interactions with PDF documents, empowering you to tailor the experience according to your needs.