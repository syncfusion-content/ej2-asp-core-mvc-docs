---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Uploader Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of File Upload component from Essential JS 1 to Essential JS 2.

## Accessibility

<!-- markdownlint-disable MD038 -->
| **Behavior**           | **Property in Essential JS 1**     |        **Property in Essential JS 2**       |
| -----------------------| -----------------------------------| ------------------------------------------- |
| Localization           | **Property** : locale <br/><br/> `@Html.EJ().Uploadbox("UploadDefault")`<br/>`.Locale("es-ES")` | **Property** : locale <br/><br/> `@Html.EJS().`<br/>`Uploader("UploadFiles").`<br/>`Locale("es-ES").Render()` |
| Right to left | **Property:** enableRTL <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`EnableRTL(true)`  | **Property:** enableRTL <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`EnableRtl(true).Render()`

## File list

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Show/Hide the selected files | **Property** : showFileDetails <br/><br/> `@Html.EJ().Uploadbox("UploadDefault")`<br/>`.ShowFileDetails(false)`  | **Property** :  showFileList <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`ShowFileList(false).Render()`  |
| Customizing the file list | Not Applicable  | **Property** : template <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Template("#Templateid").Render()`  |
| Get the files in sorted form | Not Applicable | **Method:** SortFileList<br/><br/> `@Html.EJS().Uploader("UploadFiles")`<br/>`.Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").`<br/>`ej2_instances[0]; `<br/>`uploadObj.sortFileList(files);` <br/> |
| Clearing File List | Not Applicable | **Method:** ClearAll <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").`<br/>`ej2_instances[0]; `<br/>`uploadObj.clearAll();`<br/>`}` <br/> |
| Event triggers when clearing Files | Not Applicable | **Event :** clearing <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Clearing("onClearing").Render()`<br/><br/> `function onClearing(ClearingEventArgs): void  { }` <br/> |

## File selection

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Select multiple files to upload | **Property** : multipleFilesSelection <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`MultipleFilesSelection(true)`  | **Property** : multiple <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Multiple(true).Render()` |
| Set minimum file size to upload | **Not Applicable** | **Property** : minFileSize <br /><br /> `@Html.EJS().Uploader("UploadFiles").`<br/>`MinFileSize(1024).Render()` |
| Set maximum file size to upload | **Property** : fileSize <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`FileSize(5000)` | **Property** : maxFileSize <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`MaxFileSize(5000).Render()` |
| Allowed file types to select | **Property** :  extensionsAllow <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ExtensionsAllow(".zip")`  | **Property:** allowedExtensions <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AllowedExtensions(".pdf").Render()` |
| Restricted files types to select | **Property:** extensionsDeny <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ExtensionsDeny(".docx")` |   **Not Applicable** |
| Display only selected details in File list | **Property** :  customFileDetails<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`CustomFileDetails(details=> details.`<br/>`Title(false).`<br/>`Name(true).Size(true).`<br/>`Status(true).Action(false))` <br/> | **Not Applicable** |
| Options to customize File list dialog | **Property:** dialogAction <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`DialogAction(details=> details.`<br/>`Modal(false).`<br/>`CloseOnComplete(true).`<br/>`Resize(true).Drag(false).`<br/>`content("#dialogTarget"))` <br/> | **Not Applicable** |
| Customize dialog position | **Property:** dialogPosition<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`DialogPosition`<br/>`(position => position.X(300).Y(100))`<br/> | **Not Applicable** |
| Change file list key values | **Property:** dialogText<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`DialogText(details=> details.`<br/>`Title(Upload File List).Name(File Name).`<br/>`Size(File Size))`<br/> | **Not Applicable** |
| Change drop area text | **Property:**  dropAreaText<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`DropAreaText("Drop files here")`  | No separate Property to change dropAreaText. It can be customize using locale Texts |
| Change drop area height | **Property:** dropAreaHeight<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`DropAreaHeight("100%")`  | Not Applicable |
| Change drop area width | **Property:** dropAreaWidth <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`DropAreaWidth("100%")`  | Not Applicable |
| Dynamically push the file | **Property:** pushFile<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`PushFile("files")`  | Not Applicable |
| Show the files uploader in server already. | **Not Applicable** | **Property:** files <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Files(@ViewBag.datasource).Render()`<br/><br/>`public ActionResult PreloadFiles()`<br/>` { list.Add(new UploaderUploadedFiles`<br/>` { Name = "Nature", Size = 500000, `<br/>`Type = ".png" }); }`<br/>  |
| Event triggers when select the file successfully | **Event:** fileSelect <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => e.FileSelect("fileSelect"))`<br/><br/>`function fileSelect(e) {}`<br/>  | **Event:** selected<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Selected("onFileSelect").Render()`<br/><br/> `function onFileSelect(args): void  { }`<br/> |

