---
layout: post
title: Enable RTL in DropDownButton | Syncfusion
description: Enable right-to-left support in the Syncfusion ##Platform_Name## DropDownButton by setting the enableRtl property to true.
platform: ej2-asp-core-mvc
control: Create Right To Left Dropdownbutton
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to enable RTL in DropDownButton in ##Platform_Name## DropDownButton

DropDownButton component has RTL support. This can be achieved by setting [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_EnableRtl) as true.

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

