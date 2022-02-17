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

<!-- markdownlint-disable MD033 -->
| **Behavior**           | **Property in Essential JS 1**     |        **Property in Essential JS 2**       |
| -----------------------| -----------------------------------| ------------------------------------------- |
| Localization           | **Property** : locale <br/><br/> `<ej-upload-box id="UploadDefault" locale="es-ES"></ej-upload-box>` | **Property** : locale <br/><br/> `<ejs-uploader id="UploadFiles" locale="es-ES"></ejs-uploader>` |
| Right to left | **Property:** enableRTL <br/><br/> `<ej-upload-box id="UploadDefault" enable-rtl="true"></ej-upload-box>`  | **Property:** enableRTL <br/><br/> `<ejs-uploader id="UploadFiles" enableRtl="true"></ejs-uploader>`

## File list

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Show/Hide the selected files | **Property** : showFileDetails <br/><br/> `<ej-upload-box id="UploadDefault" show-file-details="false"></ej-upload-box>`  | **Property** :  showFileList <br/><br/> `<ejs-uploader id="UploadFiles" showFileList="false"></ejs-uploader>`  |
| Customizing the file list | Not Applicable  | **Property** : template <br/><br/> `<ejs-uploader id="UploadFiles" template="#Templateid"></ejs-uploader>`  |
| Get the files in sorted form | Not Applicable | **Method:** SortFileList<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.sortFileList(files);` <br/> |
| Clearing File List | Not Applicable | **Method:** ClearAll <br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.clearAll();`<br/>`}` <br/> |
| Event triggers when clearing Files | Not Applicable | **Event :** clearing <br/><br/> `<ejs-uploader id="UploadFiles" clearing="onClearing" ></ejs-uploader>`<br/><br/> `function onClearing(ClearingEventArgs): void  { }` <br/> |

## File selection

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Select multiple files to upload | **Property** : multipleFilesSelection <br/><br/> `<ej-upload-box id="UploadDefault" multiple-file-selection="true"></ej-upload-box>`  | **Property** : multiple <br/><br/> `<ejs-uploader id="UploadFiles" multiple="true" ></ejs-uploader>` |
| Set minimum file size to upload | **Not Applicable** | **Property** : minFileSize <br /><br /> `<ejs-uploader id="UploadFiles" minFileSize="1024" ></ejs-uploader>` |
| Set maximum file size to upload | **Property** : fileSize <br/><br/> `<ej-upload-box id="UploadDefault" file-sie=5000></ej-upload-box>` | **Property** : maxFileSize <br/><br/> `<ejs-uploader id="UploadFiles" maxFileSize="5000" ></ejs-uploader>` |
| Allowed file types to select | **Property** :  extensionsAllow <br/><br/> `<ej-upload-box id="UploadDefault" extensions-allow=".zip"></ej-upload-box>`  | **Property:** allowedExtensions <br/><br/> `ejs-uploader id="UploadFiles" allowedExtensions=".pdf" >` |
| Restricted files types to select | **Property:** extensionsDeny <br/><br/> `<ej-upload-box id="UploadDefault" extensions-deny=".docx"></ej-upload-box>` |   **Not Applicable** |
| Display only selected details in File list | **Property** :  customFileDetails<br/><br/> `<ej-upload-box id="UploadDefault">`<br/><br/>`<e-dialog-text title="false" name="true" size="true" status="true"/></ej-upload-box>` <br/> | **Not Applicable** |
| Options to customize File list dialog | **Property:** dialogAction <br/><br/> `<ej-upload-box id="UploadDefault"><ej-dialog id="dialog" modal="false closeoncomplete="true" resize="true" drag="false" content="#dialogtarget"></ej-dialog></ej-upload-box>` <br/> | **Not Applicable** |
| Customize dialog position | **Property:** dialogPosition<br/><br/> `<ej-upload-box id="UploadDefault"> <e-dialog-position x-value="20" y-value="20" /></ej-upload-box>`<br/> | **Not Applicable** |
| Change file list key values | **Property:** dialogText<br/><br/> `<ej-upload-box id="UploadDefault">`<br/><br/>`<e-dialog-text title="Upload File List" name="File Name" size="File Size"/></ej-upload-box>`<br/> | **Not Applicable** |
| Change drop area text | **Property:**  dropAreaText<br/><br/> `<ej-upload-box id="UploadDefault" drop-area-text="Drop files here"></ej-upload-box>`  | No separate Property to change dropAreaText. It can be customize using locale Texts |
| Change drop area height | **Property:** dropAreaHeight<br/><br/> `<ej-upload-box id="UploadDefault" drop-area-height="100%"></ej-upload-box>`  | Not Applicable |
| Change drop area width | **Property:** dropAreaWidth <br/><br/> `<ej-upload-box id="UploadDefault" drop-area-width="100%"></ej-upload-box>`  | Not Applicable |
| Dynamically push the file | **Property:** pushFile<br/><br/> `<ej-upload-box id="UploadDefault" push-file="files"></ej-upload-box>`  | Not Applicable |
| Show the files uploader in server already. | **Not Applicable** | **Property:** files <br/><br/> `<ejs-uploader id="UploadFiles">`<br/>`<e-uploader-files><e-uploader-uploadedfiles name="Nature" Size=500000 type=".png"></e-uploader-uploadedfiles></e-uploader-files></ejs-uploader>`<br/>  |
| Event triggers when select the file successfully | **Event:** fileSelect <br/><br/> `<ej-upload-box id="UploadDefault" fileSelect="onFileSelect">`<br/><br/>`function onFileSelect(e) {}`<br/>  | **Event:** selected<br/><br/> `<ejs-uploader id="UploadFiles" selected="onFileSelect" ></ejs-uploader>`<br/><br/> `function onFileSelect(args): void  { }`<br/> |

