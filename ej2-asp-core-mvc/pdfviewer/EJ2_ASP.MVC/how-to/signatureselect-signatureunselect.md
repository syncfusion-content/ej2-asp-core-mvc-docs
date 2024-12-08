---
layout: post
title: Signature selection events in  EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about signatureSelect and signatureUnselect event in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# SignatureSelect and SignatureUnselect event

The Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer provides event-handling capabilities for various actions, including selecting and unselecting handwritten signatures. The `signatureSelect` and `signatureUnselect` events enable developers to programmatically manage the selection state of signatures within the PDF Viewer component.

**signatureSelect** 

The `signatureSelect` event triggers when a handwritten signature annotation is selected. This event allows developers to capture the signature selection and handle it programmatically, such as updating the UI or storing the selection data for further processing.

**signatureUnselect**

The `signatureUnselect` event triggers when a handwritten signature annotation is unselected. This event enables developers to manage the unselection programmatically, which can be useful for tasks like cleanup operations or updating the application's state to reflect that a signature is no longer selected.

The code snippet demonstrates how to subscribe to the `signatureSelect` and `signatureUnselect` events in the Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer component.

{% tabs %}
{% highlight html tabtitle="Standalone" %}

@{
    ViewBag.Title = "Home Page";
}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").SignatureUnselect("signatureUnselect").SignatureSelect("signatureSelect").Render()
</div>

<script>

function signatureSelect(args) { 
    console.log('Signature selected:', args);
};

function signatureUnselect(args) {
    console.log('Signature selected:', args);
};
</script>

{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}

@{
    ViewBag.Title = "Home Page";
}

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/hive-succinctly.pdf").SignatureUnselect("signatureUnselect").SignatureSelect("signatureSelect").Render()
</div>

<script>
function signatureSelect(args) { 
    console.log('Signature selected:', args);
};

function signatureUnselect(args) {
    console.log('Signature selected:', args);
};
</script>

{% endhighlight %}
{% endtabs %}

The `signatureSelect` and `signatureUnselect` events in Syncfusion<sup style="font-size:70%">&reg;</sup> PDF Viewer offer robust options for managing the state of handwritten signatures within your application. By handling these events, developers can create a more interactive and dynamic user experience, responding programmatically to signature selection and unselection.