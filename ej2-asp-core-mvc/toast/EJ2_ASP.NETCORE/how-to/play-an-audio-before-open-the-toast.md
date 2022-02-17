---
layout: post
title: Play An Audio Before Open The Toast in ##Platform_Name## Toast Component
description: Learn here all about Play An Audio Before Open The Toast in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Play An Audio Before Open The Toast
publishingplatform: ##Platform_Name##
documentation: ug
---


# Play an audio before open the toast

The following sample demonstrates how to play an audio in background while opening the toast by including audio play codes into the [`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_BeforeOpen) event function.

> To stop the audio after displaying the toast, use the [`open`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Open) event in toast. For further customization, check the Toast Events APIs.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/audio/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/audio/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/audio/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/audio/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


