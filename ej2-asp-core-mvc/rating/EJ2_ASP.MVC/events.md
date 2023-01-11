---
layout: post
title: Events in ##Platform_Name## Rating Control | Syncfusion
description: Learn here all about Events in Syncfusion ##Platform_Name## Rating control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in Rating Control

This section describes the rating events that will be triggered when appropriate actions are performed. The following events are available in the rating component.

## BeforeItemRender

The rating component triggers the [BeforeItemRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_BeforeItemRender) event before rendering each rating item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/beforeitemrender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BeforeItemRender.cs" %}
{% include code-snippet/speeddial/events/beforeitemrender/beforeitemrender.cs %}
{% endhighlight %}
{% endtabs %}

## Created

The rating component triggers the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Created) event when the rendering of the rating component is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/created-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CreatedEvent.cs" %}
{% include code-snippet/rating/events/created-vent/createdevent.cs %}
{% endhighlight %}
{% endtabs %}

## ValueChanged

The rating component triggers the [ValueChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ValueChanged) event when the value of the rating is changed. The changed value is passed as the event argument.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/valuechanged-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValueChanged.cs" %}
{% include code-snippet/speeddial/events/valuechanged-event/valuechanged.cs %}
{% endhighlight %}
{% endtabs %}

## OnItemHover

The rating component triggers the [OnItemHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_OnItemHover) passed as an event argument provides the details of the hovered item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/itemhover-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemHover.cs" %}
{% include code-snippet/rating/events/itemhover-event/itemhover.cs %}
{% endhighlight %}
{% endtabs %}
