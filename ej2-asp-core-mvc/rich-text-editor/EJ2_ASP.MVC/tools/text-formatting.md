---
layout: post
title: Text formatting and Structure in ##Platform_Name## Rich Text Editor | Syncfusion
description: Learn here all about Text formatting and Structure in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Text formatting and Structure
publishingplatform: ##Platform_Name##
documentation: ug
---

# Text Formatting and Structure in the ##Platform_Name## Rich Text Editor Control

## Basic text styling

The Rich Text Editor's basic styles feature provides essential formatting options, including bold, italic, underline, strikethrough, subscript, superscript, and case changes. These fundamental tools enable users to enhance and customize their text effortlessly. By leveraging these options, users can ensure their content is both visually appealing and well-structured.

### Available text styles

The table below lists the available text styles in the Rich Text Editor's toolbar.

| Name | Icons | Summary | Initialization |
|----------------|---------|---------|------------------------------------------|
| Bold  | ![Bold icon](../images/bold.png) | Makes text thicker and darker | toolbarSettings: { items: ['Bold']} | `<b>bold</b>` |
| Italic | ![Italic icon](../images/italic.png) | Slants text to the right | toolbarSettings: { items: ['Italic']} | `<em>italic</em>` |
| Underline | ![Underline icon](../images/under-line.png) | Adds a line beneath the text | toolbarSettings: { items: ['Underline']} |
| StrikeThrough | ![StrikeThrough icon](../images/strikethrough.png) | Applies a line through the text. |toolbarSettings: { items: ['StrikeThrough']}|
| InlineCode |![InlineCode icon](../images/inlineCode.png) | Formats text as inline code | toolbarSettings: { items: ['InlineCode']} | `<code>inline code</code>`|
| SubScript | ![SubScript icon](../images/sub-script.png) | Positions text slightly below the normal line |toolbarSettings: { items: ['SubScript']}|
| SuperScript | ![SuperScript icon](../images/super-script.png) | Positions text slightly above the normal line |toolbarSettings: { items: ['SuperScript’']}|
| LowerCase | ![LowerCase icon](../images/lower-case.png) |  Converts text to lowercase |toolbarSettings: { items: ['LowerCase']}|
| UpperCase | ![UpperCase icon](../images/upper-case.png) | Converts text to uppercase |toolbarSettings: { items: ['UpperCase’']}|

Please refer to the sample below to add these basic text styling options in the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic-text-styling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic-text-styling/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic-text-styling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic-text-styling/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Text alignments

The Rich Text Editor offers various text alignment options, including left, center, right, and justify. To utilize these alignment options, add the Alignments item to the items property in the toolbarSettings.

> **Important Note:** Text alignment is applied to the entire block element containing the cursor or selected text, not just to the selected text itself. When you apply an alignment, it affects the whole paragraph or block, even if you've only selected a portion of the text.

Here are the available alignment options:

* Align Left:
To left-align your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Left` icon in the toolbar. This will align the entire paragraph with the left margin.

* Align Center:
To center-align your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Center` icon in the toolbar. This will center the entire paragraph within its container.

* Align Right:
To right-align your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Right` icon in the toolbar. This will align the entire paragraph with the right margin.

* Align Justify:
To fully justify your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Justify` icon in the toolbar. This will distribute the entire paragraph evenly across the line, aligning it with both the left and right margins.

Please refer to the sample and code snippets below to add these alignment options in the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/text-alignments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/text-alignments/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/text-alignments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/text-alignments/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Number and bullet format list

List formatting in the Rich Text Editor allows users to organize content into structured lists, enhancing readability and visual presentation. The control supports two main types of lists:

1. Ordered Lists
2. Unordered Lists

### Ordered lists

Ordered lists present items in a specific sequence, with each item preceded by a number or letter. The Rich Text Editor provides two ways to create and manage ordered lists:

#### Using the ordered list tool

The `OrderedList` toolbar item offers a quick way to create or toggle a numbered list. To use it, select the desired text in the editor and click the `OrderedList` button in the toolbar. If the selected text is not already a numbered list, it will be converted into one. If it's already a numbered list, clicking the button will remove the list formatting.

