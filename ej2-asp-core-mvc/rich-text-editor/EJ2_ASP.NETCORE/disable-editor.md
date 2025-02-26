---
layout: post
title: Disabling the ##Platform_Name## Rich Text Editor Control
description: Learn here all about Disabling the ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Disabling the Rich Text Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Disabling the ##Platform_Name## Rich Text Editor Control

The Angular Rich Text Editor component offers a feature to disable the editor, preventing any user interaction.This functionality is particularly useful when you need to display content without allowing modifications or when you want to temporarily restrict user input.

### How to Disable the Editor

To disable the editor, set the [enabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_Enabled) property to `false`.

When disabled, the editor becomes non-interactive, ensuring that users cannot edit or modify the content.

Below are examples and code snippets demonstrating how to disable the Rich Text Editor by setting the `enabled` property to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/disable-editor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/disable-editor/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/disable-editor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/disable-editor/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### See Also