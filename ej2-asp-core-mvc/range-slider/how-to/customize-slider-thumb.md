---
layout: post
title: Customize Slider Thumb in ##Platform_Name## Range Slider Component
description: Learn here all about Customize Slider Thumb in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Customize Slider Thumb
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize Slider Thumb

Slider appearance can be customized through CSS. By overriding the slider CSS classes, you can customize the thumb. By default,
slider has unique class `e-handle` for slider thumb. You can override the following class as per your requirement. Here, in the
sample, the slider thumb has been customized to square, circle, oval shapes, and background image has also been customized.

```css
.e-control.e-slider .e-handle {
    background-image: url('https://ej2.syncfusion.com/demos/src/slider/images/thumb.png');
    background-color: transparent;
    height: 25px;
    width: 25px;
}
#square_slider.e-control.e-slider .e-handle {
    border-radius: 0%;
    background-color: #f9920b;
    border: 0;
}
#circle_slider.e-control.e-slider .e-handle {
    border-radius: 50%;
    background-color: #f9920b;
    border: 0;
}
#oval_slider.e-control.e-slider .e-handle {
    height: 25px;
    width: 8px;
    top: 3px;
    border-radius: 15px;
    background-color: #f9920b;
}
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-thumb/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-thumb.cs" %}
{% include code-snippet/slider/custom-thumb/custom-thumb.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-thumb/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-thumb.cs" %}
{% include code-snippet/slider/custom-thumb/custom-thumb.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Thumb Customization](../images/thumb-customization.png)