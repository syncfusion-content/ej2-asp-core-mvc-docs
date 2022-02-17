---
layout: post
title: Position in ##Platform_Name## Tooltip Component
description: Learn here all about Position in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Position
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip Positioning

Tooltips can be attached to 12 static locations around the target.
On initializing the Tooltip, you can set the position property with any one of the following values:

* `TopLeft`
* `TopCenter`
* `TopRight`
* `BottomLeft`
* `BottomCenter`
* `BottomRight`
* `LeftTop`
* `LeftCenter`
* `LeftBottom`
* `RightTop`
* `RightCenter`
* `RightBottom`

> By default, Tooltip is placed at the `TopCenter` of the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-positions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltippositions.cs" %}
{% include code-snippet/tooltip/tooltip-positions/tooltippositions.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-positions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltippositions.cs" %}
{% include code-snippet/tooltip/tooltip-positions/tooltippositions.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Position](./images/tooltip-position.png)

## Tip pointer positioning

The Tooltip pointer can be attached or detached from the Tooltip by using the `showTipPointer` property.
Pointer positions can be adjusted using the `tipPointerPosition` property that can be assigned to one of the following values:

* `auto`
* `start`
* `middle`
* `end`

The following code example illustrates how to set the pointer to the start position of the Tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tip-pointer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tippointer.cs" %}
{% include code-snippet/tooltip/tip-pointer/tippointer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tip-pointer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tippointer.cs" %}
{% include code-snippet/tooltip/tip-pointer/tippointer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Tip Pointer Position](./images/tip-pointer.png)

By default, tip pointers are auto adjusted so that the arrow does not point outside the target element.

## Dynamic positioning

The Tooltip and its tip pointer can be positioned dynamically based on the target's location. This can be achieved by using the `refresh`
 method, which auto adjusts the Tooltip over the target.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/dynamic-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamicposition.cs" %}
{% include code-snippet/tooltip/dynamic-position/dynamicposition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/dynamic-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dynamicposition.cs" %}
{% include code-snippet/tooltip/dynamic-position/dynamicposition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> When mouse trailing option is enabled, the tip pointer position gets auto adjusted based on the target, and
> other position values like start, end, and middle are not applied (to prevent the pointer from moving out of target).

Output be like the below.

![ASP .NET Core - Tooltip - Dynamic Position](./images/dynamic-position.png)

## Mouse Trailing

Tooltips can be positioned relative to the mouse pointer. This behavior can be enabled or disabled by using the `mouseTrail` property. By default, it is set to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/mouse-trailing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mousetrailing.cs" %}
{% include code-snippet/tooltip/mouse-trailing/mousetrailing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/mouse-trailing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mousetrailing.cs" %}
{% include code-snippet/tooltip/mouse-trailing/mousetrailing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Mouse Trail](./images/mouse-trail.png)

> When mouse trailing option is enabled, the tip pointer position gets auto adjusted based on the target, and other position values like start, end, and middle are not applied (to prevent the pointer from moving out of target).

## Setting offset values

Offset values are set to specify the distance between the target and tooltip element.
`offsetX` and `offsetY` properties are used to specify the offset left and top values.

* `offsetX` specifies the distance between the target and Tooltip element in X axis.
* `offsetY` specifies the distance between the target and Tooltip element in Y axis.

The following code example illustrates how to set offset values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/offset-values/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Offsetvalues.cs" %}
{% include code-snippet/tooltip/offset-values/offsetvalues.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/offset-values/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Offsetvalues.cs" %}
{% include code-snippet/tooltip/offset-values/offsetvalues.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Offset Value](./images/offset-values.png)

> By default, collision is handled automatically and therefore when collision is detected the Tooltip fits horizontally and flips vertically.