#### Number format list tool

For more detailed control over the numbering style, use the `numberFormatList` dropdown in the toolbar. Select the desired text in the editor, then choose the preferred format from the `numberFormatList` dropdown. The selected text will be transformed into a numbered list with the chosen style.

##### Available numbering styles:

* `None`: Removes numbering while maintaining list structure and indentation
* `Number`: Uses standard numeric sequencing (1, 2, 3, ...)
* `Lower Roman`: Employs lowercase Roman numerals (i, ii, iii, ...)
* `Lowercase Greek`: Utilizes lowercase Greek letters (α, β, γ, ...)
* `Upper Alpha`: Applies uppercase letters (A, B, C, ...)
* `Lower Alpha`: Uses lowercase letters (a, b, c, ...)
* `Upper Roman`: Employs uppercase Roman numerals (I, II, III, ...)

You can customize the available number formats using the [numberFormatList](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_NumberFormatList) property of the Rich Text Editor.

The following example demonstrates how to customize the number format lists in the Rich Text Editor:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/number-format-list/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/number-format-list/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/number-format-list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/number-format-list/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Unordered lists

Unordered lists present items with visual markers, providing an effective way to list items without implying order or priority. The Rich Text Editor offers two methods for creating and managing unordered lists:

#### Using the unordered list tool

The `UnorderedList` toolbar item provides a fast way to create or toggle a bulleted list. To use it, select the desired text in the editor and click the `UnorderedList` button in the toolbar. If the selected text is not already a bulleted list, it will be converted into one. If it's already a bulleted list, clicking the button will remove the list formatting.

#### Bullet format list tool

For more control over the bullet style, use the `bulletFormatList` dropdown in the toolbar. Select the desired text in the editor, then choose the preferred format from the `bulletFormatList` dropdown. The selected text will be transformed into a bullet list with the chosen style.

##### Available bullet styles

* `None`: Removes bullet points while maintaining list structure and indentation
* `Disc`: Displays solid circular bullets
* `Square`: Uses solid square bullets
* `Circle`: Presents hollow circular bullets

The following example demonstrates how to customize the bullet format lists in the Rich Text Editor:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/format-lists/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/format-lists/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/format-lists/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/format-lists/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Increase and decrease indent

The Rich Text Editor allows you to set indentation for text blocks such as paragraphs, headings, or lists. This feature helps you visually organize and structure your content, making it easier to read and understand.

The Rich Text Editor allows you to configure two types of indentation tools, `Indent` and `Outdent` tool  in the Rich Text Editor toolbar using the `ToolbarSettings` [items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

| Options | Description |
|----------------|---------|
| Indent | Increases the indentation |
| Outdent | Decreases the indentation |

To adjust the text indentation:

1. Select the desired text or paragraph.
2. Click the Indent or Outdent button in the toolbar.
3. The indentation of the selected text will be modified accordingly.

To configure the `Indent` and `Outdent` toolbar item, refer to the below code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/indent-and-outdent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/indent-and-outdent/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/indent-and-outdent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/indent-and-outdent/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Indentation in lists

The Rich Text Editor provides powerful indentation features for both bullet and number format lists, allowing users to create nested lists and adjust list levels easily.

#### Increasing indent

To increase the indent of a list item:

1. Select the list item you want to indent.
2. Click the "Increase Indent" button in the toolbar or press <Kbd>Ctrl</Kbd> + <Kbd>]</Kbd>.
3. The selected item will be indented, creating a nested list.

#### Decreasing indent

To decrease the indent of a list item:

