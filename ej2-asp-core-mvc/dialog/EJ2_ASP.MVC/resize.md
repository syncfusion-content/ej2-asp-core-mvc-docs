---
layout: post
title: Resize in ##Platform_Name## Dialog Component
description: Learn here all about Resize in Syncfusion ##Platform_Name## Dialog component and more.
platform: ej2-asp-core-mvc
control: Resize
publishingplatform: ##Platform_Name##
documentation: ug
---


# Resizing

The Dialog supports resizing feature. To resize the dialog, we have to select and resize it by using its handle (grip) or hovering on any of the edges or borders of the dialog within the sample container.

The resizable dialog can be created by setting the `EnableResize` property to true, which is used to change the size of a dialog dynamically and view its content with expanded mode. The `ResizeHandles` property can also be configured for all the which directions in which the dialog should be resized. When you configure the target property along with the `EnableResize` property, the dialog can be resized within its specified target container.

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



Output be like the below.

![resize](./images/dialog_resize.gif)