---
layout: post
title: Link in Syncfusion ##Platform_Name## Rich Text Editor Control
description: Learn here all about Link in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Link
publishingplatform: ##Platform_Name##
documentation: ug
---

# Link in ##Platform_Name## Rich Text Editor Control

A hyperlink can be insert into the editor for quick access to the related information. The hyperlink itself can be a text or an image.

## Inserting a Link

To insert a hyperlink:

1. Position your cursor where you want to insert the link, or select the text or image you wish to convert into a hyperlink.
2. Click the "Insert HyperLink" tool on the toolbar.
3. In the Insert Link Dialog that appears, fill in the following options.

| Options | Description |
|----------------|--------------------------------------|
| Web Address | Enter or paste the destination URL for your link |
| Display Text | Enter or edit the required text that you want to display text for the link|
| Tooltip | To display additional helpful information when you place the pointer on the hyperlink, type the required text in the “Tooltip” field. |
| Open Link in New Window | Specify whether, the given link will be open in new window or not |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/link/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/link/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> The Rich Text Editor validates URLs as you type in the Web Address field. Invalid URLs will be highlighted in red when you click the insert button in the `Insert Link` dialog.

## Removing a Link

To remove a hyperlink:

1. Select the linked text or image.
2. Click the "Remove Hyperlink" tool in the toolbar.

This action will remove the hyperlink while keeping the original text or image intact.

## Auto Link Generation

The Rich Text Editor supports automatic link generation. When you type a URL and press Space or Enter, the editor automatically converts the typed URL into a clickable hyperlink.

## Customizing the Link Quick Toolbar

The Rich Text Editor allows you to customize the tools in the link quick toolbar. You can add or remove items by using the [quickToolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_QuickToolbarSettings) property.

The quick toolbar for the Link has the following options.

| Tools | Description |
|----------------|--------------------------------------|
| Open | Opens the linked page in a new window. |
| Edit Link | Allows you to edit the selected link. |
| Remove Link | Removes the link from the selected content. |
| Custom Tool | Adds custom options to the quick toolbar. |

The following example demonstrates how to customize the link quick toolbar using the [quickToolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_QuickToolbarSettings) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/link-quick-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/link-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/link-quick-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/link-quick-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Image with links](./image/#image-with-link)
* [Insert File Attachments](./how-to/file-attachment)
