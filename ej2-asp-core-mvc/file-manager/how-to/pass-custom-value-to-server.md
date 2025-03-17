---
layout: post
title: Custom value to server in ##Platform_Name##  File Manager control | Syncfusion
description: Learn here all about How to pass custom value to server in Syncfusion ##Platform_Name##  File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: File Manager 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Pass custom value to server in ##Platform_Name##  File Manager control

The Syncfusion File Manager control allows seamless backend server interaction by passing custom values. This enhances the functionality and security of file operations, particularly helpful for tasks like authentication, logging, or user role-based processing. In multi-user systems, it ensures file access permissions and actions are user-specific and secure. You can manage user-specific operations such as **Read**, **Delete**, **Rename**, **Create**, **Move**, **Copy**, **Details**, **Search**, **Upload**, **Download**, and **GetImage** using custom headers or query parameters. This guide demonstrates implementing these features using the **beforeSend**, **beforeDownload** and **beforeImageLoad** events. Let's explore how to achieve this in [`Physical file system provider`](https://github.com/SyncfusionExamples/ej2-aspcore-file-provider).

## 1. Setting up the File Manager and provider

{% if page.publishingplatform == "aspnet-core" %}

To create a basic File Manager control, start by following the easy steps in the [`Getting Started`](https://ej2.syncfusion.com/aspnetcore/documentation/file-manager/getting-started) guide. This will allow you to manage files and folders on your system, whether they are stored physically or in the cloud.

For connecting the File Manager to a physical file system, check out the [`Physical file provider`](https://ej2.syncfusion.com/aspnetcore/documentation/file-manager/file-system-provider#physical-file-system-provider) section. This part of the documentation will help you configure it correctly.

{% elsif page.publishingplatform == "aspnet-mvc" %}

To create a basic File Manager control, start by following the easy steps in the [`Getting Started`](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/getting-started) guide. This will allow you to manage files and folders on your system, whether they are stored physically or in the cloud.

For connecting the File Manager to a physical file system, check out the [`Physical file provider`](https://ej2.syncfusion.com/aspnetmvc/documentation/file-manager/file-system-provider#physical-file-system-provider) section. This part of the documentation will help you configure it correctly.

{% endif %}

## 2. Handling File Operations 

After setting the File Manager control with the physical file system provider, you can handle file operations by passing custom values to the server. To pass custom values during the **Read**, **Delete**, **Rename**, **Create**, **Move**, **Copy**, **Details**, **Search** and **Upload** operations, utilize the **beforeSend** event of the File Manager control. This event allows you to modify the request before it is sent to the server. You can add custom headers to the request to pass additional information to the server.

The `onBeforeSend` function is designed to enhance security by adding an authorization header to every outgoing AJAX request. Before a request is sent, this function is called, and it attaches the **Authorization** header with the value **User1** to the request. This ensures that the server can verify the request's authenticity and handle it accordingly.

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

In server-side, `FileOperations` and `Upload` methods access the **Authorization** header from the incoming HTTP request and perform the necessary operations.

```typescript

public class FileManagerController : Controller
{
    ...
    [Route("FileOperations")]
    public object FileOperations([FromBody] FileManagerDirectoryContent args)
    {
        var header = HttpContext.Request.Headers["Authorization"];
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

## 3. Handling Download Operation

For the **download** operation, use the **beforeDownload** event, setting **useFormPost** as false to use a fetch request to send the custom header in beforesend event. Here an **Authorization** header is appended to fetch request headers with the value **User1**.

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
  args.useFormPost = false;
  if (args.ajaxSettings) {
    (args.ajaxSettings as any).beforeSend = function (args: any) {
      args.fetchRequest.headers.append('Authorization', 'User1');
    };
  }
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
  args.useFormPost = false;
  if (args.ajaxSettings) {
    (args.ajaxSettings as any).beforeSend = function (args: any) {
      args.fetchRequest.headers.append('Authorization', 'User1');
    };
  }
}
</script>
```
{% endif %}

In server-side, `Download` method access the **Authorization** header from the incoming HTTP request and perform the necessary operations.

```typescript
[Route("Download")]
public object Download([FromBody] FileManagerDirectoryContent args)
{
    var header = HttpContext.Request.Headers["Authorization"];
    ...
}

```

## 4. For GetImage Operation

For the **GetImage** operation, use the **beforeImageLoad** event to pass custom value. Since the **GetImage** operation doesn't support custom headers in HTTP requests, pass the custom values along with **imageUrl** using query parameters instead.

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

In server-side, you can able to get the custom query parameter value using **Authorization** in `GetImage` method. To get the  custom query parameter value, extend the `FileManagerDirectoryContent` class and add the custom property **Authorization**.

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
        var header = args.Authorization;
        return this.operation.GetImage(args.Path, args.Id, false, null, null);
    }

    ...
}


```

> **Note:** View the complete [Github sample](https://github.com/SyncfusionExamples/How-to-pass-custom-values-from-client-to-server-in-filemanager) which includes all the above event along with service code for passing custom values to server.