## Upload action

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Save URL | **Property** : saveUrl <br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`SaveUrl("Uploadbox/Save")` | **Property** : saveUrl<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AsyncSettings(new Syncfusion.`<br/>`EJ2.Inputs.`<br/>`UploaderAsyncSettings `<br/>`{SaveUrl = @Url.Content("/Uploader/Save")})`<br/>`.Render()`  |
| Save URL | **Property** : saveUrl <br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`SaveUrl("Uploadbox/Save")` | **Property** : saveUrl<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AsyncSettings(new Syncfusion.`<br/>`EJ2.Inputs.`<br/>`UploaderAsyncSettings `<br/>`{SaveUrl = @Url.Content("/Uploader/Save")})`<br/>`.Render()`  |
| Save URL | **Property** : saveUrl <br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`SaveUrl("Uploadbox/Save")` | **Property** : saveUrl<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AsyncSettings(new Syncfusion.`<br/>`EJ2.Inputs.`<br/>`UploaderAsyncSettings `<br/>`{SaveUrl = @Url.Content("/Uploader/Save") })`<br/>`.Render()`  |
| Save URL | **Property** : saveUrl <br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`SaveUrl("Uploadbox/Save")` | **Property** : saveUrl<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AsyncSettings(new Syncfusion.`<br/>`EJ2.Inputs.`<br/>`UploaderAsyncSettings `<br/>`{SaveUrl = @Url.Content("/Uploader/Save")}).`<br/>`Render()`  |
| Remove URL | **Property** : removeUrl<br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`RemoveUrl("UploadBox/Remove")` | **Property** : removeUrl<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AsyncSettings(new Syncfusion.`<br/>`EJ2.Inputs.`<br/>`UploaderAsyncSettings `<br/>`{RemoveUrl = @Url.Content`<br/>`("/Uploader/Remove")})`<br/>`.Render()`  |
| Automatically upload the file when files added in to upload queue | **Property:** autoUpload <br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`AutoUpload(false)`  | **Property:** autoUpload<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AutoUpload(false).Render()`  |
| Synchronous upload | **Property:** asyncUpload<br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`AyncUpload(false)`  | No Separate Property for enabling synchronous upload.  It can be enabling by using below configuration <br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AutoUpload(false).Render()`  |
| Key to get the selected files in server side | **Property:**  uploadName<br/><br/> `@Html.EJ().Uploadbox("UploadBox").`<br/>`UploadName("Uploadkey")`  | Id of the element used as key value |
| Upload the files dynamically | **Not Applicable** | Method: upload()<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`AsyncSettings(new Syncfusion.EJ2.Inputs.`<br/>`UploaderAsyncSettings`<br/>` {SaveUrl = @Url.Content`<br/>`("/Uploader/Save"),`<br/>` RemoveUrl = @Url.Content`<br/>`("/Uploader/Remove") }).Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").`<br/>`ej2_instances[0]; `<br/>`uploadobj.upload = filesData;`<br/> |
| Event triggers before start to upload the action | **Event:** beforeSend<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.OnBeforeSend("onBeforeSend"))`<br/><br/>`function onBeforeSend(e) {}`<br/> | **Event** : uploading<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Uploading("beforeUploadStart").`<br/>`Render()`<br/><br/> `function beforeUploadStart(args)  { }`<br/>  |
| Event triggers when the upload is in progress | **Event:** inProgress<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.InProgress("uploadInprogress"))`<br/><br/>`function uploadInprogress(e) {}`<br/> | **Event** : progress<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Progress("uploadInprogress").`<br/>`Render()`<br/><br/> `function uploadInprogress(args)  { }`<br/>  |
| Event triggers when upload got success | **Event:** success<br/><br/>  `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.Success("uploadSuccess"))`<br/><br/>`function uploadSuccess(e) {}`<br/>  | **Event** : success<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Success("uploadSuccess").Render()`<br/><br/> `function uploadSuccess(args)  { }`<br/> |
| Event triggers when upload got failed | **Event:** error<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.Error("onUploadError"))`<br/><br/>`function onUploadError(e) {}`<br/>   | **Event** : failure<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Failure("onUploadFailure").Render()`<br/><br/> `function onUploadFailure(args)  { }`<br/> |
| Event triggers when the upload got started | **Event:** begin <br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.Begin("onUploadBegin"))`<br/><br/>`function onUploadBegin(e) {}`<br/> |   **Not Applicable** |
| Event triggers when cancel the upload | **Event:** cancel<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.Cancel("onUploadCancel"))`<br/><br/>`function onUploadCancel(e) {}` <br/> | **Event** : canceling<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Canceling("uploadingCancel").`<br/>`Render()`<br/><br/> `function uploadingCancel(args)  { }`<br/>  |
| Event triggers when the upload completed | **Event:** complete<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.Complete("onUploadComplete"))`<br/><br/>`function onUploadComplete(e) {}`<br/> | **Not Applicable** |

## Chunk upload

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Enabling the chunk upload | Not Applicable | **Property:** chunkSize<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`MaxFileSize(104857600).AsyncSettings(new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = @Url.Content("https://aspnetmvc.syncfusion.com/`<br/>`services/api/uploadbox/Save"), `<br/>`RemoveUrl = @Url.Content("https://aspnetmvc.syncfusion.com/`<br/>`services/api/uploadbox/Remove"), ChunkSize = 500000 }).Render()`<br/>  |
| Retry the upload automatically when it's get failed | Not Applicable | **Property:** retryCount, retryAfterDelay<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`MaxFileSize(104857600).AsyncSettings(new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = @Url.Content("https://aspnetmvc.syncfusion.com/`<br/>`services/api/uploadbox/Save"), RemoveUrl = @Url.Content("https://aspnetmvc.syncfusion.com/`<br/>`services/api/uploadbox/Remove"), ChunkSize = 500000, retryCount = 3, retryAfterDelay = 1000 }).Render()`<br/>  |
| Pause the uploading file | Not Applicable | **Method:** pause<br/><br/> `@Html.EJS().Uploader("UploadFiles").Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").ej2_instances[0]; `<br/>`uploadObj.pause = filesData;`<br/> |
| Event triggers when pausing the file | Not Applicable | **Event:** pausing<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Pausing("onPausingUpload").Render()`<br/><br/>`function onPausingUpload(args): void  { }`<br/> |
| Resuming the paused file | Not Applicable | **Method:** resume<br/><br/> `@Html.EJS().Uploader("UploadFiles").Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").ej2_instances[0];`<br/>` uploadObj.resume = filesData;`<br/> |
| Event triggers when resuming the file | Not Applicable | **Event:** resuming<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Resuming("onResumingUpload").Render()`<br/><br/> `function onResumingUpload(args): void  { }`<br/> |
| Retry the failed file | Not Applicable | **Method:** retry<br/><br/> `@Html.EJS().Uploader("UploadFiles").Render()`<br/><br/>`var uploadobj = `<br/>`document.getElementById("UploadFiles").ej2_instances[0]; `<br/>`uploadObj.retry = filesData;`<br/> |
| Cancel the failed file | Not Applicable | **Method:** cancel<br/><br/> `@Html.EJS().Uploader("UploadFiles").Render()`<br/><br/>`var uploadobj = `<br/>`document.getElementById("UploadFiles").ej2_instances[0]; `<br/>`uploadObj.cancel = filesData;`<br/> |
| Event triggers when cancel the file | Not Applicable | **Event:** canceling<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Canceling("onCancelingUpload").Render()`<br/><br/> `function onCancelingUpload(args): void  { }`<br/> |
| Event triggers when chunk file fails | Not Applicable | **Event:** chunkFailure<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`ChunkFailure("onChunkFailure").Render()`<br/><br/> `function onChunkFailure(args): void  { }`<br/> |
| Event triggers when chunk file success | Not Applicable | **Event:** chunkSuccess<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`ChunkSuccess("onChunkSuccess").Render()`<br/><br/> `function onChunkSuccess(args): void  { }`<br/> |