1. Select the indented list item.
2. Click the "Decrease Indent" button in the toolbar or press <Kbd>Ctrl</Kbd> + <Kbd>[</Kbd>.
3. The selected item will move back to the previous indentation level.

#### Using tab key for indentation

The Tab key provides a quick way to adjust list indentation:

- Pressing Tab will increase the indent of the selected list item, creating a nested list.
- Pressing Shift + Tab will decrease the indent of the selected list item, moving it to the previous level.

This behavior allows for efficient creation and management of multi-level lists without the need to use the toolbar buttons.

## Heading formats

The Rich Text Editor control provides a feature to format text with various heading styles, such as Heading 1, Heading 2, Heading 3, and Heading 4. These headings allow for structuring content hierarchically, improving readability, and organizing information effectively.

### Built-in formats

To enable heading styles in your Rich Text Editor:

1. Ensure the `Formats` item is included in the toolbar configuration.
2. To apply a heading:
    * Select the desired text
    * Click the `Formats` dropdown in the toolbar
    * Choose the appropriate heading level (e.g., Heading 1, Heading 2)

This action will format the selected text with the chosen heading style, helping to create a clear document structure and emphasize important sections.

Below are examples and code snippets demonstrating how to integrate and utilize heading formatting options effectively in the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/headings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/headings/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/headings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/headings/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Custom format

The Rich Text Editor allows you to customize the format dropdown to include specific styles such as heading 1, heading 2, heading 3, heading 4, heading 5, heading 6, and paragraph.

To customize the format dropdown:

1. Define a `formats` array in your component configuration.
2. Specify each format option with a display name and corresponding value.

This customization enhances the editor’s functionality, enabling users to structure content with appropriate headings, improving readability and organization.

Below are examples demonstrating how to customize the format dropdown.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-headings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-headings/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-headings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-headings/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Quotation formatting

The Rich Text Editor facilitates quotation formatting through the `Blockquote` tool available in the toolbar. Blockquotes are designed to visually highlight significant text, emphasizing key information or quotations by setting them apart from the main content for added emphasis and clarity.

To format text as a quotation, select the desired text and click on the `Blockquote` icon in the toolbar. The selected text will be formatted as a blockquote, typically indented and styled differently from the surrounding content.

Use the `Blockquote` tool in the editor below to see the feature in action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/quotation-formatting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/quotation-formatting/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/quotation-formatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/quotation-formatting/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> In a markdown editor, blockquotes are represented using the `>` symbol.

## Horizontal line

The Rich Text Editor enables users to insert horizontal dividers using the `HorizontalLine` tool available in the toolbar. Horizontal lines (<hr>) help visually separate sections of content, enhancing readability and structural clarity.

To insert a horizontal line, place the cursor at the desired location and click the `HorizontalLine` icon in the toolbar. A full-width line will be added, creating a clear visual break between sections of text or other elements.

Use the `HorizontalLine` tool in the editor below to see the feature in action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/horizontal-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/horizontal-line/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/horizontal-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/horizontal-line/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Insert code

The Rich Text Editor control offers a powerful feature to format text as preformatted code blocks, making it ideal for displaying programming snippets or structured contents.

### Enabling code block formatting

To enable code block formatting, ensure that the Formats item is included in the toolbar items of your Rich Text Editor configuration.

Below are examples and code snippets demonstrating how to add and effectively use the code block formatting option in the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-format/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-format/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Applying code block formatting

Follow these steps to format text as a code block:

1. Select the desired text in the editor.
2. Click on the `Formats` dropdown in the toolbar.
3. Choose `Preformatted` from the dropdown menu.

### Exiting code block format

To exit the code block format:

1. Place the cursor at the end of your code block content.
2. Press the Enter key twice.

This action will move the cursor out of the code block and return to normal text formatting.

### Enhancing code block appearance

To make your code blocks more visually appealing, you can add custom styling. Here's an example of how to style your `<pre>` tag:

```typescript
<style>

.e-richtexteditor .e-rte-content .e-content pre{
                background-color: #f4f4f4; color: #333; font-family: 'Courier New', Courier, monospace; font-size: 14px; padding: 15px; border-radius: 5px; border: 1px solid #ccc; overflow-x: auto; white-space: pre-wrap; word-wrap: break-word;
            }

</style>

```

This styling adds a light gray background, sets a monospace font, and includes padding and borders for better visual separation.

## Format painter

The format painter tool enables users to replicate formatting from one text segment and apply it to another. It can be accessed through the toolbar or keyboard shortcuts, allowing for the transfer of formatting styles from individual words to entire paragraphs. Customization options for the format painter are available through the [formatPainterSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FormatPainterSettings) property.

### Configuring format painter tool in the toolbar

You can add the `FormatPainter` tool in the Rich Text Editor using the `toolbarSettings` [items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

By double-clicking the format painter toolbar button, `sticky mode` will be enabled. In sticky mode, the format painter will be disabled when the user clicks the `Escape` key again.

The following code example shows how to add the format painter tool in the Rich Text Editor.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/format-painter-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/format-painter-cs1/controller.cs %}
{% endhighlight %}
{% endtabs %}

### Customizing copy and paste format

You can customize the format painter tool in the Rich Text Editor using the [formatPainterSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FormatPainterSettings) property.

The [allowedFormats](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFormatPainterSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFormatPainterSettings_AllowedFormats) property helps you to specify tag names that allow the formats to be copied from the selected text. For instance, you can include formats from the selected text using tags like `p; h1; h2; h3; div; ul; ol; li; span; strong; em; code;`. The following example demonstrates how to customize this functionality.

Similarly, with the [deniedFormats](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorFormatPainterSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorFormatPainterSettings_DeniedFormats) property, you can utilize the selectors to prevent specific formats from being pasted onto the selected text. The table below illustrates the selectors and their respective usage.

| Type | Description        | Selector                                                | Usage                                                                  |
|------|--------------------|---------------------------------------------------------|------------------------------------------------------------------------|
| ()   | Class Selector     | h3(e-rte-block-blue-text)                               | The class name e-rte-block-blue-text of H3 element is not copied.      |
| []   | Attribute Selector | span\[title]                                            | The title attribute of span element is not copied.                     |
| {}   | Style Selector     | span{background-color, color}                           | The background-color and color styles of span element is not copied.   |

Using the `deniedFormats` property following styles are denied copying from the selected text such as `h3(e-rte-block-blue-text){background-color,padding}[title]; li{color}; span(e-inline-text-highlight)[title]; strong{color}(e-rte-strong-bg)`.

Below is an example illustrating how to define the `allowedFormats` and `deniedFormats` settings for the Format Painter in the Rich Text Editor.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/format-painter-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/format-painter-cs2/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% previewsample "page.domainurl/code-snippet/rich-text-editor/format-painter-cs2" %}

