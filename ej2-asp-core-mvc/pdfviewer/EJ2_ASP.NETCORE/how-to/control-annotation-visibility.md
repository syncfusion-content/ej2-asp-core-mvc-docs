---
layout: post
title: Annotations Visibility in EJ2 ASP.NET Core PdfViewer | Syncfusion
description: Learn here how to Control PDF Annotations Visibility ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Control PDF Annotations Visibility in PDF Viewer

### Overview

This guide demonstrates how to control the visibility of PDF annotations in documents loaded and saved using the Syncfusion PDF Viewer. This process allows the annotations to be visible only in the Syncfusion PDF Viewer.

### How to Control Annotation Visibility

**Step 1:** Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started/) to create a simple PDF Viewer sample.

**Step 2:** Set Up Your ASP.NET Core Component

Create an ASP.NET Core component and update the template to include a button that triggers the download operation. Additionally, create a function to save the document with the PDF annotation flag set to `noView`.


{% tabs %}
{% highlight cshtml tabtitle="Standalone" %}

@page "{handler?}"
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<button type="button" onclick="save()" style="margin-top : 60px">Download</button>

<div class="text-center">
	<ejs-pdfviewer id="pdfviewer" style="height:600px" documentPath="https://cdn.syncfusion.com/content/pdf/annotations-v1.pdf" documentLoad="documentLoaded" resourceUrl="https://cdn.syncfusion.com/ej2/27.1.48/dist/ej2-pdfviewer-lib">
    </ejs-pdfviewer>
</div>

<script type="text/javascript">
	function documentLoaded() {
		var pdfViewer = document.getElementById('pdfviewer').ej2_instances[0];
		//Code snippet to add basic annotations. You can also include other annotations as needed.
			pdfViewer.annotation.addAnnotation("Highlight", {
				bounds: [{ x: 97, y: 610, width: 350, height: 14 }],
				pageNumber: 1
			});
			pdfViewer.annotation.addAnnotation("Underline", {
				bounds: [{ x: 97, y: 723, width: 353.5, height: 14 }],
				pageNumber: 1
			});
			pdfViewer.annotation.addAnnotation("Strikethrough", {
				bounds: [{ x: 97, y: 836, width: 376.5, height: 14 }],
				pageNumber: 1
			});
		}

    function save() {
	  // Get the PDF viewer instance
	  var viewer = document.getElementById('pdfviewer').ej2_instances[0];
	  // Save the PDF as a Blob
	  viewer.saveAsBlob().then((blob) => {
	    const reader = new FileReader();
	    reader.onload = function () {
	      const base64data = reader.result;

	      // Extract the base64 encoded data
	      const base64EncodedData = base64data.split('base64,')[1];
	      const document1 = new ej.pdf.PdfDocument(base64EncodedData);

	      // Iterate through each page in the PDF
	      for (let i = 0; i < document1.pageCount; i++) {
	        const page = document1.getPage(i);

	        // Iterate through each annotation on the page
	        for (let j = 0; j < page.annotations.count; j++) {
	          const annot = page.annotations.at(j);
	          // Set annotation flag to noView
	          annot.flags |= ej.pdf.PdfAnnotationFlag.noView;
	        }
	      }

	      // Save the modified PDF as a Blob
	      document1.saveAsBlob().then((modifiedBlob) => {
	        const internalReader = new FileReader();
	        internalReader.onload = function () {
	          const modifiedBase64 = internalReader.result;

	          // Create a download link for the modified PDF
	          const downloadLink = document.createElement('a');
	          downloadLink.href = modifiedBase64;
	          downloadLink.download = 'modified.pdf';
	          downloadLink.click();
	        };

	        // Read the modified Blob as a Data URL
	        internalReader.readAsDataURL(modifiedBlob.blobData);
	      });
	    };

	    // Read the original Blob as a Data URL
	    reader.readAsDataURL(blob);
	  });
	}  
</script>

{% endhighlight %}
{% endtabs %}

By following these steps, the annotations in a PDF document can be set to be visible in the Syncfusion PDF Viewer, providing control over annotation visibility based on different platforms.

[View Sample in GitHub](https://github.com/SyncfusionExamples/asp-core-pdf-viewer-examples/tree/master/How%20to)