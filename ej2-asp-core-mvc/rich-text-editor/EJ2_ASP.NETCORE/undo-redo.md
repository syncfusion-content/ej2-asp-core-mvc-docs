---
layout: post
title: Undo redo in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Undo redo in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Undo redo
publishingplatform: ##Platform_Name##
documentation: ug
---

# Undo redo in the  ##Platform_Name## Rich Text Editor Control

The Undo and Redo features in the Rich Text Editor allowing you to reverse or restore recent changes, providing a safety net for text edits and enhancing the overall editing experience.

There are two ways to perform Undo and Redo operations:

1. Click the Undo or Redo buttons on the toolbar.
2. Use keyboard shortcuts:
   - For Undo: `Ctrl + Z` (Windows) or `Cmd + Z` (Mac)
   - For Redo: `Ctrl + Y` (Windows) or `Cmd + Shift + Z` (Mac)

## Configuring Undo/Redo timer

By default, the time interval for storing Undo/Redo actions is 300 milliseconds. You can adjust this interval using the [undoRedoTimer](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_UndoRedoTimer) property.

## Configuring Undo/Redo steps

The editor allows up to 30 Undo/Redo actions by default. You can modify the number of undo/redo steps using the [undoRedoSteps](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_UndoRedoSteps) property.

Here's an example of how to customize both the Undo/Redo timer and steps:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/undo-redo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/undo-redo/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/undo-redo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/undo-redo/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Clear Undo/Redo stack

The Rich Text Editor automatically maintains an undo/redo stack, allowing users to revert or redo changes made during editing.

To clear the entire undo and redo stack, use the public `clearUndoRedo` method. This is helpful when loading new content dynamically or resetting the editor to its initial state.

Here's an example of how to customize both the Undo/Redo timer and steps:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clear-undo-redo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clear-undo-redo/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clear-undo-redo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clear-undo-redo/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}