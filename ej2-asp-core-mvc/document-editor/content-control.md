---
layout: post
title: Content Control in Syncfusion ##Platform_Name## Document Editor Component 
description: Learn here all about Content Control in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Content Control
publishingplatform: ##Platform_Name##
documentation: ug
---


# Content Control in DocumentEditor

Document Editor provides support for inserting, editing content controls.

Content controls can be categorized based on its occurrence in a document as follows,

InlineContentControl: Among inline content inside, as a child of a paragraph. BlockContentControl: Among paragraphs and tables, as a child of a Body, HeaderFooter.

## Types of Content Controls

* Rich Text
* Plain Text
* Check Box
* Date picker
* Drop-Down List and Combo Box
* Picture

## Insert content control

Content control can be inserted using `insertContentControl` method in editor module.

{% highlight ts %}
//Insert Rich Text Content Control
container.documentEditor.editor.insertContentControl('RichText');
//Insert Rich Text Content Control with default sfdt string
var sfdt = {"sections":[{"blocks":[{"inlines":[{"text": "Hello"}]}]}]};
container.documentEditor.editor.insertContentControl('RichText', sfdt);

//Insert Plain Text Content Control
container.documentEditor.editor.insertContentControl('Text');
//Insert Plain Text Content Control with default string
container.documentEditor.editor.insertContentControl('Text', 'Hello World');

//Insert CheckBox Content Control
container.documentEditor.editor.insertContentControl('CheckBox');
//Insert CheckBox Content Control with mention checked state
container.documentEditor.editor.insertContentControl('CheckBox', true);

//Insert ComboBox Content Control
container.documentEditor.editor.insertContentControl('ComboBox');
//Insert ComboBox Content Control with items
container.documentEditor.editor.insertContentControl('ComboBox', 'One', ['One', 'Two', 'Three']);

//Insert Date Content Control
container.documentEditor.editor.insertContentControl('Date');
//Insert Date Content Control
container.documentEditor.editor.insertContentControl('Date', '01/01/2024');

//Insert DropDownList Content Control
container.documentEditor.editor.insertContentControl('DropDownList');
//Insert DropDownList Content Control with items
container.documentEditor.editor.insertContentControl('DropDownList', 'One', ['One', 'Two', 'Three']);

//Insert Picture Content Control
container.documentEditor.editor.insertContentControl('Picture');
//Insert Picture Content Control with default image
container.documentEditor.editor.insertContentControl('Picture', 'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABYAAAAWCAYAAADEtGw7AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAADgSURBVEhLY3jx4sV/WuDBafCluXH/D6ydhlWObIMPLmn8/32KPBiD2OjyKAY7+zbDsX945/91azehiBWU9IPVgVwJMxSX4SgG65jXwrGVa+v/6TOXoojBDEZ2LQh/m676/+D+/XBzQJgsg0EY5GqQgSCDsYUz2QaDMCiosIUvCKMYDFKIjK9dvYrCB3kXJIaMkfUjY5JdDEpioCCAYZCFyGbAMFkGI0fcMDUYpAgZY4s8EEYWwxWBJLsYhJHFQIYjmwHDQ9xgkGEwDCp0QAYji8EMRhYjymBq4lGDofjFfwCV5AGEIf9DQQAAAABJRU5ErkJggg==');
{% endhighlight %}

## Content Control Properties

Content control properties [`ContentControlInfo`] can be set using the [`setContentControlInfo`] 

* title : Specifies the title of the content control.
* tag: Specifies the tag associated with the content control.
* value: Specifies the value of the content control.
* canDelete: Specifies whether the content control can be deleted.
* canEdit: Specifies whether the content control can be edited.
* items: Specifies items for the content control, applicable if the type is combobox or dropdownlist.
* type : Specifies the type of content control.
* xmlString: Specifies the XML string used for data binding, XML content to be mapped within the content control.
* xmlPath?: Specifies the XPath expression for XML mapping, This path identifies the specific part of the XML data to bind to the content control.

### Enable-Disable Content Control in Document editor control

Document Editor content control can be enable/disable using the ContentControlInfo properties.

The following example illustrates to disable the content control after inserting the content control in DocumentEditorContainer.

{% highlight ts %}
container.documentEditor.editor.insertContentControl('RichText','{{product_code}}');
var contentControlInfo = container.documentEditor.selection.getContentControlInfo();
//Specifies whether the content control can be Edited.
// To Disable Editing use "true" and To Enable Editing use "false".
contentControlInfo.canEdit = true;
//Specifies whether the content control can be Deleted.
// To Disable Deleting use "true" and To Enable Editing use "false".
contentControlInfo.canDelete = true;
container.documentEditor.editor.setContentControlInfo(contentControlInfo);
{% endhighlight %}

## Import content control properties

Content control properties can be import using `importContentControlData`

{% highlight ts %}
var data = [];
var contentControlData = { title: placeHolderPrefix + 'Name', tag: '', value: 'John', canDelete: false, canEdit: false, type: 'RichText' };
container.documentEditor.importContentControlData(data);
{% endhighlight %}

## Export content control properties

Content control properties can be exported using the `exportContentControlData`

{% highlight ts %}
var contentControlInfos = container.documentEditor.exportContentControlData();
{% endhighlight %}

## Reset content control

Content control properties can be reset using the `resetcontentcontroldata`

{% highlight ts %}
var data = [];
var contentControlData = { title: placeHolderPrefix + 'Name', tag: '', value: 'John', canDelete: false, canEdit: false, type: 'RichText' };
data.push(contentControlData);
container.documentEditor.resetContentControlData(data);
{% endhighlight %}

N> Content control with custom XML mapping of file type WordML is converted as normal Rich Text Content Control to provide lossless round-tripping upon saving.
