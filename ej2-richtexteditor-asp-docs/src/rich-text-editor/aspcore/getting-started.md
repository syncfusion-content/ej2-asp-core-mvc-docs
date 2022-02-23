---
title: "Rich Text Editor Getting started"
component: "Rich Text Editor"
description: "This section explains how to create a simple Syncfusion ASP.NET CORE Rich Text Editor control and configure its functionalities."
---

# Getting Started

This section briefly explains how to include simple Rich Text Editor control in your ASP.NET Core application. You can refer to [ASP.NET Core Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Adding Rich Text Editor Control to the Application

* Add the Rich Text Editor control in view page to render our Syncfusion controls.

{% aspTab template="rich-text-editor/basic/default", sourceFiles="controller.cs" %}

{% endaspTab %}

### Initialize from iframe element

Initialize the Rich Text Editor on `<div>` element as shown below and set the `enable` field of [`iframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_IframeSettings) property as true to render the Rich Text Editor content in an `<iframe>` and its isolated from the rest of the page.

{% aspTab template="rich-text-editor/basic/iframe", sourceFiles="controller.cs" %}

{% endaspTab %}

## Configure the Toolbar

Configure the toolbar with the tools using items field of the [`toolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property as your application requires.

{% aspTab template="rich-text-editor/basic/toolbar", sourceFiles="controller.cs" %}

{% endaspTab %}

> `|` and `-` can insert a vertical and horizontal separator lines in the toolbar.

## Insert Images and Links

The `Image` module inserts an image into RichTextEditor’s content area, and the `Link` module links external resources such as website URLs, to selected text in the RichTextEditor’s content, respectively.

The link inject module adds a link icon to the toolbar and the image inject module adds an image icon to the toolbar.

Specifies the items to be rendered in quick toolbar based on the target element such image, link and text element. The quick toolbar opens to customize the element by clicking the target element.

{% aspTab template="rich-text-editor/basic/image", sourceFiles="controller.cs" %}

{% endaspTab %}

## Send formatted content using XmlHttpRequest

The Html string of the Rich Text Editor can be passed from View to the Controller through the `XMLHttpRequest` `Post` action. The HTML value binds to the corresponding mapped controller, and you can access it in the Post action parameter.

{% aspTab template="rich-text-editor/basic/rtevalue", sourceFiles="controller.cs" %}

{% endaspTab %}

## Retrieve the Formatted Content

To retrieve the editor contents, use [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_Value) property of Rich Text Editor.

```javascript
  var rteValue = this.rteObj.value;
```

Or, you can use the public method, `getHtml` to retrieve the Rich Text Editor content.

```javascript
  var rteValue = this.rteObj.getHtml();
```

To fetch the Rich Text Editor's text content, use `getText` method of Rich Text Editor.

```javascript
  var rteValue = this.rteObj.getText();
```

## Retrieve the number of characters in Rich Text Editor

To get the maximum number of characters in the Rich Text Editor's content, use `getCharCount`

```typescript
  let rteCount = this.rteObj.getCharCount();
```

The final output will be displayed as follows

{% aspTab template="rich-text-editor/basic/link", sourceFiles="controller.cs" %}

{% endaspTab %}

> You can refer to our [ASP.NET Core Rich Text Editor](https://www.syncfusion.com/aspnet-core-ui-controls/wysiwyg-rich-text-editor) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Rich Text Editor example](https://ej2.syncfusion.com/aspnetcore/RichTextEditor/DefaultFunctionalities#/material) that shows how to render the rich text editor tools.

## See Also

* [How to insert Emoticons](https://ej2.syncfusion.com/aspnetcore/RichTextEditor/InsertEmoticons#/material)
* [Blog posting using Rich Text Editor](https://ej2.syncfusion.com/aspnetcore/RichTextEditor/Forums#/material)
* [How to change the editor type](./formation/)
* [How to render the iframe](./iframe/)
* [How to render the toolbar in inline mode](./inline-mode/)
