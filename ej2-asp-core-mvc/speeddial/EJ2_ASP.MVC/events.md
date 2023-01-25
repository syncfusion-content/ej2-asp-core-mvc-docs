---
layout: post
title: Events in ##Platform_Name## SpeedDial Control | Syncfusion
description: Checkout and learn here all about events and how to use them in ##Platform_Name## SpeedDial control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ASP.NET MVC SpeedDial Control

This section describes the Speed Dial events that will be triggered when appropriate actions are performed. The following events are available in the Speed Dial Control.

## Clicked event

The speed dial control triggers the [Clicked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Clicked) event when an action item is clicked. You can use this event to perform the required action.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/itemclicked/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ClickedEvent.cs" %}
{% include code-snippet/speeddial/events/itemclicked/clickedevent.cs %}
{% endhighlight %}
{% endtabs %}

## Created 

The speed dial control triggers the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_Created) event when SpeedDial control rendering is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CreatedEvent.cs" %}
{% include code-snippet/speeddial/events/created/createdevent.cs %}
{% endhighlight %}
{% endtabs %}

## Before open

The speed dial control triggers the [BeforeOpen](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_BeforeOpen) event before the SpeedDial popup is opened.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/before-open/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BeforeOpenEvent.cs" %}
{% include code-snippet/speeddial/events/before-open/beforeopenevent.cs %}
{% endhighlight %}
{% endtabs %}

## On open

The speed dial control triggers the [OnOpen](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OnOpen) event when SpeedDial popup is opened.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/on-open/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OnOpenEvent.cs" %}
{% include code-snippet/speeddial/events/on-open/onopenevent.cs %}
{% endhighlight %}
{% endtabs %}

## Before close

The speed dial control triggers the [BeforeClose](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_BeforeClose) event before the SpeedDial popup is closed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/before-close/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BeforeCloseEvent.cs" %}
{% include code-snippet/speeddial/events/before-close/beforecloseevent.cs %}
{% endhighlight %}
{% endtabs %}

## On close

The speed dial control triggers the [OnClose](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_OnClose) event when SpeedDial popup is closed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/on-close/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OnCloseEvent.cs" %}
{% include code-snippet/speeddial/events/on-close/oncloseevent.cs %}
{% endhighlight %}
{% endtabs %}

## Before item render

The speed dial control triggers the [BeforeItemRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_BeforeItemRender) event for each `SpeedDialItem` once its rendered..

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/events/before-item-render/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemRenderEvent.cs" %}
{% include code-snippet/speeddial/events/before-item-render/itemrenderevent.cs %}
{% endhighlight %}
{% endtabs %}