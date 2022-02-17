---
layout: post
title: Customize Slider Bar in ##Platform_Name## Range Slider Component
description: Learn here all about Customize Slider Bar in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Customize Slider Bar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize Slider Bar

Slider appearance can be customized through CSS. By overriding the slider CSS classes, you can customize the slider bar. The
slider bar can be customized with different themes. By default, slider have class name `e-slider-track` for bar. The class can
be overridden with our own color values like the following code snippet.

```css
.e-control.e-slider .e-slider-track .e-range {
    background: linear-gradient(left, #e1451d 0, #fdff47 17%, #86f9fe 50%, #2900f8 65%, #6e00f8 74%, #e33df9 83%, #e14423 100%);
}
```

You can also apply background color for a certain range depending upon slider values, using change event.

```javascript
function change(args) {
    if (args.value > 0 && args.value <= 25) {
        // Change handle and range bar color to green when
        (sliderHandle).style.backgroundColor = 'green';
        (sliderTrack).style.backgroundColor = 'green';
    } else if (args.value > 25 && args.value <= 50) {
        // Change handle and range bar color to royal blue
        (sliderHandle).style.backgroundColor = 'royalblue';
        (sliderTrack).style.backgroundColor = 'royalblue';
    } else if (args.value > 50 && args.value <= 75) {
        // Change handle and range bar color to dark orange
        (sliderHandle).style.backgroundColor = 'darkorange';
        (sliderTrack).style.backgroundColor = 'darkorange';
    } else if (args.value > 75 && args.value <= 100) {
        // Change handle and range bar color to red
        (sliderHandle).style.backgroundColor = 'red';
        (sliderTrack).style.backgroundColor = 'red';
    }
}
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-bar.cs" %}
{% include code-snippet/slider/custom-bar/custom-bar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/custom-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-bar.cs" %}
{% include code-snippet/slider/custom-bar/custom-bar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Bar Customization](../images/bar-customization.png)