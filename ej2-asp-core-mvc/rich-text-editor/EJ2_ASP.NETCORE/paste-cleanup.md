---
layout: post
title: Paste Cleanup in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Paste Cleanup in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Paste Cleanup
publishingplatform: ##Platform_Name##
documentation: ug
---

# Paste Cleanup in ##Platform_Name## Rich Text Editor Control

The Rich Text Editor simplifies the conversion of Microsoft Word content to HTML format, preserving formatting and styles. The `pasteCleanup` settings property (see [pasteCleanupSettingsModel](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_PasteCleanupSettings)) allows you to control the formatting and styles when pasting content into the editor. The following settings are available to clean up the content:

| API | Description | Default Value | Type |
|:----------------:|:---------:|:-----------------------------:|:---------:|
| [Prompt](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_Prompt) | Displays a dialog box when content is pasted, allowing users to choose how the content should be inserted—either as plain text, with formatting, or cleaned HTML. | false | boolean |
| [PlainText](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_PlainText) | Paste the content as plain text| false | boolean |
| [KeepFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_KeepFormat) | Retains the original formatting of the pasted content, including styles, fonts, and structure.| true | boolean |
| [DeniedTags](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_DeniedTags) | Specifies a list of HTML tags to be removed from the pasted content, such as `<script>`, `<iframe>`, or `<style>`. Helps eliminate unwanted or unsafe elements. | null | string[] |
| [DeniedAttrs](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_DeniedAttrs) |  Filters out specified attributes from the pasted content| null | string[] |
| [AllowedStyleProps](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_AllowedStyleProps) |  Accepts specified style attributes and removes others from the pasted content| ['background', 'background-color', 'border', 'border-bottom', 'border-left', 'border-radius', 'border-right', 'border-style', 'border-top', 'border-width', 'clear', 'color', 'cursor', 'direction', 'display', 'float', 'font', 'font-family', 'font-size', 'font-weight', 'font-style', 'height', 'left', 'line-height', 'margin', 'margin-top', 'margin-left', 'margin-right', 'margin-bottom', 'max-height', 'max-width', 'min-height', 'min-width', 'overflow', 'overflow-x', 'overflow-y', 'padding', 'padding-bottom', 'padding-left', 'padding-right', 'padding-top', 'position', 'right', 'table-layout', 'text-align', 'text-decoration', 'text-indent', 'top', 'vertical-align', 'visibility', 'white-space', 'width'] | string[] |

## Paste options in the prompt dialog

When `Prompt` is set to true, pasting the content in the editor will open a dialog box that contains three options `Keep`, `Clean`, and `Plain Text` as radio buttons:

![Rich Text Editor Paste options prompt dialog ](../images/richtexteditor-paste-prompt.png)

1. `Keep`: Maintains the same format as the copied content.
2. `Clean`: Clears all style formats from the copied content.
3. `Plain Text`: Pastes the copied content as plain text without any formatting or style. (including the removal of all tags).

> When `Prompt` value is set true, the API properties [PlainText](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_PlainText) and [KeepFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorPasteCleanupSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorPasteCleanupSettings_KeepFormat) will not be considered for processing when pasting the content.

## How to paste as plain text

Setting `PlainText` to true converts the copied content to plain text by removing all HTML tags and styles. Only the plain text is pasted into the editor.

>When `PlainText` is set to true, set `Prompt` to false. The `KeepFormat` property will not be considered.

## Keep format

When `KeepFormat` is set to `true`, the pasted content retains its original formatting, including styles, fonts, and structure. However, the formatting is still subject to filtering based on the `AllowedStyleProps`, `DeniedTags`, and `DeniedAttrs` settings:

* Only the style properties listed in `AllowedStyleProps` will be preserved.
* Any HTML tags listed in `DeniedTags` will be removed.
* Any attributes listed in `DeniedAttrs` will be stripped from the pasted content.

