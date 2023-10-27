---
layout: post
title: Load Documents in ##Platform_Name## Pdfviewer Component
description: Learn here all about Load Documents in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load Documents
publishingplatform: ##Platform_Name##
documentation: ug
---

# Load PDF documents dynamically

The PDF Viewer server library allows to switch or load the PDF documents dynamically after the initial load operation. To achieve this, load the PDF document as a base64 string or file name in PDF Viewer control using the **Load()** method dynamically.

The following steps are used to load the PDF document dynamically.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Use the following code snippet to load PDF document using base64 string.


{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button type="button" onclick="load1()">LoadDocumentFromBase64</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type ="text/javascript">

    // Load a Base64 String
    function load1() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
       
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button type="button" onclick="load1()">LoadDocumentFromBase64</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl='/Index'
                   documentPath="https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type ="text/javascript">

    // Load a Base64 String
    function load1() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.load("data:application/pdf;base64," + addBase64String, null);
       
    }

</script>

{% endhighlight %}
{% endtabs %}

**Step 3:** Use the following code snippet to load PDF document using document name.


{% tabs %}
{% highlight html tabtitle="Standalone" %}

<button type="button" onclick="load2()">LoadDocument</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type ="text/javascript">

    // load document using file path.
    function load2() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.load("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf",null)
    }
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

<button type="button" onclick="load2()">LoadDocument</button>

<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   serviceUrl='/Index'
                   documentPath="https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf">
    </ejs-pdfviewer>
</div>

<script type ="text/javascript">

    // load document using file path.
    function load2() {
        var viewer = document.getElementById('pdfviewer').ej2_instances[0];
        viewer.load("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf",null)
    }
</script>

{% endhighlight %}
{% endtabs %}

[View sample in GitHub]()