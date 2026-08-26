---
layout: post
title: Resize in ##Platform_Name## Dialog | Syncfusion
description: Resize the Syncfusion ##Platform_Name## Dialog dynamically by setting EnableResize to true and configuring the ResizeHandles and target properties.
platform: ej2-asp-core-mvc
control: Resize
publishingplatform: ##Platform_Name##
documentation: ug
---

# Resize in ASP.NET MVC Dialog

The Dialog supports resizing. To resize the Dialog, select and resize it using its handle (grip) or by hovering over any of the edges or borders of the Dialog within the sample container.

A resizable Dialog can be created by setting the `EnableResize` property to `true`, which changes the size of a Dialog dynamically so its content can be viewed in expanded form. The `ResizeHandles` property can be configured for the directions in which the Dialog should be resized. When you configure the `target` property along with the `EnableResize` property, the Dialog can be resized within its specified target container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/getting-started/resize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/getting-started/resize/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/getting-started/resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/getting-started/resize/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

The output looks like the following.

![Dialog being resized by dragging its grip handle](./images/dialog_resize.gif)