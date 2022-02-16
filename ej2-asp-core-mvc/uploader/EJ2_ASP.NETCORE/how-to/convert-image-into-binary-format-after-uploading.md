---
layout: post
title: Convert Image Into Binary Format After Uploading in ##Platform_Name## Uploader Component
description: Learn here all about Convert Image Into Binary Format After Uploading in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Convert Image Into Binary Format After Uploading
publishingplatform: ##Platform_Name##
documentation: ug
---


# Convert image into binary format after uploading

By default, the file upload control saves the uploaded image files in physical directories. Also, you can convert the images into binary format at server-side before saving the uploaded images.
To retrieve binary format of image files, convert the posted file’s input stream into binary reader and read as bytes using ReadBytes method.

Refer to the below server-side code snippet

``` csharp

[[AcceptVerbs("Post")]
public IActionResult Save(IList<IFormFile> UploadFiles)
{
    IFormFile uploadedImage = UploadFiles.FirstOrDefault();
    if (uploadedImage.ContentType.ToLower().StartsWith("image/"))
    // Check whether the selected file is image
    {
        byte[] b;
        using (BinaryReader br = new BinaryReader(uploadedImage.OpenReadStream()))
        {
            b = br.ReadBytes((int)uploadedImage.OpenReadStream().Length);
            // Convert the image in to bytes
        }
        Response.StatusCode = 200;
    }
    return Content("");
}

```

> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/Uploader/DefaultFunctionalities#/material) to understand how to browse the files which you want to upload to the server.