## Remove action

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Remove the uploaded file | Not Applicable | **Method:** remove<br/><br/> `@Html.EJS().Uploader("UploadFiles").Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").ej2_instances[0]; `<br/>`uploadObj.remove = filesData;`<br/> |
| Event triggers when the file removing succeed | **Event:** remove<br/><br/> `@Html.EJ().`<br/>`Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => e.Remove("onRemove"))`<br/><br/>`function onRemove(e) {}`<br/> | **Event:** success<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Success("onSuccess").Render()`<br/><br/> `function onSuccess(args)  { }`<br/> |
| Event triggers when the file removing fails | **Not Applicable** | **Event:** failure<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Failure("onFailure").Render()`<br/><br/> `function onFailure(args)  { }`<br/> |

## Buttons

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in essential JS 1** | **Property in essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Customize button text | **Property** : buttonText<br/><br/> `@Html.EJ().`<br/>`Uploadbox("UploadDefault").`<br/>`Browse(ButtonText.Browse).`<br/>`Upload(ButtonText.Upload).`<br/>`Cancel(ButtonText.Cancel)`<br/> | **Property** : buttons<br/><br/> `@Html.EJS().`<br/>`Uploader("UploadFiles").`<br/>`Buttons(ViewBag.UploadButtons).Render()`<br/><br/>`public ActionResult DefaultFunctionalities() { List<UploaderButton> buttons = new List<UploaderButton>() { }; buttons.Add(new UploaderButton() { browse = "Choose File", clear = "Clear Files", upload = "Upload Files"   }); ViewBag.UploadButtons = buttons; return View(); }public class DefaultButtonModel { public string browse { get; set; } public string clear { get; set; } public string upload { get; set; } }`<br/> |

