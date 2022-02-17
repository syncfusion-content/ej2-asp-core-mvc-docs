---
layout: post
title: Close The Toast With Click Tap in ##Platform_Name## Toast Component
description: Learn here all about Close The Toast With Click Tap in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Close The Toast With Click Tap
publishingplatform: ##Platform_Name##
documentation: ug
---


# Close the toast with click/tap

By default, the toasts are expired based on the [`TimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) value. You can customize the toast hiding process with `click/tap` action by setting the event args in the `clicked` callback function with `static Toast`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/click/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/click/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/click/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

