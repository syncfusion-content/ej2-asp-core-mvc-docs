---
layout: post
title: Format Painter in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Format Painter in Syncfusion ##Platform_Name## Rich Text Editor Control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Format Painter
publishingplatform: ##Platform_Name##
documentation: ug
---

# Format Painter in ##Platform_Name## Rich Text Editor Control | Syncfusion

The format painter tool enables users to replicate formatting from one text segment and apply it to another. It can be accessed through the toolbar or keyboard shortcuts, allowing for the transfer of formatting styles from individual words to entire paragraphs. Customization options for the format painter are available through the [FormatPainterSettings](../api/rich-text-editor/https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFormatPainterSettings.html) property.

## Configuring Format Painter Tool in the Toolbar

You can add the `FormatPainter` tool in the Rich Text Editor using the `ToolbarSettings` [items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

By double-clicking the format painter toolbar button, `sticky mode` will be enabled. In sticky mode, the format painter will be disabled when the user clicks the `Escape` key again.

The following code example shows how to add the format painter tool in the Rich Text Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/format-painter-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/format-painter-cs1/controller.cs %}
{% endhighlight %}
{% endtabs %}

## Customizing Copy and Paste Format

You can customize the format painter tool in the Rich Text Editor using the [FormatPainterSettings](../api/rich-text-editor/https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFormatPainterSettings.html) property.

The [AllowedFormats](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFormatPainterSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFormatPainterSettings_AllowedFormats) property helps you to specify tag names that allow the formats to be copied from the selected text. For instance, you can include formats from the selected text using tags like `p; h1; h2; h3; div; ul; ol; li; span; strong; em; code;`. The following example demonstrates how to customize this functionality.

Similarly, with the [DeniedFormats](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFormatPainterSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFormatPainterSettings_DeniedFormats) property, you can utilize the selectors to prevent specific formats from being pasted onto the selected text. The table below illustrates the selectors and their respective usage.

| Type | Description        | Selector                                                | Usage                                                                  |
|------|--------------------|---------------------------------------------------------|------------------------------------------------------------------------|
| ()   | Class Selector     | h3(e-rte-block-blue-text)                               | The class name e-rte-block-blue-text of H3 element is not copied.      |
| []   | Attribute Selector | span\[title]                                            | The title attribute of span element is not copied.                     |
| {}   | Style Selector     | span{background-color, color}                           | The background-color and color styles of span element is not copied.   |

Using the `DeniedFormats` property following styles are denied copying from the selected text such as `h3(e-rte-block-blue-text){background-color,padding}[title]; li{color}; span(e-inline-text-highlight)[title]; strong{color}(e-rte-strong-bg)`.

Below is an example illustrating how to define the `AllowedFormats` and `DeniedFormats` settings for the Format Painter in the Rich Text Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/format-painter-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/format-painter-cs2/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% previewsample "page.domainurl/code-snippet/rich-text-editor/format-painter-cs2" %}

## Using Shortcut Keys for Copy and Paste Format

You can use the following shortcut keys to copy and paste the format in the Rich Text Editor.

| Actions               | Keyboard shortcuts                               | Description                                                     |
|-----------------------|--------------------------------------------------|-----------------------------------------------------------------|
| Copy the format       | <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>c</kbd> | Copy the selection format or current range.                     |
| Pate the format       | <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>v</kbd> | Paint the copied format.                                        |
| Escape                | <kbd>Esc</kbd>                                   | Remove the previously copied format and disable the sticky mode.|

> The format painter retains the formatting after application making it possible to apply the same formatting multiple times by using the <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>v</kbd> keyboard shortcut.

Additionally, You can perform the format painter actions programmatically using the [executeCommand](../exec-command/) public method.