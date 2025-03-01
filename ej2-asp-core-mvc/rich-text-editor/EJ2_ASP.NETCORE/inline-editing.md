---
layout: post
title: Inline Mode in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Inline Mode in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Inline Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Inline editing in the ##Platform_Name## Rich Text Editor Control

Inline editing is a feature of the Rich Text Editor that allows users to edit content directly within the editor where it is displayed. Unlike traditional editing interfaces where the editor toolbar is in a separate area at the top or bottom, inline editing offers a seamless, on-the-spot editing experience. You can click on the text or select the text you wish to edit and make changes immediately.

Enable inline editing in the Rich Text Editor by using the [inlineMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_InlineMode) with the `enable` property as `true`. This configuration activates the feature, allowing direct content editing within its displayed context.

## Toolbar on Selection

The inline toolbar in the Rich Text Editor is triggered based on the [onSelection](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorInlineMode.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorInlineMode_OnSelection) option within the inlineMode settings. 

When `onSelection` is set to `true`, the toolbar appears only when text is selected. If `onSelection` is set to `false`, the inline toolbar appears when editable text is focused, regardless of selection.

This feature enhances the inline editing experience by providing immediate access to formatting options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/inline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/inline/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/inline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/inline/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Rich Text Editor InlineMode](../images/inline.png)

