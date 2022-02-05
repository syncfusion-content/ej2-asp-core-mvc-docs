---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Position of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Position
publishingplatform: ##Platform_Name##
documentation: ug
---


# Positions

The toast position can be updated based on predefined positions or customizable positions. The predefined position combinations are updated in the `X` and `Y` [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Position) properties.

## Predefined

`X` Positions

* Left
* Center
* Right

`Y` Positions

* Top
* Bottom

> In multiple toast display, the new toast position will not be updated on dynamic change of property values until the old toast messages removed.
> The toast occupies full width when you set the width to '100%', so the X positions will not affect the changes when the width is '100%'.

## Custom

Custom `X` and `Y` positions can be given as pixels/numbers/percentage. The number value is considered as pixels based on the top and left values updated in the toast.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toast/positions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/positions/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toast/positions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/toast/positions/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Render toast with different positions](./how-to/show-multiple-toasts-in-various-positions/)