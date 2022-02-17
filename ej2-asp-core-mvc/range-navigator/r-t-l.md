---
layout: post
title: R T L in ##Platform_Name## Range Navigator Component
description: Learn here all about R T L in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: R T L
publishingplatform: ##Platform_Name##
documentation: ug
---


# RTL

The Range Selector supports right-to-left (RTL), which can be enabled with the `enableRtl` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/range-navigator/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/range-navigator/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![RTL](images/rtl.png)