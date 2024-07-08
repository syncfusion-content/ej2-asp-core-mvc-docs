---
layout: post
title: Input Types in ##Platform_Name## OTP Input Control | Syncfusion
description: Checkout and learn here all about Input Types in ##Platform_Name## OTP Input control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: OTP Input
publishingplatform: ##Platform_Name##
documentation: ug
---

# Input Types in ASP.NET Core OTP Input control

## Types

This section explains the the various types of OTP (One-Time Password) input controls, explaining their default behaviors and appropriate use cases.

### Number type

You can set the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Type) property to [Number](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInputType.html#Syncfusion_EJ2_Inputs_OtpInputType_Number) to use this input type as number. This is ideal for OTP input scenarios with numeric-only codes. By default `type` property is `Number`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/number/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control as Number](images/otp-number.png)

### Text type

You can set the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Type) property to [Text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInputType.html#Syncfusion_EJ2_Inputs_OtpInputType_Text) to use this input type as text. This is suitable when the OTP input need to include both letters and numbers.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/text/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control as Text](images/otp-text.png)

### Password type

You can set the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Type) property to [Password](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInputType.html#Syncfusion_EJ2_Inputs_OtpInputType_Password) to use this input type as password in the otp Input.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/password/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control as Password](images/otp-password.png)

## Value

You can specify the value of OTP Input by using the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Value) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/value/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control with Value](images/otp-number.png)
