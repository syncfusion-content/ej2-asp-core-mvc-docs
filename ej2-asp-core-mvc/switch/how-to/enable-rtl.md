---
layout: post
title: How to enable RTL in ##Platform_Name## Toggle Switch Button | Syncfusion
description: Enable right-to-left (RTL) support in the Syncfusion ##Platform_Name## Toggle Switch Button by setting the `enableRtl` property to true.
platform: ej2-asp-core-mvc
control: Enable Rtl
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to enable RTL in ##Platform_Name## Toggle Switch Button

Switch component has RTL support. This can be achieved by setting [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_EnableRtl) as `true`.

The following example illustrates how to enable right-to-left support in Switch component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/switch/rtl/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/rtl/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/switch/rtl/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/rtl/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