## Upload action

<!-- markdownlint-disable MD038 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Save URL | **Property** : saveUrl <br/><br/> `<ej-upload-box id="UploadDefault"` <br/>`save-url= "//mvc.syncfusion.com/`<br/> `Services/FileUpload/UploadBox/saveFiles"></ej-upload-box>` | **Property** : saveUrl<br/><br/> `@{var asyncSettings = `<br/>`new Syncfusion.EJ2.Inputs.` <br/>`UploaderAsyncSettings`<br/>` { SaveUrl = "/Uploader/Save"}; }` <br/>`<ejs-uploader id="UploadFiles" asyncSettings="@asyncSettings" >` <br/>`</ejs-uploader>`  |
| Remove URL | **Property** : removeUrl<br/><br/> `<ej-upload-box id="UploadDefault" `<br/>` remove-url="//mvc.syncfusion.com/`<br/>`Services/FileUpload/UploadBox/removeFiles"></ej-upload-box>` | **Property** : removeUrl<br/><br/> `@{var asyncSettings = `<br/>`new Syncfusion.EJ2.Inputs.`<br/>`UploaderAsyncSettings `<br/>`{ RemoveUrl = "/Uploader/Remove"}; }`<br/>`<ejs-uploader id="UploadFiles" asyncSettings="@asyncSettings" >`<br/>`</ejs-uploader>`  |
| Automatically upload the file when files added in to upload queue | **Property:** autoUpload <br/><br/> `<ej-upload-box id="UploadDefault" auto-upload="false">`  | **Property:** autoUpload<br/><br/> `<ejs-uploader id="UploadFiles"`<br/>`autoUpload="false" >`<br/>`</ejs-uploader>`  |
| Synchronous upload | **Property:** asyncUpload<br/><br/> `<ej-upload-box id="UploadDefault" aync-upload="false">`  | No Separate Property for enabling synchronous upload.  It can be enabling by using below configuration <br/><br/> `<ejs-uploader id="UploadFiles"`<br/>`autoUpload="false" >`<br/>`</ejs-uploader>`  |
| Key to get the selected files in server side | **Property:**  uploadName<br/><br/> `<ej-upload-box id="UploadDefault" upload-name="Uploadkey"`  | Id of the element used as key value |
| Upload the files dynamically | **Not Applicable** | Method: upload()<br/><br/> `@{ var asyncSettings = `<br/>`new Syncfusion.EJ2.Inputs.`<br/>`UploaderAsyncSettings `<br/>`{ SaveUrl = "/Uploader/Save", `<br/>`RemoveUrl = "/Uploader/Remove"}; }`<br/>`<ejs-uploader id="UploadFiles" `<br/>`asyncSettings="@asyncSettings" >`<br/>`</ejs-uploader> var uploadobj = `<br/>`document.getElementById`<br/>`("UploadFiles").ej2_instances[0];`<br/>`uploadobj.upload = filesData;`<br/> |
| Event triggers before start to upload the action | **Event:** beforeSend<br/><br/> `<ej-upload-box id="UploadDefault" beforeSend="onBeforeSend">`<br/><br/>`function onBeforeSend(e) {}`<br/> | **Event** : uploading<br/><br/> `<ejs-uploader id="UploadFiles" uploading="beforeUploadStart" >`<br/>`</ejs-uploader>`<br/><br/> `function beforeUploadStart(): void  { }`<br/>  |
| Event triggers when the upload is in progress | **Event:** inProgress<br/><br/> `<ej-upload-box id="UploadDefault" inprogress="uploadInprogress">`<br/><br/>`function uploadInprogress(e) {}`<br/> | **Event** : progress<br/><br/> `<ejs-uploader id="UploadFiles" progress="uploadInprogress" ></ejs-uploader>`<br/><br/> `function uploadInprogress(args)  { }`<br/>  |
| Event triggers when upload got success | **Event:** success<br/><br/>  `<ej-upload-box id="UploadDefault" Success="onUploadSuccess">`<br/><br/>`function onUploadSuccess(e) {}`<br/>  | **Event** : success<br/><br/> `<ejs-uploader id="UploadFiles"`<br/>`success="uploadSuccess" >`<br/>`</ejs-uploader>`<br/><br/> `function uploadSuccess(args)  { }`<br/> |
| Event triggers when upload got failed | **Event:** error<br/><br/> `<ej-upload-box id="UploadDefault" Error="onUploadError">`<br/><br/>`function onUploadError(e) {}`<br/>   | **Event** : failure<br/><br/> `<ejs-uploader id="UploadFiles" failure="onUploadFailure" ></ejs-uploader>`<br/><br/> `function onUploadFailure(args)  { }`<br/> |
| Event triggers when the upload got started | **Event:** begin <br/><br/> `<ej-upload-box id="UploadDefault" begin="onUploadBegin">`<br/><br/>`function onUploadBegin(e) {}`<br/> |   **Not Applicable** |
| Event triggers when cancel the upload | **Event:** cancel<br/><br/> `<ej-upload-box id="UploadDefault" cancel="onUploadCancel">`<br/><br/>`function onUploadCancel(e) {}` <br/> | **Event** : canceling<br/><br/> `<ejs-uploader id="UploadFiles" canceling="uploadingCancel" ></ejs-uploader>`<br/><br/> `function uploadingCancel(args)  { }`<br/>  |
| Event triggers when the upload completed | **Event:** complete<br/><br/> `<ej-upload-box id="UploadDefault" complete="onUploadComplete">`<br/><br/>`function onUploadComplete(e) {}`<br/> | **Not Applicable** |

