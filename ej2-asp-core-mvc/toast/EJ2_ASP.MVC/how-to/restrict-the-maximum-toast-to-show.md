---
layout: post
title: Restrict The Maximum Toast To Show in ##Platform_Name## Toast Component
description: Learn here all about Restrict The Maximum Toast To Show in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Restrict The Maximum Toast To Show
publishingplatform: ##Platform_Name##
documentation: ug
---


# Restrict the maximum toast to show

You can restrict the maximum toast count by using the event callback function and terminate the toast displaying process by setting the cancel event property in the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event.

The following sample demonstrates restricting toast displaying up to 3. You can restrict by your own count with custom code blocks.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/maximum/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/maximum/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/maximum/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/maximum/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

