---
layout: post
title: Create Right To Left Dropdownbutton in ##Platform_Name## Drop Down Button Component
description: Learn here all about Create Right To Left Dropdownbutton in Syncfusion ##Platform_Name## Drop Down Button component and more.
platform: ej2-asp-core-mvc
control: Create Right To Left Dropdownbutton
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create right-to-left DropDownButton

DropDownButton component has RTL support. This can be achieved by setting [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_EnableRtl) as true.

The following example illustrates how to enable right-to-left support in DropDownButton component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/dropdownbutton/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/dropdownbutton/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

