---
layout: post
title: Rounded Corner DropDownButton in ##Platform_Name## | Syncfusion
description: Create a rounded corner Syncfusion ##Platform_Name## DropDownButton by adding a CSS class with border-radius and applying it via the cssClass property.
platform: ej2-asp-core-mvc
control: Create Dropdownbutton With Rounded Corner
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create a Rounded Corner DropDownButton in ##Platform_Name##

DropDownButton with rounded corner can be achieved by adding `border-radius` CSS property to button element.

In the following example, `e-round-corner` class is defined with `5px` `border-radius` property and added that class to button element using [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_CssClass) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/round/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/dropdownbutton/round/round.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/round/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Round.cs" %}
{% include code-snippet/dropdownbutton/round/round.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

