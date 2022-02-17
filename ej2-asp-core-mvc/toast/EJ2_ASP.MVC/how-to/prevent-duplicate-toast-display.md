---
layout: post
title: Prevent Duplicate Toast Display in ##Platform_Name## Toast Component
description: Learn here all about Prevent Duplicate Toast Display in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Prevent Duplicate Toast Display
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent duplicate toast display

You can prevent identical same toast displaying in a screen by the event function and terminate the toast displaying process by setting the cancel event property in the [`BeforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event.

The following sample demonstrates preventing duplicate title toast element displaying with custom code blocks.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/duplicate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/duplicate/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/duplicate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/duplicate/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

