---
layout: post
title: How to convert images into binary format in ##Platform_Name## | Syncfusion
description: Convert uploaded images to binary format server-side in the Syncfusion ASP.NET Core File Upload using BinaryReader and ReadBytes on the input stream.
platform: ej2-asp-core-mvc
control: Convert Image Into Binary Format After Uploading
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to convert uploaded images to binary in ASP.NET Core File Upload

By default, the File Upload control saves the uploaded image files in physical directories. Additionally, you can convert the images into binary format on the server side before saving the uploaded images.

To retrieve the binary format of image files, convert the posted file’s input stream into a `BinaryReader` and read it as bytes using the `ReadBytes` method.

Refer to the following server-side code snippet.

``` csharp

[AcceptVerbs("Post")]
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
            // Convert the image into bytes
        }
        Response.StatusCode = 200;
    }
    return Content("");
}

```

N> Explore the [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.