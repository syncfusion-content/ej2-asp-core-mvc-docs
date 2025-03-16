---
layout: post
title: Paste Cleanup in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Paste Cleanup in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Paste Cleanup
publishingplatform: ##Platform_Name##
documentation: ug
---


# Paste Cleanup in ##Platform_Name## Rich Text Editor Control

The Rich Text Editor simplifies the conversion of Microsoft Word content to HTML format, preserving formatting and styles. The `PasteCleanup` settings property allows you to control the formatting and styles when pasting content into the editor. The following settings are available to clean up the content:

| API | Description | Default Value | Type |
|:----------------:|:---------:|:-----------------------------:|:---------:|
| [Prompt](#Prompt) | Invokes a Prompt dialog with paste options when pasting content into the editor| false | boolean |
| [PlainText](#plain-text) | Paste the content as plain text| false | boolean |
| [KeepFormat](#keep-format) | Maintains the same format as the copied content| true | boolean |
| [DeniedTags](#denied-tags) | Ignores specified tags when pasting HTML content| null | string[] |
| [DeniedAttrs](#denied-attributes) |  Filters out specified attributes from the pasted content| null | string[] |
| [AllowedStyleProps](#allowed-style-properties) |  Accepts specified style attributes and removes others from the pasted content| ['background', 'background-color', 'border', 'border-bottom', 'border-left', 'border-radius', 'border-right', 'border-style', 'border-top', 'border-width', 'clear', 'color', 'cursor', 'direction', 'display', 'float', 'font', 'font-family', 'font-size', 'font-weight', 'font-style', 'height', 'left', 'line-height', 'margin', 'margin-top', 'margin-left', 'margin-right', 'margin-bottom', 'max-height', 'max-width', 'min-height', 'min-width', 'overflow', 'overflow-x', 'overflow-y', 'padding', 'padding-bottom', 'padding-left', 'padding-right', 'padding-top', 'position', 'right', 'table-layout', 'text-align', 'text-decoration', 'text-indent', 'top', 'vertical-align', 'visibility', 'white-space', 'width'] | string[] |

## Understanding Paste Options in the Prompt Dialog

When `Prompt` is set to true, pasting the content in the editor will open a dialog box that contains three options `Keep`, `Clean`, and `Plain Text` as radio buttons:
1. `Keep`: Maintains the same format as the copied content.
2. `Clean`: Clears all style formats from the copied content.
3. `Plain Text`: Pastes the copied content as plain text without any formatting or style. (including the removal of all tags).

> When `Prompt` value is set true, the API properties [PlainText](#plain-text) and [KeepFormat](#keep-format) will not be considered for processing when pasting the content.

## How to Paste as Plain Text

Setting `PlainText` to true converts the copied content to plain text by removing all HTML tags and styles. Only the plain text is pasted into the editor.

>When `PlainText` is set to true, set `Prompt` to false. The `KeepFormat` property will not be considered.

## Maintaining Formatting with Keep Format Option

When `KeepFormat` is set to true, the copied content maintains all style formatting allowed in the `AllowedStyleProps` when pasted into the editor.

If `KeepFormat` is set to false, all styles in the copied content are removed, regardless of the `AllowedStyleProps` settings.

>When `KeepFormat` is set to true, set both `Prompt` and `PlainText` to false.

## Cleaning Formatting During Paste

Setting `CleanFormat` to true removes all applied styles from the pasted content while retaining all other HTML tags in the editor.

>When `CleanFormat` is set to true, set `Prompt`, `PlainText`, and `KeepFormat` to false.

## Managing Denied Tags for Paste Cleanup

When `DeniedTags` values are set, the specified tags will be removed from the pasted content. For example,

* `'a'`:  Removes all anchor tags.
* `'a[!href]'`: Removes anchor tags without the 'href' attribute.
* `'a[href, target]'`: Removes anchor tags with both 'href' and 'target' attributes.

## Configuring Denied Attributes in Paste Settings

When `DeniedAttrs` values are set, the specified attributes will be removed from all tags in the pasted content. For example,

`'id', 'title'`: Removes 'id' and 'title' attributes from all tags.

## Allowing Specific Style Properties for Pasted Content

By default, the following basic styles are allowed on pasting the content to the editor.

['background', 'background-color', 'border', 'border-bottom', 'border-left', 'border-radius', 'border-right', 'border-style', 'border-top', 'border-width', 'clear', 'color', 'cursor', 'direction', 'display', 'float', 'font', 'font-family', 'font-size', 'font-weight', 'font-style', 'height', 'left', 'line-height', 'margin', 'margin-top', 'margin-left', 'margin-right', 'margin-bottom', 'max-height', 'max-width', 'min-height', 'min-width', 'overflow', 'overflow-x', 'overflow-y', 'padding', 'padding-bottom', 'padding-left', 'padding-right', 'padding-top', 'position', 'right', 'table-layout', 'text-align', 'text-decoration', 'text-indent', 'top', 'vertical-align', 'visibility', 'white-space', 'width']

When you configure allowedStyleProps, the styles, which matches the ‘allowed style properties’ list are allowed, all other style properties will be removed on pasting the content in the editor.

For Example,

`AllowedStyleProps: ['color', 'margin']'`: This will allow only the style properties ‘color’ and ‘margin’ in each pasted element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/paste-cleanup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/paste-cleanup/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/paste-cleanup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/paste-cleanup/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Manual Customization of Pasted Content

The Rich Text Editor enables the customization of copied content prior to pasting it into the editor. By configuring the [AfterPasteCleanUp](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_AfterPasteCleanup) event, users can exercise precise control over formatting and content modifications after the paste action is executed.

In the following example, the `AfterPasteCleanUp` event is configured to remove images from the copied content. To understand this feature better, try pasting content that includes an image into the editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/paste-cleanup-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/paste-cleanup-customize/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/paste-cleanup-customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/paste-cleanup-customize/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}