---
layout: post  
title: Displaying Custom stamp Items in EJ2 ASP.NET MVC PdfViewer | Syncfusion  
description: Learn how to display custom stamp items in the custom stamp in the Syncfusion ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug  
---

# Displaying Custom Items in Custom Stamp Dropdown

### Overview

This guide explains how to add and display custom items in the custom stamp dropdown menu of Syncfusion's PDF Viewer using ASP.NET MVC. This feature allows users to easily access and apply custom stamps to their PDF documents.

### Steps to Show Custom Items in Custom Stamp Dropdown

**Step 1:** Set Up the PdfViewer in Your ASP.NET MVC Project

 Follow the steps provided in the [link](https://ej2.syncfusion.com/aspnetmvc/documentation/pdfviewer/getting-started) to create a simple PDF Viewer sample.

**Step 2:** Configure Custom Stamp Settings

Within the PDF Viewer setup, utilize `PdfViewerCustomStampSettings` to specify the custom stamps that should appear in the dropdown menu.

```cs
@using Syncfusion.EJ2.PdfViewer
@{
    ViewBag.Title = "Home Page";
}
@{
    ViewData["Title"] = "Home page";

    List<Object> customStamp = new List<Object>();

    customStamp.Add(new
    {
        customStampName = "Image1",
        customStampImageSource="data:image/png;base64,...' // Provide a valid base64 or URL for the image"
    });
    customStamp.Add(new
    {
        customStampName = "Image2",
        customStampImageSource ="data:image/png;base64,...' // Provide a valid base64 or URL for the image"
    });
    PdfViewerCustomStampSettings CustomStampsSettings = new PdfViewerCustomStampSettings()
    {
        IsAddToMenu = true,
        CustomStamps = customStamp,
        EnableCustomStamp = true,
        Opacity = 1,
    };

}

<div>
    <div style="height:500px;width:100%;">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/pdf-succinctly.pdf").CustomStampSettings(CustomStampsSettings).Render()
    </div>
</div>

```
### Conclusion

By following these instructions, you can successfully configure the Syncfusion PDF Viewer to display custom items in the custom stamp dropdown, allowing users to easily apply personalized stamps to their documents.

[View sample in GitHub](https://github.com/SyncfusionExamples/mvc-pdf-viewer-examples/tree/master/How%20to)