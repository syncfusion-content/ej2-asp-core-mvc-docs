---
layout: post
title: FlatData in Syncfusion ##Platform_Name## File Manager Control | Syncfusion
description: Learn here all about Flat Data in Syncfusion ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: FlatData
publishingplatform: ##Platform_Name##
documentation: ug
---

# Rendering Flat Data in the File Manager Control

{% if page.publishingplatform == "aspnet-core" %}

The File Manager uses a flat data JSON as an array of objects for rendering, eliminating the need to define [ajaxSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_AjaxSettings) url. To load a folder data as an array of objects, use the File Manager control's [FileSystemData](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_FileSystemData) object. This means you no longer need to use a separate service provider, as you can integrate services like Google, Amazon, Azure, and others directly into your code using the FileManager's action events.

**Event Information**

Event Name | Description
 ---  | ---
[beforeDelete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeDelete) | This event is triggered before the deletion of a file or folder occurs. It can be utilized to prevent the deletion of specific files or folders. Any actions, such as displaying a spinner for deletion, can be implemented here.
[delete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Delete) | This event is triggered after the file or folder is deleted successfully. The deleted file or folder details can be retrieved here. Additionally, custom elements' visibility can be managed here based on the application's use case.
[beforeFolderCreate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeFolderCreate) | This event is triggered before a folder is created. It allows for the restriction of folder creation based on the application's use case.
[folderCreate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_FolderCreate) | This event is triggered when a folder is successfully created. It provides an opportunity to retrieve details about the newly created folder.
[search](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Search) | This event is triggered when a search action occurs in the search bar of the File Manager control. It triggers each character entered in the input during the search process.
[beforeRename](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeRename) | This event is triggered when a file or folder is about to be renamed. It allows for the restriction of the rename action for specific folders or files by utilizing the cancel option.
[rename](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Rename) | This event is triggered when a file or folder is successfully renamed. It provides an opportunity to fetch details about the renamed file.
[beforeMove](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeMove) | This event is triggered when a file or folder begins to move from its current path through a copy/cut and paste action.
[move](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Move) | This event is triggered when a file or folder is pasted into the destination path.

## Local data

The FileManager can be populated with local data that contains the array of [FileSystemData](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_FileSystemData) objects with `parentId` mapping.

To render the root-level folder, specify the `parentId` as null, or there is no need to specify the `parentId` in the array of `FileSystemData` objects.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/flat-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FlatDataController_core.cs" %}
{% include code-snippet/file-manager/flat-data/FlatDataController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The File Manager uses a flat data JSON as an array of objects for rendering, eliminating the need to define [ajaxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_AjaxSettings) url. To load a folder data as an array of objects, use the File Manager control's [FileSystemData](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_FileSystemData) object. This means you no longer need to use a separate service provider, as you can integrate services like Google, Amazon, Azure, and others directly into your code using the FileManager's action events.

**Event Information**

Event Name | Description
 ---  | ---
[beforeDelete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeDelete) | This event is triggered before the deletion of a file or folder occurs. It can be utilized to prevent the deletion of specific files or folders. Any actions, such as displaying a spinner for deletion, can be implemented here.
[delete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Delete) | DeleteEventArgs | path, itemData, cancel. | This event is triggered after the file or folder is deleted successfully. The deleted file or folder details can be retrieved here. Additionally, custom elements' visibility can be managed here based on the application's use case.
[beforeFolderCreate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeFolderCreate) | This event is triggered before a folder is created. It allows for the restriction of folder creation based on the application's use case.
[folderCreate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_FolderCreate) | This event is triggered when a folder is successfully created. It provides an opportunity to retrieve details about the newly created folder.
[search](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Search) | This event is triggered when a search action occurs in the search bar of the File Manager control. It triggers each character entered in the input during the search process.
[beforeRename](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeRename) | This event is triggered when a file or folder is about to be renamed. It allows for the restriction of the rename action for specific folders or files by utilizing the cancel option.
[rename](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Rename) | This event is triggered when a file or folder is successfully renamed. It provides an opportunity to fetch details about the renamed file.
[beforeMove](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_BeforeMove) | This event is triggered when a file or folder begins to move from its current path through a copy/cut and paste action.
[move](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_Move) | This event is triggered when a file or folder is pasted into the destination path.

## Local data

The FileManager can be populated with local data that contains the array of [FileSystemData](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_FileSystemData) object with `parentId` mapping.

To render the root-level folder, specify the `parentId` as null, or there is no need to specify the `parentId` in the array of `FileSystemData`  objects.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/flat-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FlatDataController_core.cs" %}
{% include code-snippet/file-manager/flat-data/FlatDataController_core.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/flat-data/razor  %}
{% endhighlight %}
{% highlight c# tabtitle="FlatDataController_mvc.cs" %}
{% include code-snippet/file-manager/flat-data/FlatDataController_mvc.cs %}
{% endhighlight %}
{% highlight c# tabtitle="ServiceController.cs" %}
{% include code-snippet/file-manager/flat-data/ServiceController.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}