### Shortcut keys for copy and paste format

For more details on keyboard navigation, refer to the [Keyboard support](../keyboard-support) documentation.

> The format painter retains the formatting after application making it possible to apply the same formatting multiple times by using the <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>v</kbd> keyboard shortcut.

Additionally, You can perform the format painter actions programmatically using the [executeCommand](../exec-command/) public method.

## Clear formatting

The ASP.NET MVC Rich Text Editor component offers a powerful `Clear Format` feature to remove any applied formatting from selected text.

This feature is particularly useful when you need to:

- Remove multiple styles at once
- Quickly standardize text formatting
- Prepare text for new styling

### Configuring clear format

To enable the Clear Format feature in your Rich Text Editor, you need to add it to the toolbar items. Follow these steps:

1. Open your component file where you've implemented the Rich Text Editor.
2. Locate the [toolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property in your Rich Text Editor configuration.
3. Add `'ClearFormat'` to the `items` array within `toolbarSettings`.

Here's an example of how to configure the Clear Format feature:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clear-format-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clear-format-cs1/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clear-format-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clear-format-cs1/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Using clear format

Once configured, you can use the Clear Format feature as follows:

1. Select the text with formatting you want to remove.
2. Click the `Clear Format` button in the toolbar.
3. The selected text will revert to its original, unformatted state.

Using `Clear Format` makes it easy to undo styling changes and keep your text looking consistent. Examples and code snippets below show how to use 'Clear Format' effectively in the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clear-format-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clear-format-cs2/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clear-format-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clear-format-cs2/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}