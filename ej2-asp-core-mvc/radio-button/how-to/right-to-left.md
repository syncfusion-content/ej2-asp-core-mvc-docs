---
layout: post
title: Right-to-Left in ##Platform_Name## Radio Button | Syncfusion
description: Learn how to enable right-to-left (RTL) support in ##Platform_Name## Radio Button using the enableRtl property.
platform: ej2-asp-core-mvc
control: Right To Left
publishingplatform: ##Platform_Name##
documentation: ug
---


# Right-to-Left Support in ##Platform_Name## Radio Button

RadioButton component has RTL support. This can be achieved by setting [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_EnableRtl) as `true`.

The following example illustrates how to enable right-to-left support in RadioButton component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/rtl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/radio-button/howto/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/radio-button/howto/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

