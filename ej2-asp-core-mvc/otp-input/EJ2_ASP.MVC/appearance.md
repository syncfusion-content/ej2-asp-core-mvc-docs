---
layout: post
title: Appearance in ##Platform_Name## OTP Input | Syncfusion
description: Customize the appearance of ##Platform_Name## OTP Input by configuring input length, disabled state, and predefined CSS classes for styling.
platform: ej2-asp-core-mvc
control: OTP Input
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance in ##Platform_Name## OTP Input

You can also customize the appearance of OTP Input control.

## Setting input length

You can specify the length of OTP by using the [Length](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Length) property. The default value is `4`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/appearance/length/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/appearance/length/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC OTP Input Control with Length](images/otp-length.png)

## Disable inputs

You can disable the OTP Input control by using the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Disabled) property. By default the value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/appearance/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/appearance/disabled/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC OTP Input Control as Disabled](images/otp-disabled.png)

## CssClass

You can customize the appearance of the OTP Input control, such as by changing its colors, fonts, sizes or other visual aspects by using the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_CssClass) property.

The OTP input control supports the following predefined styles that can be defined using the `cssClass` property. You can customize by replacing the `cssClass` property with the below defined class names.

| cssClass | Description |
| -------- | -------- |
| `e-success` | Used to represent a positive action. |
| `e-warning` | Used to represent an action with caution. |
| `e-error` | Used to represent a negative action. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/appearance/cssClass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/appearance/cssClass/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC OTP Input Control with CssClass](images/otp-success.png)