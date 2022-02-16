---
layout: post
title: Customize Tool Bar in ##Platform_Name## Document Editor Component
description: Learn here all about Customize Tool Bar in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Customize Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize existing toolbar

## How to customize existing toolbar in DocumentEditorContainer

DocumentEditorContainer allows you to customize(add, show, hide, enable, and disable) existing items in a toolbar.

* Add - New items can defined by `CustomToolbarItemModel` and with existing items in [`ToolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_ToolbarItems) property. Newly added item click action can be defined in [`Toolbarclick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_ToolbarClick).

* Show, Hide - Existing items can be shown or hidden using the [`ToolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_ToolbarItems) property. Pre-defined toolbar items are available with `ToolbarItem`.

* Enable, Disable -  Toolbar items can be enabled or disable using `enableItems`

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/custom-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/custom-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-toolbar.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



> Default value of `ToolbarItems` is `['New', 'Open', 'Separator', 'Undo', 'Redo', 'Separator', 'Image', 'Table', 'Hyperlink', 'Bookmark', 'Comments', 'TableOfContents', 'Separator', 'Header', 'Footer', 'PageSetup', 'PageNumber', 'Break', 'Separator', 'Find', 'Separator', 'LocalClipboard', 'RestrictEditing']`.