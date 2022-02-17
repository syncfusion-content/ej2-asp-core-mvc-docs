---
layout: post
title: Formation in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Formation in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Formation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Formation

The Rich Text Editor control used to create and edit the content and return valid HTML markup or markdown (MD) of the content. It supports the following two editing formation.

* HTML Editor
* Markdown Editor

## HTML Editor

Rich Text Editor is a WYSIWYG editing control for formatting the word content as HTML.
The HTML editing mode is the default mode in Rich Text Editor to format the content through the available toolbar items to return the valid HTML markup. Set the [`EditorMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EditorMode_Syncfusion_EJ2_RichTextEditor_EditorMode_) property as `HTML`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/html-editor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/html-editor/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/html-editor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/html-editor/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Markdown Editor

Set the [`EditorMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EditorMode_Syncfusion_EJ2_RichTextEditor_EditorMode_) property as Markdown, to create or edit the content and apply formatting to view markdown formatted content.

* The Supported Tags are  `h6`,`h5`,`h4`,`h3`,`h2`,`h1`,`blockquote`,`pre`,`p`,`ol`,`ul`.
* The Supported Selection Tags are `Bold`, `Italic`, `StrikeThrough`, `InlineCode`, `SubScript`, `SuperScript`, `UpperCase`, `LowerCase`.
* The supported insert commands are `Image`, `Link` and `Table`.

> The third-party library such as [`Marked`](https://marked.js.org/#/README.md#README.md) or any other library is used to convert markdown into HTML content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown-editor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown-editor/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown-editor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown-editor/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to integrate the third party library](./third-party-integration/)
* [How to render the iframe](./iframe/)