---
layout: post
title: Events in ##Platform_Name## OTP Input Control | Syncfusion
description: Checkout and learn here all about Events in ##Platform_Name## OTP Input control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: OTP Input
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ASP.NET Core OTP Input control

This section describes the OTP Input events that will be triggered when appropriate actions are performed. The following events are available in the OTP Input control.

## created

The OTP Input control triggers the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Created) event when the control rendering is completed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/created/tagHelper %}
{% endhighlight %}
{% endtabs %}

## focus 

The OTP Input control triggers the [focus](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Focus) event when the OTP Input is focused. The `OtpFocusEventArgs ` passed as an event argument provides the details of the focus event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/focus/tagHelper %}
{% endhighlight %}
{% endtabs %}

## blur

The OTP Input control triggers the [blur](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Blur) event when the OTP Input is focused out. The `OtpFocusEventArgs ` passed as an event argument provides the details of the blur event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/blur/tagHelper %}
{% endhighlight %}
{% endtabs %}

## input

The OTP Input control triggers the [input](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Input) event when the value of each OTP Input is changed. The `OtpInputEventArgs` passed as an event argument provides the details of the each value is changed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/input/tagHelper %}
{% endhighlight %}
{% endtabs %}

## valueChanged

The OTP Input control triggers the [valueChanged](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_ValueChanged) event when the value of the OTP Input is changed and matching the Otp input length. The `OtpChangedEventArgs` passed as an event argument provides the details when value is changed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/valueChanged/tagHelper %}
{% endhighlight %}
{% endtabs %}
