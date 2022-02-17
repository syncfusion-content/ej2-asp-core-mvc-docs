---
layout: post
title: Create Right To Left Splitbutton in ##Platform_Name## Split Button Component
description: Learn here all about Create Right To Left Splitbutton in Syncfusion ##Platform_Name## Split Button component and more.
platform: ej2-asp-core-mvc
control: Create Right To Left Splitbutton
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create right-to-left SplitButton

SplitButton component has RTL support. This can be achieved by setting [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_EnableRtl) as `true`.

The following example illustrates how to enable right-to-left support in SplitButton component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/split-button/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/split-button/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

