---
layout: post
title: Right To Left in ##Platform_Name## Check Box Control | Syncfusion
description: Learn here all about Right to Left in Syncfusion ##Platform_Name## Check Box control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Right To Left
publishingplatform: ##Platform_Name##
documentation: ug
---


# Right To Left in Check Box Control

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

![CheckBox with Right to Left view](images/checkbox-right-to-left.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/CheckBox/CheckBoxUGSample).