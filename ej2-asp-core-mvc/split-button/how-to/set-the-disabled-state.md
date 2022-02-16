---
layout: post
title: Set The Disabled State in ##Platform_Name## Split Button Component
description: Learn here all about Set The Disabled State in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Set The Disabled State
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the disabled state

SplitButton component can be enabled or disabled by disabled property. To disable SplitButton component, set the [`disabled`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_Disabled) property as true.

The following example illustrates how to set the disable state in SplitButton component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/disabled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/split-button/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/split-button/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

