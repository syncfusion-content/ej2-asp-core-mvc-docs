---
layout: post
title: Custom in ##Platform_Name## Range Navigator Component
description: Learn here all about Custom in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Custom
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

## Navigator appearance

The Range Selector can be customized by using the `navigatorStyleSettings`. The `selectedRegionColor` property is used to specify the color for the selected region, whereas the `unselectedRegionColor` property is used to specify the color for the unselected region.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/appearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Appearance.cs" %}
{% include code-snippet/range-navigator/custom/appearance/appearance.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/appearance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Appearance.cs" %}
{% include code-snippet/range-navigator/custom/appearance/appearance.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Range Selector appearance](images/custom/appearance.png)

## Thumb

The thumb property allows to customize the border, fill color, size, and type of thumb. Thumbs can be of two shapes: **Circle** and **Rectangle**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/thumb/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Thumb.cs" %}
{% include code-snippet/range-navigator/custom/thumb/thumb.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/thumb/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Thumb.cs" %}
{% include code-snippet/range-navigator/custom/thumb/thumb.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Thumb](images/custom/thumb.png)

## Border customization

Using the `navigatorBorder`, the `width` and `color` of the Range Selector border can be customized.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/border/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/range-navigator/custom/border/border.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/border/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Border.cs" %}
{% include code-snippet/range-navigator/custom/border/border.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Range Selector Border](images/custom/border.png)

## Deferred update

If the `enableDeferredUpdate` property is set to **true**, then the changed event will be triggered after dragging the slider. If the `enableDeferredUpdate` is **false**, then the changed event will be triggered when dragging the slider. By default,
the `enableDeferredUpdate` is set to **false**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/defer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Snap.cs" %}
{% include code-snippet/range-navigator/custom/defer/snap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/defer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Snap.cs" %}
{% include code-snippet/range-navigator/custom/defer/snap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Allow snapping

The `allowSnapping` property toggles the placement of the slider exactly to the left or on the nearest interval.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/snap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Snap.cs" %}
{% include code-snippet/range-navigator/custom/snap/snap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/snap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Snap.cs" %}
{% include code-snippet/range-navigator/custom/snap/snap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Animation

The speed of the animation can be controlled using the `animationDuration` property. The default value of the `animationDuration` property is **500** milliseconds.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/range-navigator/custom/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/custom/animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation.cs" %}
{% include code-snippet/range-navigator/custom/animation/animation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Grid and Tick Lines](./grid-tick/)
* [Labels](./labels/)