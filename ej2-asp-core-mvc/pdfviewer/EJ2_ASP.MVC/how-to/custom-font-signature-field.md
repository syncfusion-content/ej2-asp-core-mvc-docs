---
layout: post
title: How to change the font family in Syncfusion ASP .MVC.
description: Learn how to change the font family in Form Field's Type Signature in Syncfusion ASP .MVC Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# To Change the Font Family 
Change the Font Family in Type Signature of the Syncfusion PDF Viewer by adding a custom css stylesheet to the document , and then apply the desired font family to the type signature element. Include the Google font link in the HTML head section to apply the Google Font.

### Signature Field property
The Syncfusion PDF Viewer provides the ability to change the font family for Signature and Initial Field using `typeSignatureFonts` and `typeInitialFonts` property.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Insert the following code snippet to implement the functionality for using custom fonts in Signature field.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Allura" >
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Tangerine">
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Sacramento">
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Inspiration">
``` 

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ChangeFontFamily("changeFontFamily").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
	function changeFontFamily()
	{
		var pdfviewer=document.getElementById('pdfviewer').ej2_instances[0];
		pdfviewer.SignatureFieldSettings.typeSignatureFonts = [
		'Allura',
		'Tangerine',
		'Sacramento',
		'Inspiration',
		];
	}
</script>

{% endhighlight %}
{% endtabs %}

### Initial Field property
Insert the following code snippet to implement the functionality for using custom fonts in Initial field.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Allura" >
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Tangerine">
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Sacramento">
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Inspiration">
```

<div style="width:100%;height:600px">
    @Html.EJS().PdfViewer("pdfviewer").ChangeFontFamily("changeFontFamily").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").Render()
</div>

<script>
	function changeFontFamily()
	{
		var pdfviewer=document.getElementById('pdfviewer').ej2_instances[0];
		pdfviewer.InitialFieldSettings.typeInitialFonts = [
		'Allura',
		'Tangerine',
		'Sacramento',
		'Inspiration',
		];
	}
</script>

{% endhighlight %}
{% endtabs %}

By implementing this , you can use custom fonts in form field's signature in both `signature` and `initial` field