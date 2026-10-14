---
layout: post
title: Enable right-to-left in ##Platform_Name## Checkbox | Syncfusion
description: Flip the ##Platform_Name## Checkbox to right-to-left layout for RTL languages by setting the enableRtl property to true.
platform: ej2-asp-core-mvc
control: Right To Left
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable right-to-left in ##Platform_Name## Checkbox

CheckBox component has RTL support. This can be achieved by setting [enableRtl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_EnableRtl) as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/rtl/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/check-box/howto/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![CheckBox with Right to Left view](../images/checkbox-right-to-left.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/CheckBox/CheckBoxUGSample).