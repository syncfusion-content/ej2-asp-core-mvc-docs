---
layout: post
title: Custom value to server in ##Platform_Name##  File Manager component | Syncfusion
description: Learn here all about How to pass custom value to server in Syncfusion ##Platform_Name##  File Manager component of Syncfusion Essential JS 2 and more.
platform: ej2-vue
control: File Manager 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Perform custom value to server in ##Platform_Name##  File Manager component

The Syncfusion Vue File Manager component allows you to pass custom values from the client to the server for various operations. This guide demonstrates how to implement this functionality for **Upload**, **Download**, and **GetImage** operations using the `beforeSend`, `beforeDownload`, and `beforeImageLoad` events respectively.

## Upload Operation

To pass custom values during the upload operation, utilize the `beforeSend` event of the File Manager component.

### Client-side Implementation

{% if page.publishingplatform == "aspnet-core" %}

```ts
<div class="file-container">
    <!-- Initialize FileManager -->
    <ejs-filemanager id="filemanager" beforeSend="beforeSend">
        <e-filemanager-ajaxsettings url="http://localhost:{port}/api/FileManager/FileOperations"
                    downloadUrl="http://localhost:{port}/api/FileManager/Download"
                    uploadUrl="http://localhost:{port}/api/FileManager/Upload"
                    getImageUrl="http://localhost:{port}/api/FileManager/GetImage">
        </e-filemanager-ajaxsettings>
    </ejs-filemanager>
</div>

<script>
    function beforeSend(args){
        args.ajaxSettings.beforeSend = function (args) {
            args.httpRequest.setRequestHeader('Authorization', 'User1');
          };
    }
</script>

```
{% elsif page.publishingplatform == "aspnet-mvc" %}

```ts
<div class="sample-container">
    <!--Replace the hosted port number in the place of "{port}"-->
    @Html.EJS().FileManager("filemanager").AjaxSettings(new Syncfusion.EJ2.FileManager.FileManagerAjaxSettings
    {
        Url = "http://localhost:{port}/api/FileManager/FileOperations",
        GetImageUrl = "http://localhost:{port}/api/FileManager/GetImage",
        UploadUrl = "http://localhost:{port}/api/FileManager/Upload",
        DownloadUrl = "http://localhost:{port}/api/FileManager/Download"
    }).BeforeSend("beforeSend").Render()
    <!-- end of File Manager control -->
</div>

<script>
    function beforeSend(args){
        args.ajaxSettings.beforeSend = function (args) {
            args.httpRequest.setRequestHeader('Authorization', 'User1');
          };
    }
</script>
```

{% endif %}

### Server-side Implementation (C#)

```typescript

public class FileManagerController : Controller
{
    ...
    [Route("FileOperations")]
    public object FileOperations([FromBody] FileManagerDirectoryContent args)
    {
        var header = HttpContext.Request.Headers["Authorization"];
        this.root = (header == "User1") ? "wwwroot\\FileBrowser" : "wwwroot\\Files";
        this.operation.RootFolder(this.basePath + "\\" + this.root);
        ...
    }

    // uploads the file(s) into a specified path
    [Route("Upload")]
    public IActionResult Upload(string path, long size, IList<IFormFile> uploadFiles, string action)
    {
        var header = HttpContext.Request.Headers["Authorization"];
        ...
    }
    ...
}


```
## Download Operation
For the download operation, use the `beforeDownload` event to send custom values to the server.

### Client-side Implementation

{% if page.publishingplatform == "aspnet-core" %}

