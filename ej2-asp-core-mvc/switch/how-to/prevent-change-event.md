---
layout: post
title: Prevent State Change in ##Platform_Name## Switch Component
description: Learn here all about Prevent State Change in Syncfusion ##Platform_Name## Switch component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Prevent State Change
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent change event in ##Platform_Name## Switch control

The [BeforeChange](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_BeforeChange) event is triggered before the switch's state is altered. This event provides an opportunity to intercept and potentially cancel the change action before it is applied. It allows for implementing conditional logic or validating the change prior to it being rendered on the UI.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/switch/before-change/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/before-change/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/switch/before-change/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/switch/before-change/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

