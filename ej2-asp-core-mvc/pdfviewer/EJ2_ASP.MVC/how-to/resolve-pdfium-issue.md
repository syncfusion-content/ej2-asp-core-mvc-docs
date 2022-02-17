---
layout: post
title: Resolve Pdfium Issue in ##Platform_Name## Pdfviewer Component
description: Learn here all about Resolve Pdfium Issue in Syncfusion ##Platform_Name## Pdfviewer component and more.
platform: ej2-asp-core-mvc
control: Resolve Pdfium Issue
publishingplatform: ##Platform_Name##
documentation: ug
---


# Resolve the Pdfium issue

The issue, “The type initializer for 'Syncfusion.EJ2.PdfViewer.PdfiumNative' threw an exception” is due to the write access permission denied in the environment. The pdfium.dll will be created based on the operating system at the runtime. Due to the denial of permission, the pdfium.dll file couldn't have been created. So, copy the below x64 and x86 folders and paste them inside the folder into your project to resolve the issue or enable the write permission for that folder.

Pdfium dll: [pdfium.dll](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Pdfium1515619754.zip)

> Kindly use both the client and server-side of the same version in your project.
> Ensure whether the pdfium.dll file is created in your project during runtime. Else, place the pdfium assemblies in any of the production environment locations and refer to the path by using the ReferencePath API.

For example, if the Pdfium assembly is available in this path C:\Pdfium\x64 or D:\Pdfium\x86, the reference path should be PdfRenderer.ReferencePath = "C:/";

The parent folder has to be provided as the path in the ReferencePath API.

> Provide this path in the Load method of the PDFViewerController.cs

> PdfRenderer PdfRenderer = new PdfRenderer();
> PdfRenderer.ReferencePath = @"C:/";

## Steps to refer the Pdfium.dll

1. Extract the given file (Pdfium folder) and copy it in the sample’s root directory (parallel to Controllers folder)

2. Right-click on the pdfium.dll (both the X64 and X86 folder) and then choose the “Copy to Output Directory” property from the property window and set its value to “copy always”. This setting will ship the pdfium.dll assembly to the published location.
![Pdfium.dll settings](../../pdfviewer/images/pdfium_dll_settings.png)

3. Provide this path in the Load method of the PDFViewerController.cs
> You need to refer the ParentFolder up to the x64/x86 folder.
*PdfRenderer.ReferencePath = _hostingEnvironment.ContentRootPath + \\Pdfium\\;*

4. Build and publish the application.

Also, install only the package related to that OS, then build and run the project on that platform. For Windows, Linux, and OSX operating systems, use the following corresponding libraries:

•   Syncfusion.EJ2.PdfViewer.AspNet.Core.Linux
•   Syncfusion.EJ2.PdfViewer.AspNet.Core.Windows
•   Syncfusion.EJ2.PdfViewer.AspNet.Core.OSX

Following these steps should resolve the issue.