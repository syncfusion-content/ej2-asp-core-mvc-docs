---
layout: post
title: Right To Left in ##Platform_Name## Button Control | Syncfusion
description: Learn here all about Right To Left in Syncfusion ##Platform_Name## Button control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Right To Left
publishingplatform: ##Platform_Name##
documentation: ug
---


# Right to Left in Button Control

Button component has RTL support. This can be achieved by setting [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_EnableRtl) as true.

The following example illustrates how to enable right-to-left support in Button component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/rtl/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/button/howto/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Button with Right to Left view](../images/button-in-right-to-left.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Button/ButtonHowToSample).