## Chunk upload

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Enabling the chunk upload | Not Applicable | **Property:** chunkSize<br/><br/> `@{var asyncSettings = new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = "/Uploader/Save", RemoveUrl = "/Uploader/Remove", ChunkSize = 500000 }; } <ejs-uploader id="UploadFiles" maxFileSize="104857600" asyncSettings="@asyncSettings" ></ejs-uploader>`<br/>  |
| Retry the upload automatically when it's get failed | Not Applicable | **Property:** retryCount, retryAfterDelay<br/><br/> `@{var asyncSettings = new Syncfusion.EJ2.Inputs.UploaderAsyncSettings { SaveUrl = "/Uploader/Save", RemoveUrl = "/Uploader/Remove", ChunkSize = 500000, retryCount=3, retryAfterDelay= 1000 }; } <ejs-uploader id="UploadFiles" maxFileSize="104857600" asyncSettings="@asyncSettings" ></ejs-uploader>`<br/>  |
| Pause the uploading file | Not Applicable | **Method:** pause<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.pause = filesData;`<br/> |
| Event triggers when pausing the file | Not Applicable | **Event:** pausing<br/><br/> `<ejs-uploader id="UploadFiles" pausing="onPausingUpload" ></ejs-uploader>`<br/><br/>`function onPausingUpload(args): void  { }`<br/> |
| Resuming the paused file | Not Applicable | **Method:** resume<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.resume = filesData;`<br/> |
| Event triggers when resuming the file | Not Applicable | **Event:** resuming<br/><br/> `<ejs-uploader id="UploadFiles" resuming="onResumingUpload" ></ejs-uploader>`<br/><br/> `function onResumingUpload(args): void  { }`<br/> |
| Retry the failed file | Not Applicable | **Method:** retry<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.retry = filesData;`<br/> |
| Cancel the failed file | Not Applicable | **Method:** cancel<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.cancel = filesData;`<br/> |
| Event triggers when cancel the file | Not Applicable | **Event:** canceling<br/><br/> `<ejs-uploader id="UploadFiles" canceling="onCancelingUpload" ></ejs-uploader>`<br/><br/> `function onCancelingUpload(args): void  { }`<br/> |
| Event triggers when chunk file fails | Not Applicable | **Event:** chunkFailure<br/><br/> `<ejs-uploader id="UploadFiles" chunkFailure="onChunkFailure" ></ejs-uploader>`<br/><br/> `function onChunkFailure(args): void  { }`<br/> |
| Event triggers when chunk file success | Not Applicable | **Event:** chunkSuccess<br/><br/> `<ejs-uploader id="UploadFiles" chunkSuccess="onChunkSuccess" ></ejs-uploader>`<br/><br/> `function onChunkSuccess(args): void  { }`<br/> |

