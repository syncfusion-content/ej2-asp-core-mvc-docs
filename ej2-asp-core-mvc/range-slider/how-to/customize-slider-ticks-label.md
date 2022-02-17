---
layout: post
title: Customize Slider Ticks Label in ##Platform_Name## Range Slider Component
description: Learn here all about Customize Slider Ticks Label in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Customize Slider Ticks Label
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize Slider Ticks label

Slider view can be customized via CSS. By overriding the slider CSS classes, you can customize the ticks. The ticks in slider
allows you to easily identify the current value/values of the slider. It contains
[`smallStep`](https://ej2.syncfusion.com/documentation/slider/api-ticksData.html?lang=typescript#smallstep)
and [`largeStep`](https://ej2.syncfusion.com/documentation/slider/api-ticksData.html?lang=typescript#largestep). By default,
slider has class `e-tick` for slider ticks. You can override the class as per your requirement. Refer to the following code
snippet to render ticks.

```css
.e-scale .e-tick.e-custom::before {
    content: '\e967';
    position: absolute;
}
```

Here, the color for rendered ticks has been applied through nth-child(`child_number`). The color is applied to the value of the `child_number` in the slider.

```css
#ticks_slider .e-scale :nth-child(1)::before {
    color: red;
}
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-ticks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-ticks.cs" %}
{% include code-snippet/slider/custom-ticks/custom-ticks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-ticks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-ticks.cs" %}
{% include code-snippet/slider/custom-ticks/custom-ticks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Ticks Customization](../images/ticks-customization.png)