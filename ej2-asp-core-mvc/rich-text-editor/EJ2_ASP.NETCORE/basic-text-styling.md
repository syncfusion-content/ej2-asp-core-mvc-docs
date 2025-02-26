---
layout: post
title: Basic Text Styling in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Basic Text Styling in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Basic Text Styling
publishingplatform: ##Platform_Name##
documentation: ug
---

# Basic Text Styling in  ##Platform_Name## Rich Text Editor control

The Rich Text Editor's basic styles feature provides essential formatting options, including bold, italic, underline, strikethrough, subscript, superscript, and case changes. These fundamental tools enable users to enhance and customize their text effortlessly. By leveraging these options, users can ensure their content is both visually appealing and well-structured.

## Available Text Styles

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

## See Also

