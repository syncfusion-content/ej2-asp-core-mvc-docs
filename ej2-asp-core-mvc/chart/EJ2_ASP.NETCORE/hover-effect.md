---
layout: post
title: Hovering effect in ##Platform_Name## Chart Control | Syncfusion
description: Learn how to enable and customize hover effects in the Syncfusion ##Platform_Name## Chart control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Chart
publishingplatform: ##Platform_Name##
documentation: ug
---

# Hover effect in ##Platform_Name## Chart component

The chart supports a hover effect for rectangular series and their data points when the pointer moves over them.

## Enable hover effect

You can enable the hover effect for the rectangular series chart by setting the `visible` property in the `hoverEffectSettings` model to `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/hover-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HoverEffect.cs" %}
{% include code-snippet/chart/user-interaction/hover-cs1/hover.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/hover-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HoverEffect.cs" %}
{% include code-snippet/chart/user-interaction/hover-cs1/hover.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customize the hover effect

You can customize the hover effect color and border width by setting the `color` and `width` properties in the `hoverEffectSettings` model.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/hover-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HoverCustomization.cs" %}
{% include code-snippet/chart/user-interaction/hover-cs2/hoverCus.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chart/user-interaction/hover-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HoverCustomization.cs" %}
{% include code-snippet/chart/user-interaction/hover-cs2/hoverCus.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

>Note: The hover effect applies to rectangular series types, such as Column and Bar. For Line and Area series, the trackball feature is used instead.