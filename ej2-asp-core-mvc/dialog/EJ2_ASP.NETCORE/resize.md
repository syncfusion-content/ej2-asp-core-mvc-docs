---
layout: post
title: Resize in ##Platform_Name## Dialog | Syncfusion
description: Resize the Syncfusion ##Platform_Name## Dialog dynamically by setting EnableResize to true and configuring the ResizeHandles and target properties.
platform: ej2-asp-core-mvc
control: Resize
publishingplatform: ##Platform_Name##
documentation: ug
---

# Resize in ##Platform_Name## Dialog

The Dialog supports resizing. To resize the Dialog, select and resize it by using its handle (grip) or by hovering on any of the edges or borders of the Dialog within the sample container.

The resizable Dialog can be created by setting the `EnableResize` property to `true`, which lets you change the Dialog size dynamically and view expanded content. The `ResizeHandles` property configures the directions in which the Dialog can be resized. When you configure the `target` property along with the `EnableResize` property, the Dialog can be resized only within its specified target container.

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

![dialog](./images/dialog_resize.gif)

## See Also

- [Getting Started](./getting-started.md)
- [Style](./style.md)
- [Animation](./animation.md)
- [Accessibility](./accessibility.md)
