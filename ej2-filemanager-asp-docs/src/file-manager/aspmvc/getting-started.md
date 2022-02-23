---
title: "Getting Started"
component: "File Manager"
description: "Explains to get started with file manager control with its default functionality."
---

# Getting Started

 This section briefly explains about how to create `File Manager` component in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

> Starting with `v16.2.0.x`, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Initialize the File Manager

To get started, add the File Manager component to `index.cshtml` page which is available within the `Views/Home` folder.

In this sample demonstrates the File Manager with default view.

{% aspTab template="file-manager/getting-started", sourceFiles="HomeController_mvc.cs" %}

{% endaspTab %}

Output be like the below.

![FileManager getting started](./images/getting-started.PNG)

>**Note:** The File Manager can be rendered with `local service` for sending ajax request. Ajax request will be sent to the server which then processes the request and sends back the response. Refer Controller file for file manager service.

## File Download support

To perform the download operation, initialize the `DownloadUrl` property in a [`AjaxSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~AjaxSettings.html) of File Manager component.

{% aspTab template="file-manager/file-download-url" %}

{% endaspTab %}

## File Upload support

To perform the upload operation, initialize the `UploadUrl` property in a [`AjaxSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~AjaxSettings.html) of File Manager Component.

{% aspTab template="file-manager/file-upload-url" %}

{% endaspTab %}

## Image Preview support

To perform the image preview support in the File Manager component, need to initialize the `GetImageUrl` property in a [`AjaxSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~AjaxSettings.html) of File Manager component.

{% aspTab template="file-manager/image-preview", sourceFiles="HomeController_core.cs" %}

{% endaspTab %}

Output be like the below.

![File Manager Sample](images/getimage.png)

## File Manager Overview

By default, the File Manager component  having  extra module like [`NavigationPane`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~NavigationPaneSettings.html), [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ToolbarSettings.html), [`ContextMenu`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~ContextMenuSettings.html) module.

In this sample demonstrates the full features of the File Manager that includes toolbar, navigation pane and details view.

{% aspTab template="file-manager/overview", sourceFiles="HomeController_mvc.cs" %}

{% endaspTab %}

Output be like the below.

![FileManager overview](./images/overview.PNG)

>**Note:** The appearance of the File Manager can be customized by using [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~CssClass.html) property. This adds a css class to the root of the File Manager which can be used to add new styles or override existing styles to the File Manager

## Switching initial view of the File Manager

The initial view of the File Manager can be changed to details or largeicons view with the help of [view](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~View.html) property. By default, the File Manager will be rendered in large icons view.
When the File Manager is initially rendered, [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~Created.html) will be triggered. This event can be utilized for performing operations once the File Manager has been successfully created.

{% aspTab template="file-manager/view", sourceFiles="HomeController_mvc.cs" %}

{% endaspTab %}

Output be like the below.

![FileManager switching view ](./images/overview.PNG)

## Maintaining component state on page reload

The File Manager supports maintaining the component state on page reload. This can be achieved by enabling [enablePersistence](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~EnablePersistence.html) property which maintains the following,
* Previous view of the File Manager - [View](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~View.html)
* Previous path of the File Manager - [Path](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~Path.html)
* Previous selected items of the File Manager - [SelectedItems](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~SelectedItems.html)

For every operation in File Manager, ajax request will be sent to the server which then processes the request and sends back the response. When the ajax request is success, [success](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~Success.html) event will be triggered and [failure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~Failure.html) event will be triggered if the request gets failed.

{% aspTab template="file-manager/persistence", sourceFiles="HomeController_mvc.cs" %}

{% endaspTab %}

Output be like the below.

![FileManager enable persistence ](./images/enable_persistence.PNG)

>**Note:** The files of the current folder opened in the File Manager can be refreshed programatically by calling `refreshFiles` method

## Rendering component in right-to-left direction

It is possible to render the File Manager in right-to-left direction by setting the [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~EnableRtl.html) API to true.

{% aspTab template="file-manager/rtl", sourceFiles="HomeController_mvc.cs" %}

{% endaspTab %}

Output be like the below.

![FileManager enablertl ](./images/enable_rtl.PNG)

## Specifying the current path of the File Manager

The current path of the File Manager can be specified initially or dynamically using the [path](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.FileManager.FileManager~Path.html) property.

The following code snippet demonstrates specifying the current path in File Manager on rendering.

{% aspTab template="file-manager/path", sourceFiles="HomeController_mvc.cs" %}

{% endaspTab %}

Output be like the below.

![FileManager enablertl ](./images/path.png)