## Drag and drop

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS  1** | **Property in Essential JS 2** |
| ------------ | --------------------------------| ------------------------------ |
| Enable drag and drop upload | **Property** : allowDragAndDrop<br/><br/> `@Html.EJ().`<br/>`Uploadbox("UploadDefault").`<br/>`AllowDragAndDrop(true)` | No separate Property to disabling drag and drop |
| Set custom drop area | **Not Applicable** | **Property** :  dropArea<br/><br/>  `@Html.EJS().`<br/>`Uploader("UploadFiles").`<br/>`DropArea(".control-fluid").Render()`  |

## Common

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Adding custom class to wrapper element | **Property** : cssClass<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`CssClass("Custom-Class")` | Not Applicable |
| Enable/Disable the control | **Property** : enabled<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`Enabled(false).Render()`<br/>  **Method** : enable(), disable()<br/> | **Property:** enabled<br/><br/> `@Html.EJS().`<br/>`Uploader("UploadFiles").`<br/>`Enabled(false).Render()` |
| Set height for uploader | **Property:** height<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`Height("100%")`  | **Not Applicable** |
| Set width for uploader | **Property:** width<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`Width("100%")`  | **Not Applicable** |
| Adding HTML attributes | **Property:** htmlAttributes<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`HtmlAttribute(attribute => `<br/>`attribute.Aria-label("Uploadbox"))`<br/> | **Not Applicable** |
| Event triggers when control created successfully | **Event:** create<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.Create("onCreate"))`<br/><br/>`function onCreate(e) {}`<br/>  | **Event:** created<br/><br/> `@Html.EJS().`<br/>`Uploader("UploadFiles").`<br/>`Created("onCreated").Render()`<br/><br/> `function onCreated(args)  { }`<br/> |
| Event triggers when destroy the control | **Event:** destroy<br/><br/>  `@Html.EJ().Uploadbox("UploadDefault").`<br/>`ClientSideEvents(e => `<br/>`e.Destroy("onDestroy"))`<br/><br/>`function onDestroy(e) {}`<br/> | **Not Applicable** |
| Keeping the model values in cookies | **Property:** enablePersistence<br/><br/> `@Html.EJ().Uploadbox("UploadDefault").`<br/>`EnablePersistence(true)`  | **Property:** enablePersistence<br/><br/> `@Html.EJS().`<br/>`Uploader("UploadFiles").`<br/>`EnablePersistence(false).Render()` |
| Get the selected files data | **Not Applicable** | **Method:** getFilesData<br/><br/> `@Html.EJS().Uploader("UploadFiles")`<br/>`.Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").`<br/>`ej2_instances[0]; `<br/>`uploadObj.getFilesData();`<br/> |
| Convert bytes in to MB, GB | **Not Applicable** | **Method:** bytesToSize<br/><br/> `@Html.EJS().Uploader("UploadFiles").`<br/>`Render()`<br/><br/>`var uploadobj = document.`<br/>`getElementById("UploadFiles").`<br/>`ej2_instances[0]; `<br/>`uploadObj.bytesToSize(5000);`<br/> |