---
layout: post
title: Custom Animation in ##Platform_Name## In Place Editor Component
description: Learn here all about Custom Animation in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Custom Animation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set custom animation for popup mode

In popup mode, the In-place Editor rendered with the Syncfusion ASP.NET MVC `Tooltip` control. You can use tooltip properties and events to customize the popup by configure properties into the [`Model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property inside the [`PopupSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_PopupSettings) API.

In the following sample, popup animation can be customized by passing animation effect using the `Model` property and the dynamic animation effect changes configured from the Syncfusion ASP.NET MVC `DropDownList` control `change` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/custom-animation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/custom-animation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/custom-animation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/custom-animation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![custom-animation](../../in-place-editor/images/custom-animation.PNG)