## Remove action

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Remove the uploaded file | Not Applicable | **Method:** remove<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.remove = filesData;`<br/> |
| Event triggers when the file removing succeed | **Event:** remove<br/><br/> `<ej-upload-box id="UploadDefault" remove="onRemove">`<br/><br/>`function onRemove(e) {}`<br/> | **Event:** success<br/><br/> `<ejs-uploader id="UploadFiles" success="onSuccess" ></ejs-uploader>`<br/><br/> `function onSuccess(args)  { }`<br/> |
| Event triggers when the file removing fails | **Not Applicable** | **Event:** failure<br/><br/> `<ejs-uploader id="UploadFiles" failure="onFailure" ></ejs-uploader>`<br/><br/> `function onFailure(args)  { }`<br/> |

## Buttons

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in essential JS 1** | **Property in essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Customize button text | **Property** : buttonText<br/><br/> `<ej-upload-box id="UploadDefault"><e-button-text browse="buttontext.browse" cancel="buttontext.cancel" close="buttontext.close" /></ej-upload-box>`<br/> | **Property** : buttons<br/><br/> `<ejs-uploader id="UploadFiles" buttons="ViewBag.button" ></ejs-uploader>`<br/><br/>`public IActionResult DefaultFunctionalities() { ViewBag.button = new { Browse = "Choose File", Clear = "Clear Files", upload = "Upload Files"`<br/> |

## Drag and drop

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS  1** | **Property in Essential JS 2** |
| ------------ | --------------------------------| ------------------------------ |
| Enable drag and drop upload | **Property** : allowDragAndDrop<br/><br/> `<ej-upload-box id="UploadDefault" allow-drag-and-drop="true" ></ej-upload-box>` | No separate Property to disabling drag and drop |
| Set custom drop area | **Not Applicable** | **Property** :  dropArea<br/><br/>  `<ejs-uploader id="UploadFiles" dropArea=".control-fluid" ></ejs-uploader>`  |

## Common

<!-- markdownlint-disable MD033 -->
| **Behavior** | **Property in Essential JS 1** | **Property in Essential JS 2** |
| ------------ | ------------------------------ | ------------------------------ |
| Adding custom class to wrapper element | **Property** : cssClass<br/><br/> `<ej-upload-box id="UploadDefault" css-class="Custom-Class" ></ej-upload-box>` | Not Applicable |
| Enable/Disable the control | **Property** : enabled<br/><br/> `<ej-upload-box id="UploadDefault" enabled="false" ></ej-upload-box>`<br/>  **Method** : enable(), disable()<br/> | **Property:** enabled<br/><br/> `<ejs-uploader id="UploadFiles" enabled="false" ></ejs-uploader>` |
| Set height for uploader | **Property:** height<br/><br/> `<ej-upload-box id="UploadDefault" height="100%" ></ej-upload-box>`  | **Not Applicable** |
| Set width for uploader | **Property:** width<br/><br/> `<ej-upload-box id="UploadDefault" width="100%" ></ej-upload-box>`  | **Not Applicable** |
| Adding HTML attributes | **Property:** htmlAttributes<br/><br/> `@{       Dictionary<string, object> htmlAttribute = new Dictionary<string, object>(); htmlAttribute.Add("aria-label");}`<br/><br/>`<ej-upload-box id="UploadDefault" html-attribute="htmlAttribute" ></ej-upload-box>`<br/> | **Not Applicable** |
| Event triggers when control created successfully | **Event:** create<br/><br/> `<ej-upload-box id="UploadDefault" create="onCreate">`<br/><br/>`function onCreate(e) {}`<br/>  | **Event:** created<br/><br/> `<ejs-uploader id="UploadFiles" created="onCreated" ></ejs-uploader>`<br/><br/> `function onCreated(args)  { }`<br/> |
| Event triggers when destroy the control | **Event:** destroy<br/><br/>  `<ej-upload-box id="UploadDefault" destroy="onDestroy">`<br/><br/>`function onDestroy(e) {}`<br/> | **Not Applicable** |
| Keeping the model values in cookies | **Property:** enablePersistence<br/><br/> `<ej-upload-box id="UploadDefault" enable-persistence="true"></ej-upload-box>`  | **Property:** enablePersistence<br/><br/> `<ejs-uploader id="UploadFiles" enablePersistence="false" ></ejs-uploader>` |
| Get the selected files data | **Not Applicable** | **Method:** getFilesData<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.getFilesData();`<br/> |
| Convert bytes in to MB, GB | **Not Applicable** | **Method:** bytesToSize<br/><br/> `<ejs-uploader id="UploadFiles" ></ejs-uploader>`<br/><br/>`var uploadobj = document.getElementById("UploadFiles").ej2_instances[0]; uploadObj.bytesToSize(5000);`<br/> |