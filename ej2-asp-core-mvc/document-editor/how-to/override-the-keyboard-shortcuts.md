---
layout: post
title: Keyboard Shortcuts in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about override the keyboard shortcuts in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Override The Keyboard Shortcuts
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to override the keyboard shortcuts in document editor

Document editor triggers the [`keyDown`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_KeyDown) event every time when any key is entered and provides an instance of `DocumentEditorKeyDownEventArgs`. You can use the `isHandled` property to override the keyboard shortcut behavior.

## Preventing default keyboard shortcut

The following code shows how to prevent the `CTRL + C` keyboard shortcut for copying selected content in document editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/prevent-default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-default.cs" %}
{% include code-snippet/document-editor/prevent-default/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/prevent-default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-default.cs" %}
{% include code-snippet/document-editor/prevent-default/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Override or define the keyboard shortcut

Override or define a new keyboard shortcut behavior instead of preventing the keyboard shortcut.

For example, `Ctrl + S` keyboard shortcut saves the document in SFDT format by default, and there is no behavior for `Ctrl + Alt + S`. The following code demonstrates how to override the `Ctrl + S` shortcut to save a document in DOCX format and define `Ctrl + Alt + S` to save the document in SFDT format.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/override/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Override.cs" %}
{% include code-snippet/document-editor/override/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/override/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Override.cs" %}
{% include code-snippet/document-editor/override/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## How to Detect when a key is being pressed

Capture or detect what action will be executed when any key is pressed.

For example, when the Backspace or Delete keys are pressed, an alert message will pop up with a specific action for the pressed key. The following code demonstrates how to detect the `Delete` or `Backspace` key press for deleting and backspacing the selected content in the Document Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/detect-keyboard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-default.cs" %}
{% include code-snippet/document-editor/detect-keyboard/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/detect-keyboard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-default.cs" %}
{% include code-snippet/document-editor/detect-keyboard/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
