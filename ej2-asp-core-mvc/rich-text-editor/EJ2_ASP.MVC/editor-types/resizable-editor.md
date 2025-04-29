---
layout: post
title: Resize Editor in ##Platform_Name## RichTextEditor Control | Syncfusion
description: Learn here all about Resizable Editor in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Resizable Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Resizable Editor in the ##Platform_Name## Rich Text Editor Control

The resizable editor feature allows dynamic resizing of the editor. Enable or disable this feature using the [EnableResize](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnableResize) property in the Rich Text Editor. When `EnableResize` is set to `true`, a grip appears at the bottom right corner for diagonal resizing.

The following sample demonstrates the resizable feature.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/resizable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/resizable/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/resizable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/resizable/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Rich Text Editor Resizable support](../../images/Resizable-Editor.png)

## Setting Editor Resize Limits

To restrict the resizable area of the Rich Text Editor, set the `min-width`, `max-width`, `min-height`, and `max-height` CSS properties for the component's wrapper element. 

By default, the control resizes up to the current viewport size. Apply these styles using the `e-richtexteditor`  CSS class in the component's wrapper.

```CSS

.e-richtexteditor {
  max-width: 880px;
  min-width: 250px;
  min-height: 250px;
  max-height: 400px;
}

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/max-resizable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/max-resizable/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/max-resizable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/max-resizable/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## See Also

* [Working with IFrame Editing Mode](./iframe)
* [Using the Markdown Editor](../../../markdown-editor/EJ2_ASP.MVC/getting-started)