---
layout: post
title: List formatting in ##Platform_Name## Rich Text Editor Control
description: Learn here all about List formatting in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: List formatting
publishingplatform: ##Platform_Name##
documentation: ug
---

# List Formatting in ##Platform_Name## Rich Text Editor Control

List formatting in the Rich Text Editor allows users to organize content into structured lists, enhancing readability and visual presentation. The control supports two main types of lists:

1. Ordered Lists
2. Unordered Lists

## Ordered Lists

Ordered lists present items in a specific sequence, with each item preceded by a number or letter. The Rich Text Editor provides two ways to create and manage ordered lists:

### Using the OrderedList Tool

The `OrderedList` toolbar item offers a quick way to create or toggle a numbered list. To use it, select the desired text in the editor and click the `OrderedList` button in the toolbar. If the selected text is not already a numbered list, it will be converted into one. If it's already a numbered list, clicking the button will remove the list formatting.

### NumberFormatList Tool

For more detailed control over the numbering style, use the `numberFormatList` dropdown in the toolbar. Select the desired text in the editor, then choose the preferred format from the `numberFormatList` dropdown. The selected text will be transformed into a numbered list with the chosen style.

#### Available Numbering Styles:

* `None`: Removes numbering while maintaining list structure and indentation
* `Number`: Uses standard numeric sequencing (1, 2, 3, ...)
* `Lower Roman`: Employs lowercase Roman numerals (i, ii, iii, ...)
* `Lowercase Greek`: Utilizes lowercase Greek letters (α, β, γ, ...)
* `Upper Alpha`: Applies uppercase letters (A, B, C, ...)
* `Lower Alpha`: Uses lowercase letters (a, b, c, ...)
* `Upper Roman`: Employs uppercase Roman numerals (I, II, III, ...)

You can customize the available number formats using the [numberFormatList](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_NumberFormatList) property of the Rich Text Editor.

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

## Unordered Lists

Unordered lists present items with visual markers, providing an effective way to list items without implying order or priority. The Rich Text Editor offers two methods for creating and managing unordered lists:

### Using the UnorderedList Tool

The `UnorderedList` toolbar item provides a fast way to create or toggle a bulleted list. To use it, select the desired text in the editor and click the `UnorderedList` button in the toolbar. If the selected text is not already a bulleted list, it will be converted into one. If it's already a bulleted list, clicking the button will remove the list formatting.

### BulletFormatList Tool

For more control over the bullet style, use the `bulletFormatList` dropdown in the toolbar. Select the desired text in the editor, then choose the preferred format from the `bulletFormatList` dropdown. The selected text will be transformed into a bullet list with the chosen style.

#### Available Bullet Styles:

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

## Indentation in Lists

The Rich Text Editor provides powerful indentation features for both bullet and number format lists, allowing users to create nested lists and adjust list levels easily.

### Increasing Indent

To increase the indent of a list item:

1. Select the list item you want to indent.
2. Click the "Increase Indent" button in the toolbar or press <Kbd>Ctrl</Kbd> + <Kbd>]</Kbd>.
3. The selected item will be indented, creating a nested list.

### Decreasing Indent

To decrease the indent of a list item:

1. Select the indented list item.
2. Click the "Decrease Indent" button in the toolbar or press <Kbd>Ctrl</Kbd> + <Kbd>[</Kbd>.
3. The selected item will move back to the previous indentation level.

### Using Tab Key for Indentation

The Tab key provides a quick way to adjust list indentation:

- Pressing Tab will increase the indent of the selected list item, creating a nested list.
- Pressing Shift + Tab will decrease the indent of the selected list item, moving it to the previous level.

This behavior allows for efficient creation and management of multi-level lists without the need to use the toolbar buttons.

## See Also

[Increase and Decrease Indent Levels](./indent-and-outdent) 