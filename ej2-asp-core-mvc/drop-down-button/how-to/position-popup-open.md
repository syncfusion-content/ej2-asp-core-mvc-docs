---
layout: post
title: How to position popup open in ##Platform_Name## DropDownButton | Syncfusion
description: Change the Syncfusion ##Platform_Name## DropDownButton popup open position by setting top and left for the popup element in the open event.
platform: ej2-asp-core-mvc
control: Position Popup Open
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to position popup open in ##Platform_Name## DropDownButton

Popup open position can be changed according to the requirement. Popup open position can be changed in [`open`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Open) event by setting `top` and `left` for the popup element.

In the following example, the `top` position of the popup element is changed in `open` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/dropdownbutton/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/dropdownbutton/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

