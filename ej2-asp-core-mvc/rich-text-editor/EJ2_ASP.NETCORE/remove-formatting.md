---
layout: post
title: Remove Formatting in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Remove Formatting in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Remove Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Remove Formatting in the ##Platform_Name## Rich Text Editor Component

The ASP.NET Core Rich Text Editor component offers a powerful `Clear Format` feature to remove any applied formatting from selected text.

This feature is particularly useful when you need to:

- Remove multiple styles at once
- Quickly standardize text formatting
- Prepare text for new styling

## Configuring Clear Format

To enable the Clear Format feature in your Rich Text Editor, you need to add it to the toolbar items. Follow these steps:

1. Open your component file where you've implemented the Rich Text Editor.
2. Locate the [toolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property in your Rich Text Editor configuration.
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

## Using Clear Format

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

## See Also

[Copy and Apply Formatting](./format-painter)