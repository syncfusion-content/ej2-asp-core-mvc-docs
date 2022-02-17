---
layout: post
title: Set Disabled State in ##Platform_Name## Switch Component
description: Learn here all about Set Disabled State in Syncfusion ##Platform_Name## Switch component and more.
platform: ej2-asp-core-mvc
control: Set Disabled State
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set disabled state

Switch can be disabled by setting the [`disabled`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Disabled) property to true.

The following example illustrates how to disable support in Switch component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/switch/disabled/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/disabled/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/switch/disabled/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/disabled/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

