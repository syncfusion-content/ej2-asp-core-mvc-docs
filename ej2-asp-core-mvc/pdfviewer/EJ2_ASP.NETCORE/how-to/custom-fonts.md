---
layout: post
title: How to change the font family in ASP .NETCORE Pdfviewer component.
description: Learn how to change the font family in Syncfusion ASP .NETCORE Pdfviewer component.
platform: ej2-asp-core-mvc
control: Change the Font Family in Type Signature
publishingplatform: ##Platform_Name##
documentation: ug
---

### Signature Field property
The Syncfusion PDF Viewer provides the ability to change the font family for Signature and Initial Field using `typeSignatureFonts` and `typeInitialFonts` property.

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Insert the following code snippet to implement the functionality for using custom fonts in Signature field.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Allura" >
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Tangerine">
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Sacramento">
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Inspiration">
```
```
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
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
```
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
```
<div style="width:100%;height:600px">
    <ejs-pdfviewer id="pdfviewer"
                   style="height:600px"
                   documentPath="https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf">
    </ejs-pdfviewer>
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
```
{% endhighlight %}
{% endtabs %}

By implementing this , you can use custom fonts in form field's signature in both `signature` and `initial` field