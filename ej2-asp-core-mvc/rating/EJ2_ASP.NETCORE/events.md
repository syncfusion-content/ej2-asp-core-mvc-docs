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

The rating control triggers the [beforeItemRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_BeforeItemRender) event before rendering each rating item. The `RatingItemEventArgs` passed as an event argument provides the details of the item to be rendered.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/events/beforeItemRender/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Created

The rating control triggers the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_Created) event when the rendering of the rating control is completed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/events/created-event/tagHelper %}
{% endhighlight %}
{% endtabs %}

## ValueChanged

The rating control triggers the [valueChanged](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_ValueChanged) event when the value of the rating is changed. The `RatingChangedEventArgs` passed as an event argument provides the details when value is changed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/events/valuechanged/tagHelper %}
{% endhighlight %}
{% endtabs %}

## OnItemHover

The rating control triggers the [onItemHover](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Rating.html#Syncfusion_EJ2_Inputs_Rating_OnItemHover) event when the rating item is hovered. The `RatingHoverEventArgs` passed as an event argument provides the details of the hovered item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rating/events/itemhover-event/tagHelper %}
{% endhighlight %}
{% endtabs %}