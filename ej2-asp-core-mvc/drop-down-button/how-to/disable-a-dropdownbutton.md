---
layout: post
title: Disable A Dropdownbutton in ##Platform_Name## Drop Down Button Component
description: Learn here all about Disable A Dropdownbutton in Syncfusion ##Platform_Name## Drop Down Button component and more.
platform: ej2-asp-core-mvc
control: Disable A Dropdownbutton
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable a DropDownButton

DropdownButton component can be enabled/disabled by giving [`disabled`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Disabled) property.
To disable DropdownButton component, the disabled property can be set as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/disabled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/dropdownbutton/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/dropdownbutton/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

