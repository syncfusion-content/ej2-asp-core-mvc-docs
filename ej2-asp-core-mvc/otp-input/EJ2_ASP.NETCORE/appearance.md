---
layout: post
title: Appearance in ##Platform_Name## OTP Input Control | Syncfusion
description: Checkout and learn here all about Appearance in ##Platform_Name## OTP Input control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: OTP Input
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance in ASP.NET Core OTP Input control

You can also customize the appearance of OTP Input control.

## Setting input length

You can specify the length of OTP by using the [length](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Length) property. The default value is `4`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/appearance/length/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control with Length](images/otp-length.png)

## Disable inputs

You can disable the OTP Input control by using the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Disabled) property. By default the value is `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/appearance/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control as Disabled](images/otp-disabled.png)

## CssClass

You can customize the appearance of the OTP Input control, such as by changing its colors, fonts, sizes or other visual aspects by using the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_CssClass) property.

The OTP input control supports the following predefined styles that can be defined using the `cssClass` property. You can customize by replacing the `cssClass` property with the below defined class names.

| cssClass | Description |
| -------- | -------- |
| `e-success` | Used to represent a positive action. |
| `e-warning` | Used to represent an action with caution. |
| `e-error` | Used to represent a negative action. |

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/appearance/cssClass/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control with CssClass](images/otp-success.png)
