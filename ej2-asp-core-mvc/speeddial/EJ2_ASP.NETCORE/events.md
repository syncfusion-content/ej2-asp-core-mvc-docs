---
layout: post
title: Events with ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn about events with ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ASP.NET Core SpeedDial

This section describes the Speed Dial events that will be triggered when appropriate actions are performed. The following events are available in the Speed Dial Control.

## Clicked Event

The speed dial control triggers the [`clicked`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Clicked) event when an action item is clicked.
You can use this event to perform the required action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/itemclicked/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Created 

The speed dial control triggers the [`created`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Buttons.SfSpeedDial.html#Syncfusion_Blazor_Buttons_SfSpeedDial_Created) event when SpeedDial control rendering is completed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/created/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% endif %}