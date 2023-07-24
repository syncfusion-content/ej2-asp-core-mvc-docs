---
layout: post
title: Set The Disabled State in ##Platform_Name## Button Control | Syncfusion
description: Learn here all about how to set the Disabled State in Syncfusion ##Platform_Name## Button component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Set The Disabled State
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the disabled state

Button component can be enabled or disabled by giving [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_Disabled) property. To disable Button component, the `disabled` property can be set as `true`.

The following example demonstrates Button in `disabled` state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabledbutton.cs" %}
{% include code-snippet/button/howto/disabled/disabledbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Button/ButtonHowToSample).