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

This section describes the rating events that will be triggered when appropriate actions are performed. The following events are available in the rating control.

## BeforeItemRender

The rating control triggers the [BeforeItemRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_BeforeItemRender) event before rendering each rating item. The `RatingItemEventArgs` passed as an event argument provides the details of the item to be rendered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/beforeitemrender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BeforeItemRender.cs" %}
{% include code-snippet/rating/events/beforeitemrender/beforeitemrender.cs %}
{% endhighlight %}
{% endtabs %}

## Created

The rating control triggers the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Created) event when the rendering of the rating control is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/created-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CreatedEvent.cs" %}
{% include code-snippet/rating/events/created-event/createdevent.cs %}
{% endhighlight %}
{% endtabs %}

## ValueChanged

The rating control triggers the [ValueChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ValueChanged) event when the value of the rating is changed. The `RatingChangedEventArgs` passed as an event argument provides the details when value is changed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/valuechanged-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValueChanged.cs" %}
{% include code-snippet/rating/events/valuechanged-event/valuechanged.cs %}
{% endhighlight %}
{% endtabs %}

## OnItemHover

The rating control triggers the [OnItemHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_OnItemHover) event when the rating item is hovered. The `RatingHoverEventArgs` passed as an event argument provides the details of the hovered item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rating/events/itemhover-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemHover.cs" %}
{% include code-snippet/rating/events/itemhover-event/itemhover.cs %}
{% endhighlight %}
{% endtabs %}
