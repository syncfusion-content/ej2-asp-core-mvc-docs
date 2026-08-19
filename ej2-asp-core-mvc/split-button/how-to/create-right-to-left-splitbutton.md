---
layout: post
title: Create Right-to-Left SplitButton in ##Platform_Name## Split Button | Syncfusion
description: Enable right-to-left support in the Syncfusion ##Platform_Name## Split Button by setting the enableRtl property to display content in RTL layouts.
platform: ej2-asp-core-mvc
control: Create Right To Left Splitbutton
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create Right-to-Left SplitButton in ##Platform_Name## Split Button

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

