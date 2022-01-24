---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Achieve File Upload Programmatically of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Achieve File Upload Programmatically
publishingplatform: ##Platform_Name##
documentation: ug
---


# Achieve file upload programmatically

You can upload a file programmatically using `upload` method.
The selected files data, get from `getFilesData` public method in uploader.

The upload method behaves differently based on its arguments.
* If this method receives any files as arguments, those files only start to upload.
* If it has no argument then all the selected files are will start to upload.

{% aspTab template="uploader/dynamic-upload", sourceFiles="dynamic-upload.cs,index.css" %}

{% endaspTab %}

> You can also explore [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.