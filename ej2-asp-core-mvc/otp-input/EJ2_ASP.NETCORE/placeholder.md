---
layout: post
title: Placeholder in ##Platform_Name## OTP Input Control | Syncfusion
description: Checkout and learn here all about Placeholder in ##Platform_Name## OTP Input control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: OTP Input
publishingplatform: ##Platform_Name##
documentation: ug
---

# Placeholder in ASP.NET Core OTP Input control

The placeholder in OTP Input specifies the text that is shown as a hint or placeholder until the user enters a value in the input field. It acts as a guidance for the users regarding the expected input format or purpose of the input field.

You can set the placeholder text by using the [placeholder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Placeholder) property. Additionally, when providing a single character as the placeholder value all input fields within the OTP Input control will display the same character.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/placeholder/placeholder_char/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control with Single Placeholder Value](images/otp-char.png)

When a placeholder with multiple placeholder characters is provided each input field will display characters from the placeholder string in sequence based on the available OTP input length.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/placeholder/placeholder_string/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core OTP Input Control with Placeholder as string](images/otp-string.png)