This ensures that while the formatting is retained, it remains clean, safe, and consistent with your application's styling rules.

>When `keepFormat` is set to true, set both `Prompt` and `PlainText` to false.

## Clean Formatting

When the `Prompt`, `PlainText`, and `keepFormat` options are all set to false, the Rich Text Editor performs clean format paste cleanup. In this mode, all inline styles from the pasted content are removed, eliminating any custom or external styling. This ensures a consistent and uniform appearance within the editor.

Despite the removal of styling, essential structural HTML tags such as `<p>`, `<ul>`, `<table>`, and others are preserved. This maintains the original layout and semantic integrity of the content, allowing it to remain well-structured and readable.However, the formatting is still subject to filtering based on the `DeniedTags`, and `DeniedAttrs` settings:

- **`DeniedTags`**: Tags listed here will still be removed from the pasted content, even when clean format is enabled.
- **`DeniedAttrs`**: Attributes listed here will also be stripped from the pasted content.

> The `AllowedStyleProps` setting only applies if `KeepFormat` is enabled.

## Denied tags

When `DeniedTags` values are set, the specified tags will be removed from the pasted content. For example,

* `'a'`:  Removes all anchor tags.
* `'a[!href]'`: Removes anchor tags without the 'href' attribute.
* `'a[href, target]'`: Removes anchor tags with both 'href' and 'target' attributes.

> This setting is ignored when `PlainText` is set to `true`. <br>
It only works when either `KeepFormat` is set to `true`, or when `Prompt`, `PlainText`, and `KeepFormat` are all set to `false`, which triggers clean format behavior.

## Denied attributes during paste

When `DeniedAttrs` values are set, the specified attributes will be removed from all tags in the pasted content. For example,

`'id', 'title'`: Removes 'id' and 'title' attributes from all tags.

> This setting is ignored when `PlainText` is set to `true`. <br>
It only works when either `KeepFormat` is set to `true`, or when `Prompt`, `PlainText`, and `KeepFormat` are all set to `false`, which triggers clean format behavior.

## Allowing specific style properties

By default, a predefined set of basic style properties are allowed when content is pasted into the Rich Text Editor.

['background', 'background-color', 'border', 'border-bottom', 'border-left', 'border-radius', 'border-right', 'border-style', 'border-top', 'border-width', 'clear', 'color', 'cursor', 'direction', 'display', 'float', 'font', 'font-family', 'font-size', 'font-weight', 'font-style', 'height', 'left', 'line-height', 'margin', 'margin-top', 'margin-left', 'margin-right', 'margin-bottom', 'max-height', 'max-width', 'min-height', 'min-width', 'overflow', 'overflow-x', 'overflow-y', 'padding', 'padding-bottom', 'padding-left', 'padding-right', 'padding-top', 'position', 'right', 'table-layout', 'text-align', 'text-decoration', 'text-indent', 'top', 'vertical-align', 'visibility', 'white-space', 'width']

> This setting works only when `KeepFormat` is set to true. If `KeepFormat` is `false` or `PlainText` is `true`, style filtering via `AllowedStyleProps` will not be applied.

For Example,

`AllowedStyleProps: ['color', 'margin']'`: This will allow only the style properties ‘color’ and ‘margin’ in each pasted element.

In the following example, the paste cleanup related settings are explained with its module configuration:

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

## Get pasted content

You can get the pasted text as HTML using the [afterPasteCleanup](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_AfterPasteCleanup) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/get-pasted-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/get-pasted-content/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/get-pasted-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/get-pasted-content/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customization of pasted content

The Rich Text Editor enables the customization of copied content prior to pasting it into the editor. By configuring the [afterPasteCleanUp](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_AfterPasteCleanup) event, users can exercise precise control over formatting and content modifications after the paste action is executed.

In the following example, the `afterPasteCleanUp` event is configured to remove images from the copied content. To understand this feature better, try pasting content that includes an image into the editor.

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