---
layout: post
title: Add save button in ##Platform_Name## Document Editor Component
description: Learn here to add save button in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Add save button tool bar 
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add save button in ##Platform_Name## Document editor toolbar

## To add a save button to the existing toolbar in DocumentEditorContainer

DocumentEditorContainer allows you to add a new button to the existing items in a toolbar using [`CustomToolbarItemModel`] and with existing items in [`toolbarItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_ToolbarItems) property. Newly added item click action can be defined in [`toolbarclick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditorContainer.html#Syncfusion_EJ2_DocumentEditor_DocumentEditorContainer_ToolbarClick).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/add-save-button-in-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-save-button-in-toolbar.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/add-save-button-in-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-save-button-in-toolbar.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



N> Default value of `ToolbarItems` is `['New', 'Open', 'Separator', 'Undo', 'Redo', 'Separator', 'Image', 'Table', 'Hyperlink', 'Bookmark', 'TableOfContents', 'Separator', 'Header', 'Footer', 'PageSetup', 'PageNumber', 'Break', 'InsertFootnote', 'InsertEndnote', 'Separator', 'Find', 'Separator', 'Comments', 'TrackChanges', 'Separator', 'LocalClipboard', 'RestrictEditing', 'Separator', 'FormFields', 'UpdateFields','ContentControl']`.