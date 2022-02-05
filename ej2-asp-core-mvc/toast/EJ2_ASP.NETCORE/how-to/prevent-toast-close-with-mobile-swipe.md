---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Prevent Toast Close With Mobile Swipe of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Prevent Toast Close With Mobile Swipe
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent toast close with mobile swipe

You can prevent the toast close with mobile swipe action by setting [`beforeClose`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeClose) argument cancel value to true while argument type is swipe. The following code shows how to prevent toast close with mobile swipe.

The following sample demonstrates preventing toast close with mobile swipe element displaying with custom code blocks.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/preventSwipe/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/preventSwipe/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/preventSwipe/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/preventSwipe/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

