---
layout: post
title: Resolve Pdfium Issue in ##Platform_Name## Pdfviewer Control | Syncfusion
description: Learn here all about Resolve Pdfium Issue in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Resolve Pdfium Issue
publishingplatform: ##Platform_Name##
documentation: ug
---


# Resolve the Pdfium issue

The issue, “The type initializer for 'Syncfusion.EJ2.PdfViewer.PdfiumNative' threw an exception” is due to the write access permission denied in the environment. The pdfium.dll will be created based on the operating system at the runtime. Due to the denial of permission, the pdfium.dll file couldn't have been created. So, copy the below x64 and x86 folders and paste them inside the folder into your project to resolve the issue or enable the write permission for that folder.

Pdfium dll: [pdfium.dll](https://www.syncfusion.com/downloads/support/directtrac/general/ze/Pdfium1334927507.zip)

N> Use both the client and server-side of the same version in your project.
<br/> Ensure whether the pdfium.dll file is created in your project during runtime. Else, place the pdfium assemblies in any of the production environment locations and refer to the path by using the ReferencePath API.

For example, if the Pdfium assembly is available in this path C:\Pdfium\x64 or D:\Pdfium\x86, the reference path should be PdfRenderer.ReferencePath = "C:/";

The parent folder has to be provided as the path in the ReferencePath API.

N> Provide this path in the Load method of the PDFViewerController.cs

N> PdfRenderer PdfRenderer = new PdfRenderer();
<br/> PdfRenderer.ReferencePath = @"C:/";

## Steps to refer the PDFium.dll

1. Extract the given file (Pdfium folder) and copy it in the sample’s root directory (parallel to Controllers folder)

2. Right-click on the pdfium.dll (both the X64 and X86 folder) and then choose the “Copy to Output Directory” property from the property window and set its value to “copy always”. This setting will ship the pdfium.dll assembly to the published location.
![Pdfium.dll settings](../../pdfviewer/images/pdfium_dll_settings.png)

3. Provide this path in the Load method of the PDFViewerController.cs
N> You need to refer the ParentFolder up to the x64/x86 folder.
*PdfRenderer.ReferencePath = _hostingEnvironment.ContentRootPath + \\Pdfium\\;*

4. Build and publish the application.

Also, install the below package, then build and run the project. This will work on Windows, Linux, and OSX operating systems.

* Syncfusion.EJ2.PdfViewer.AspNet.Core

Following these steps should resolve the issue.

## Steps to resolve the PDFium issue in Linux environment 

* The issue, “The type initializer for ‘Syncfusion.EJ2.PdfViewer.PdfiumNative’ threw an exception” occurs due to the missing of pdfium dependency in the Linux environment. To resolve this, Execute the following commands one by one to install the pdfium dependency package in the Linux machine.

```
    sudo cp -u /lib/x86_64-linux-gnu/libdl.so.2 /lib/x86_64-linux-gnu/libdl.so
    sudo apt-get update    
    sudo apt install libgdiplus
```

## Steps to resolve the PDFium issue in docker environment 

* The issue, “The type initializer for ‘Syncfusion.EJ2.PdfViewer.PdfiumNative’ threw an exception” occurs due to the missing of pdfium dependency in the docker environment. Please follow the steps below to resolve this issue on docker environment.


If you are using the PDF Viewer with Docker in .NET 6.0 framework, please incorporate the following commands into your Dockerfile to install the pdfium dependency:

```
    RUN ln -s /lib/x86_64-linux-gnu/libdl-2.24.so /lib/x86_64-linux-gnu/libdl.so
    # install System.Drawing native dependencies
    RUN apt-get update && apt-get install -y --allow-unauthenticated libgdiplus libc6-dev libx11-dev
    RUN ln -s libgdiplus.so gdiplus.dll
```

Dockerfile 6.0: [dockerfile](https://github.com/SyncfusionExamples/PdfViewer-Server/blob/master/Dockerfile) 

If you are using the PDF Viewer with Docker in .NET 8.0 framework, please incorporate the following commands into your Dockerfile to install the pdfium dependency:

```
    RUN ln -s /lib/x86_64-linux-gnu/libdl.so.2 /lib/x86_64-linux-gnu/libdl.so    
    # install System.Drawing native dependencies
    RUN apt-get update && apt-get install -y --allow-unauthenticated libgdiplus libc6-dev libx11-dev
    RUN ln -s libgdiplus.so gdiplus.dll
```

Dockerfile 8.0: [dockerfile](https://github.com/SyncfusionExamples/PdfViewer-Server/blob/master/Dockerfile_NET80) 