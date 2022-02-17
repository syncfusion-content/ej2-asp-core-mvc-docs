---
layout: post
title: Timeout in ##Platform_Name## Toast Component
description: Learn here all about Timeout in Syncfusion ##Platform_Name## Toast component and more.
platform: ej2-asp-core-mvc
control: Timeout
publishingplatform: ##Platform_Name##
documentation: ug
---


# Time out

The toast can be expired based on the [`TimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) property. The toast can live till the time out reaches without user interaction, a time out value is considered as a millisecond.

* The `TimeOut` delay can be visually represented using `Progress Bar`.

* The [`ExtendedTimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_ExtendedTimeout) property determines how long the toast should be displayed after a user hovers over it.

> You can terminate the process by using the [`ShowCloseButton`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_ShowCloseButton) property for destroying the toast at any time.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/timeout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/timeout/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/timeout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/timeout/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Static toast

You can prevent auto hiding in a toast as visible like static by setting zero (`0`) value in the [`TimeOut`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_TimeOut) Property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/static/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/static/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/static/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/static/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to close the toast with click/tab](./how-to/close-the-toast-with-click-tap/)
