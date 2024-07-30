---
layout: post
title: Enable Scroll Option On All Day Section in ##Platform_Name## Schedule| Syncfusion
description: Learn here all about Enable Scroll Option On All Day Section in Syncfusion ##Platform_Name## Schedule component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Enable Scroll Option On All Day Section
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable scroll option on all-day section

When you have larger number of appointments in all-day row, it is difficult to view all the appointments properly. In that case you can enable scroller option for all-day row by setting true to [`EnableAllDayScroll`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_EnableAllDayScroll) whereas its default value is `false`. When setting this property to true, individual scroller for all-day row is enabled when it reaches its maximum height on expanding.

N> This property is not applicable for Scheduler with Height `auto`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/all-day-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/all-day-scroll/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/all-day-scroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/all-day-scroll/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

