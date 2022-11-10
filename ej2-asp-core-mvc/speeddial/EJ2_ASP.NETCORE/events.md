---
layout: post
title: Events in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn here all about events and how to use them in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ASP.NET Core SpeedDial Control

This section describes the Speed Dial events that will be triggered when appropriate actions are performed. The following events are available in the Speed Dial Control.

## Clicked event

The speed dial control triggers the [clicked](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Clicked) event when an action item is clicked. You can use this event to perform the required action.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/itemclicked/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Created 

The speed dial control triggers the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Created) event when SpeedDial control rendering is completed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/created/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Before open

The speed dial control triggers the [beforeOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_BeforeOpen) event before the SpeedDial popup is opened.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/before-open/tagHelper %}
{% endhighlight %}
{% endtabs %}

## On open

The speed dial control triggers the [onOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OnOpen) event when SpeedDial popup is opened.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/on-open/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Before close

The speed dial control triggers the [beforeClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_BeforeClose) event before the SpeedDial popup is closed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/before-close/tagHelper %}
{% endhighlight %}
{% endtabs %}

## On close

The speed dial control triggers the [onClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OnClose) event when SpeedDial popup is closed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/on-close/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Before item render

The speed dial control triggers the [beforeItemRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_BeforeItemRender) event for each `SpeedDialItem` once its rendered..

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/before-item-render/tagHelper %}
{% endhighlight %}
{% endtabs %}
