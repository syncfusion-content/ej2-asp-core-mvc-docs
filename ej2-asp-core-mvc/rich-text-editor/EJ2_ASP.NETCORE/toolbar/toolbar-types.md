---
layout: post
title: Toolbar types in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Toolbar types in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Toolbar types
publishingplatform: ##Platform_Name##
documentation: ug
---

# Toolbar in the ##Platform_Name## Rich Text Editor Control

The Syncfusion ##Platform_Name## Rich Text Editor provides a powerful toolbar that enables users to format, style, and edit content efficiently. The toolbar includes essential editing tools such as bold, italic, underline, alignment, and lists, along with customization options to suit different use cases.

To learn about the different types of toolbars in the ASP.NET Core Rich Text Editor, watch this video:

{% youtube "youtube:https://www.youtube.com/watch?v=09tBgKpjgjU"%}

The Rich Text Editor allows you to configure different types of toolbar using [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Type) field in [toolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property. The types of toolbar are:

1. Expand
2. MultiRow
3. Scrollable

## Expanding the toolbar

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/toolbar-expand/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/toolbar-expand/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/toolbar-expand/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/toolbar-expand/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Configuring a multi-row toolbar

Setting the `type` as `MultiRow` in [`toolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) will arrange the toolbar items across multiple rows, displaying all configured toolbar items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/toolbar-multi/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/toolbar-multi/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/toolbar-multi/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/toolbar-multi/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Implementing a scrollable toolbar

Setting the `type` to `Scrollable` in [toolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) will display the toolbar items in a single line, enabling horizontal scrolling in the toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/scrollable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/scrollable/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/scrollable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/scrollable/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Creating a sticky toolbar

By default, the toolbar remains fixed at the top of the Rich Text Editor when scrolling. You can customize the position of this sticky toolbar by setting the [floatingToolbarOffset](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FloatingToolbarOffset) to adjust its offset from the top of the document.

Additionally, you can enable or disable the floating toolbar using the [enableFloating](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_EnableFloating) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/floating-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/floating-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/floating-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/floating-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See also

* [Customizing Rich Text Editor Toolbar Styles](../style#customizing-the-rich-text-editors-toolbar)
* [Implementing Inline Editing](../inline-editing)
* [Customizing Accessibility Shortcut Keys](../accessibility#keyboard-navigation)