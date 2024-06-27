---
layout: post
title: Input Types in ##Platform_Name## OTP Input Control | Syncfusion
description: Checkout and learn here all about Input Types in ##Platform_Name## OTP Input control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: OTP Input
publishingplatform: ##Platform_Name##
documentation: ug
---

# Input Types in ASP.NET MVC OTP Input control

## Types

This section explains the the various types of OTP (One-Time Password) input controls, explaining their default behaviors and appropriate use cases.

### Number type

You can set the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Type) property to [Number](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInputType.html#Syncfusion_EJ2_Inputs_OtpInputType_Number) to use this input type as number. This is ideal for OTP input scenarios with numeric-only codes. By default `Type` property is `Number`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/number/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/inputTypes/number/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC OTP Input Control as Number](images/otp-number.png)

### Text type

You can set the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Type) property to [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInputType.html#Syncfusion_EJ2_Inputs_OtpInputType_Text) to use this input type as text. This is suitable when the OTP input need to include both letters and numbers.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/inputTypes/text/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC OTP Input Control as Text](images/otp-text.png)

### Password type

You can set the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Type) property to [Password](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInputType.html#Syncfusion_EJ2_Inputs_OtpInputType_Password) to use this input type as password in the otp Input.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/password/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/inputTypes/password/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC OTP Input Control as Password](images/otp-password.png)

## Value

You can specify the value of OTP Input by using the [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Value) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/inputTypes/value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/inputTypes/value/default.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC OTP Input Control with Value](images/otp-number.png)
