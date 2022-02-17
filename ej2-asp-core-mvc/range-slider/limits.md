---
layout: post
title: Limits in ##Platform_Name## Range Slider Component
description: Learn here all about Limits in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Limits
publishingplatform: ##Platform_Name##
documentation: ug
---


# Movement Limits and Drag Interval

The slider limits restrict the slider thumb between a particular range. This is used if higher or lower value affects the process
or product where the slider is being used.

The following are the six options in the slider's limits object. Each API in the limits object is optional.

* ``enabled``: Enables the limits in the Slider.
* ``minStart``: Sets the minimum limit for the first handle.
* ``minEnd``: Sets the maximum limit for the first handle.
* ``maxStart``: Sets the minimum limit for the second handle.
* ``maxEnd``: Sets the maximum limit for the second handle.
* ``startHandleFixed``: Locks the first handle.
* ``endHandleFixed``: Locks the second handle.

## Default and MinRange Slider limits

There is only one handle in the Default and MinRange Slider, so ``minStart``, ``minEnd``, and ``startHandleFixed`` options can be used.
When the limits are enabled in the Slider, the limited area becomes darken. So you can differentiate the allowed and restricted area.
Refer to the following snippet to enable the limits in the Slider.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/default-limits/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default-limits.cs" %}
{% include code-snippet/slider/default-limits/default-limits.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/default-limits/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default-limits.cs" %}
{% include code-snippet/slider/default-limits/default-limits.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Limits](./images/slider-limits.png)

## Range Slider limits

In the range slider, both handles can be restricted and locked from the limit's object. In this sample, the first handle is limited between
10 and 40, and the second handle is limited between 60 and 90.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/range-limits/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range-limits.cs" %}
{% include code-snippet/slider/range-limits/range-limits.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/range-limits/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range-limits.cs" %}
{% include code-snippet/slider/range-limits/range-limits.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Range Slider Limits](./images/range-slider-limits.png)

## Handle lock

The movement of slider handles can be locked by enabling the ``startHandleFixed`` and ``endHandleFixed`` properties in the limit's object.
In this sample, the movement of both slider handles has been locked.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/handle-lock/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Handle-lock.cs" %}
{% include code-snippet/slider/handle-lock/handle-lock.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/handle-lock/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Handle-lock.cs" %}
{% include code-snippet/slider/handle-lock/handle-lock.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Handle Lock](./images/handle-lock.png)