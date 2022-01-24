---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Check File Size Before Uploading It of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Check File Size Before Uploading It
publishingplatform: ##Platform_Name##
documentation: ug
---


# Check file size before uploading it

By using [uploading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Uploader.html#Syncfusion_EJ2_Inputs_Uploader_Uploading) event, you can get the file size before upload it to server.
File object contains the file size in bytes only.
You can convert the size to standard formats (`KB` or `MB`) using **bytesToSize** method.

{% aspTab template="uploader/check-file-size", sourceFiles="check-file-size.cs,index.css" %}

{% endaspTab %}

> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.