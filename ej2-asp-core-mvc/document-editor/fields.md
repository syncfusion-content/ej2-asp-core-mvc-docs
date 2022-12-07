---
layout: post
title: Fields in ##Platform_Name## Document Editor Component | Syncfusion
component: DocumentEditor
description: Learn how to use fields in JavaScript document editor ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Fields
publishingplatform: ##Platform_Name##
documentation: ug
---

# Fields

Document Editor has preservation support for all types of fields in an existing word document without any data loss.

## Adding Fields

You can add a field to the document by using `insertField`method in `Editor` module.

```typescript

var fieldCode = 'MERGEFIELD  First Name  \\* MERGEFORMAT ';
var fieldResult = '«First Name»';
documenteditor.editor.insertField(fieldCode, fieldResult);

```

>Note: Document editor does not validate or process the field code or field result. It simply inserts the field with specified field information.

## Update fields

Document Editor provides support for updating bookmark cross reference field.

```typescript
//Update all the bookmark cross reference field in the document.
documenteditor.updateFields();
```

Bookmark cross reference fields can be updated through UI by using update fields option in `Toolbar`.

![Update bookmark cross reference field.](images/updatefields.png)

The following type of fields are automatically updated in Document Editor.

* NUMPAGES
* SECTION
* PAGE

## Get field info

You can get field code and field result of the current selected field by using `getFieldInfo` method in the `Selection` module.

```typescript
//Gets the field information of the selected field.
var fieldInfo = documenteditor.selection.getFieldInfo();
```

>Note: For nested fields, this method returns combined field code and result.

## Set field info

You can modify the field code and field result of the current selected field by using `setFieldInfo` method in the `Editor` module.

```typescript
//Gets the field information for the selected field.
var fieldInfo = documenteditor.selection.getFieldInfo();

//Modify field code
fieldInfo.code = 'MERGEFIELD  First Name  \\* MERGEFORMAT ';

//Modify field result
fieldInfo.result = '«First Name»';

//Modify field code and result of the current selected field.
documenteditor.editor.setFieldInfo(fieldInfo);

```

>Note: For nested field, entire field gets replaced completely with the specified field information.

## See Also

[Mail merge using DocIO](https://help.syncfusion.com/file-formats/docio/working-with-mail-merge)
[Mail merge demo](https://github.com/SyncfusionExamples/EJ2-Document-Editor-Web-Services/blob/master/ASP.NET%20Core/src/Controllers/DocumentEditorController.cs#L114)