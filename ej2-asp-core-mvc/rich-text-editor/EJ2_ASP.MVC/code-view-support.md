---
layout: post
title: Code View in ##Platform_Name## Rich Text Editor Control | Syncfusion
title: Getting Started with ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Code View in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Code View
publishingplatform: ##Platform_Name##
documentation: ug
---

# Code View Support in ##Platform_Name## Rich Text Editor Control

The Rich Text Editor enables you to directly edit HTML code through the `Source View` in the text area. Any changes you make in Source view are immediately reflected in the editor's content, giving you greater flexibility and control over your work.
The source code is presented with enhanced formatting and consistent indentation for both block-level and inline HTML elements, resulting in a cleaner, more readable, and user-friendly editing experience.

>While the visual alignment of the source code is improved, the editor's underlying value remains unchanged.

## Configuring Source Code Tool in the Toolbar

You can add the `SourceCode` tool in the Rich Text Editor using the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

This sample used [`Code mirror`](https://codemirror.net/) plugin helps to highlight the HTML content and when changes happens in code view, the same has been reflected in preview mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-mirror/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-mirror/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-mirror/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-mirror/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The Rich Text Editor provides the `ShowSourceCode` method, which allows you to toggle programmatically between the code view and the formatted text view. When invoked, this method switches the editor’s view to the opposite state.

## See Also

* [Integrating Code-Mirror for Enhanced Syntax Highlighting](./third-party-integration#codemirror-integration)