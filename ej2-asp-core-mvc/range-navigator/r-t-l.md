---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about R T L of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
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