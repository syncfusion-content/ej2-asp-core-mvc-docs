---
layout: post
title: Getting Started with ##Platform_Name## Rich Text Editor Component
description: Checkout and learn about getting started with ##Platform_Name## Rich Text Editor component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to include simple Rich Text Editor control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Adding Rich Text Editor Control to the Application

* Add the Rich Text Editor control in view page to render our Syncfusion controls.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/default/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/default/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Initialize from iframe element

Initialize the Rich Text Editor on `<div>` element as shown below and set the enable field of [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property as true to render the Rich Text Editor content in an `<iframe>` and its isolated from the rest of the page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/iframe/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/iframe/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/iframe/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/iframe/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Configure the Toolbar

Configure the toolbar with the tools using items field of the [`ToolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_ToolbarSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_) property as your application requires.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> `|` and `-` can insert a vertical and horizontal separator lines in the toolbar.

## Insert Images and Links

The `Image` module inserts an image into Rich Text Editor’s content area, and the `Link` module links external resources such as website URLs, to selected text in the Rich Text Editor’s content, respectively.

The link inject module adds a link icon to the toolbar and the image inject module adds an image icon to the toolbar.

Specifies the items to be rendered in quick toolbar based on the target element such image, link and text element. The quick toolbar opens to customize the element by clicking the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/image/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/image/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Send formatted content using XmlHttpRequest

The Html string of the Rich Text Editor can be passed from View to the Controller through the `XMLHttpRequest` `Post` action. The HTML value binds to the corresponding mapped controller, and you can access it in the Post action parameter.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/rtevalue/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MvcController.cs" %}
{% include code-snippet/rich-text-editor/basic/rtevalue/mvcController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/rtevalue/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MvcController.cs" %}
{% include code-snippet/rich-text-editor/basic/rtevalue/mvcController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

The final output will be displayed as follows

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/link/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/link/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [ASP.NET MVC Rich Text Editor](https://www.syncfusion.com/aspnet-mvc-ui-controls/wysiwyg-rich-text-editor) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Rich Text Editor example](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/DefaultFunctionalities#/material) that shows how to render the rich text editor tools.

## See Also

* [How to change the editor type](./formation/)
* [How to render the iframe](./iframe/)
* [How to render the toolbar in inline mode](./inline-mode/)