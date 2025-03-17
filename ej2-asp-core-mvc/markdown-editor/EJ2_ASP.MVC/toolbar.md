---
layout: post
title: Toolbar Configuration in ##Platform_Name## Markdown Editor Control | Syncfusion
description: Checkout and learn about Toolbar Configuration in ##Platform_Name## Markdown Editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Toolbar Configuration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Toolbar configuration in Markdown Editor Control

## Default toolbar items

By default, the Markdown Editor displays the following toolbar items:

> `Bold` , `Italic` , `|` , `Formats` , `Blockquote`, `OrderedList` , `UnorderedList` , `|` , `CreateLink` , `Image` , `|` , `SourceCode` , `Undo` , `Redo`

These default items cover essential text editing features, such as text formatting, lists, and linking.

## Type of toolbar 

The Syncfusion Markdown Editor allows you to configure different type of toolbars using the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Type) field in the [ToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property.

The available toolbar types are:

1. Expand
2. MultiRow
3. Scrollable

### Expanding the Toolbar

The default toolbar mode is `Expand`, which is configured using [ToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) with type: `Expand`.

In this mode, any overflowing toolbar items are hidden in the next row. Users can reveal them by clicking the expand arrow.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/toolbar-expand/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/toolbar-expand/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/toolbar-expand/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/toolbar-expand/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Configuring a Multi-row Toolbar

By setting type: `MultiRow` in [ToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings), the toolbar items are arranged across multiple rows. This ensures that all configured toolbar items are always visible.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/toolbar-multirow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/toolbar-multirow/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/toolbar-multirow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/toolbar-multirow/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Implementing a Scrollable Toolbar

Use `Type: 'Scrollable'` in [ToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) to create a single-line toolbar with horizontal scrolling capability for overflow items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/toolbar-scrollable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/toolbar-scrollable/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/toolbar-scrollable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/toolbar-scrollable/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Creating a Sticky Toolbar

By default, the toolbar remains fixed at the top of the Markdown editor when scrolling.

You can customize its position by setting [FloatingToolbarOffset](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FloatingToolbarOffset) to adjust the offset from the top of the document.

Additionally, you can enable or disable the floating toolbar using the [EnableFloating](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_EnableFloating) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/floating-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/floating-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/floating-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/floating-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Custom Toolbar Items

The Markdown Editor allows you to add custom commands to the toolbar using the [ToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property. These custom commands can be displayed as plain text, icons, or HTML templates. You can define their order and grouping, ensuring a structured and intuitive toolbar layout. Additionally, actions can be bound to these commands by retrieving their instances and handling events accordingly.

In this example, a custom toolbar item (Ω) is added to insert special characters into the editor. When users click the Ω button, a list of special characters appears, allowing them to select and insert a character into the content. This feature enhances the Markdown Editor by providing quick access to special symbols without manually entering character codes.

The following code snippet demonstrates how to configure a custom toolbar item with a tooltip. The item is added to the [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) field of the `ToolbarSettings` property, ensuring seamless integration within the toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/custom-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/custom-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/custom-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/custom-toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}