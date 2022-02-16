---
layout: post
title: Inline Mode in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Inline Mode in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Inline Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Inline Mode

This is the inline example for the Rich Text Editor. For this you must set the [`InlineMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InlineMode) property.

Inline edition allows you to select any editable element or click the element on the page and edit it in-place.

Inline editing is a true WYSIWYG formation and on the contrary to Rich Text Editor HTML/MD editing, the styles that are used for edited content comes directly from the document stylesheet. This means that inline editors ignore the default Rich Text Editor content styles.

## Show on Select/Click

Enabling the `onSelection` option of inlineMode makes the inline Rich Text Editor to appear.  You can select the text in the editable area otherwise the inline Rich Text Editor will be appear once click into the editable area.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/inline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/inline/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/inline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/inline/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Rich Text Editor InlineMode](./images/inline.png)

## See Also

* [How to edit the quick toolbar settings](./toolbar/#quick-inline-toolbar)
* [How to insert link editing option in the toolbar items](./link/#insert-link)
* [How to insert image editing option in the toolbar items](./image/#upload-options)