```ts
<div class="file-container">
    <!-- Initialize FileManager -->
    <ejs-filemanager id="filemanager" beforeDownload="beforeDownload">
        <e-filemanager-ajaxsettings url="http://localhost:{port}/api/FileManager/FileOperations"
                    downloadUrl="http://localhost:{port}/api/FileManager/Download"
                    uploadUrl="http://localhost:{port}/api/FileManager/Upload"
                    getImageUrl="http://localhost:{port}/api/FileManager/GetImage">
        </e-filemanager-ajaxsettings>
    </ejs-filemanager>
</div>

<script>
      function beforeDownload(args){
        args.cancel = true;
        var obj = {
          action: 'download',
          path: args.data.path,
          names: args.data.names,
          data: args.data.data,
        };
        var xhr = new XMLHttpRequest();
        xhr.open(
          'POST',
          'http://localhost:{port}/api/FileManager/Download',
          true
        );
        xhr.responseType = 'blob';
        xhr.onload = function () {
          if (this.status === 200) {
            var name = '';
            // Getting file name from content-disposition header
            let header = xhr.getResponseHeader('Content-Disposition');
            if (header && header.indexOf('attachment') !== -1) {
              var regex = /name[^;=\n]*=((['"]).*?\2|[^;\n]*)/;
              var matches = regex.exec(header);
              if (matches != null && matches[1])
                name = matches[1].replace(/['"]/g, '');
            }
            //saving the file locally using anchor tag
            var blob = new Blob([this.response], {
              type: xhr.getResponseHeader('Content-Type'),
            });
            var anchorUrl = window.URL.createObjectURL(blob);
            if (name) {
              var anchor = document.createElement('a');
              anchor.href = anchorUrl;
              anchor.download = name;
              anchor.click();
            } else {
              window.location = anchorUrl;
            }
            setTimeout(function () {
              URL.revokeObjectURL(anchorUrl);
            }, 100);
          }
        };
        var fdata = new FormData();
        fdata.append('downloadInput', JSON.stringify(obj));
        //Custom Header Added to XHR
        xhr.setRequestHeader('Authorization', 'User1');
        xhr.send(fdata);
      }
</script>

```
{% elsif page.publishingplatform == "aspnet-mvc" %}
```ts
<div class="sample-container">
    <!--Replace the hosted port number in the place of "{port}"-->
    @Html.EJS().FileManager("filemanager").AjaxSettings(new Syncfusion.EJ2.FileManager.FileManagerAjaxSettings
    {
        Url = "http://localhost:{port}/api/FileManager/FileOperations",
        GetImageUrl = "http://localhost:{port}/api/FileManager/GetImage",
        UploadUrl = "http://localhost:{port}/api/FileManager/Upload",
        DownloadUrl = "http://localhost:{port}/api/FileManager/Download"
    }).BeforeDownload("beforeDownload").Render()
    <!-- end of File Manager control -->
</div>

<script>
    function beforeDownload(args){
        args.cancel = true;
        var obj = {
          action: 'download',
          path: args.data.path,
          names: args.data.names,
          data: args.data.data,
        };
        var xhr = new XMLHttpRequest();
        xhr.open(
          'POST',
          'http://localhost:{port}/api/FileManager/Download',
          true
        );
        xhr.responseType = 'blob';
        xhr.onload = function () {
          if (this.status === 200) {
            var name = '';
            // Getting file name from content-disposition header
            let header = xhr.getResponseHeader('Content-Disposition');
            if (header && header.indexOf('attachment') !== -1) {
              var regex = /name[^;=\n]*=((['"]).*?\2|[^;\n]*)/;
              var matches = regex.exec(header);
              if (matches != null && matches[1])
                name = matches[1].replace(/['"]/g, '');
            }
            //saving the file locally using anchor tag
            var blob = new Blob([this.response], {
              type: xhr.getResponseHeader('Content-Type'),
            });
            var anchorUrl = window.URL.createObjectURL(blob);
            if (name) {
              var anchor = document.createElement('a');
              anchor.href = anchorUrl;
              anchor.download = name;
              anchor.click();
            } else {
              window.location = anchorUrl;
            }
            setTimeout(function () {
              URL.revokeObjectURL(anchorUrl);
            }, 100);
          }
        };
        var fdata = new FormData();
        fdata.append('downloadInput', JSON.stringify(obj));
        //Custom Header Added to XHR
        xhr.setRequestHeader('Authorization', 'User1');
        xhr.send(fdata);
      }
</script>
```
{% endif %}

### Server-side Implementation (C#)

```typescript
[Route("Download")]
public IActionResult Download(string downloadInput)
{
    var header = Request.Headers["Authorization"].ToString();
    Response.Headers.Add("Access-Control-Expose-Headers", "Content-Disposition");
    ...
}

```

## GetImage Operation

For the GetImage operation, use the `beforeImageLoad` event to pass custom values as query parameters.

### Client-side Implementation

{% if page.publishingplatform == "aspnet-core" %}
```ts

<div class="file-container">
  <!-- Initialize FileManager -->
    <ejs-filemanager id="filemanager" beforeImageLoad="beforeImageLoad">
        <e-filemanager-ajaxsettings url="http://localhost:{port}/api/FileManager/FileOperations"
                    downloadUrl="http://localhost:{port}/api/FileManager/Download"
                    uploadUrl="http://localhost:{port}/api/FileManager/Upload"
                    getImageUrl="http://localhost:{port}/api/FileManager/GetImage">
        </e-filemanager-ajaxsettings>
    </ejs-filemanager>
</div>

<script>
    function beforeImageLoad(args) {
      // Add custom parameter in image URL
      args.imageUrl = args.imageUrl + "&Authorization=" + "User1";
    }
</script>

```
{% elsif page.publishingplatform == "aspnet-mvc" %}

```ts
<div class="sample-container">
    <!--Replace the hosted port number in the place of "{port}"-->
    @Html.EJS().FileManager("filemanager").AjaxSettings(new Syncfusion.EJ2.FileManager.FileManagerAjaxSettings
    {
        Url = "http://localhost:{port}/api/FileManager/FileOperations",
        GetImageUrl = "http://localhost:{port}/api/FileManager/GetImage",
        UploadUrl = "http://localhost:{port}/api/FileManager/Upload",
        DownloadUrl = "http://localhost:{port}/api/FileManager/Download"
    }).BeforeImageLoad ("beforeImageLoad").Render()
    <!-- end of File Manager control -->
</div>

<script>
    function beforeImageLoad(args) {
      // Add custom parameter in image URL
      args.imageUrl = args.imageUrl + "&Authorization=" + "User1";
    }
</script>
```
{% endif %}

### Server-side Implementation (C#)

```typescript

public class FileManagerAccessController : Controller
{
    ...
    public class FileManagerDirectoryContent1 : FileManagerDirectoryContent
    {
        public string Authorization { get; set; }
    }
    ...

    // gets the image(s) from the given path
    [Route("GetImage")]
    public IActionResult GetImage(FileManagerDirectoryContent1 args)
    {
        return this.operation.GetImage(args.Path, args.Id, false, null, null);
    }

    ...
}


```

The below file system provider allows the users to access and manage the file system which includes the server side code for custom values passing from client. To get started, clone the [provider](https://github.com/SyncfusionExamples/How-to-pass-custom-values-from-client-to-server-in-filemanager) using the following command.

```typescript

git clone https://github.com/SyncfusionExamples/How-to-pass-custom-values-from-client-to-server-in-filemanager  How-to-pass-custom-values-from-client-to-server-in-filemanager

```

After cloning, just open the project in Visual Studio and restore the NuGet packages. The root directory of the provided file system in the File Manager controller is **Files** for **User1**.

Now, just build and run the project. The project will be hosted and map the local host in the **ajaxSettings** property of the File Manager component.