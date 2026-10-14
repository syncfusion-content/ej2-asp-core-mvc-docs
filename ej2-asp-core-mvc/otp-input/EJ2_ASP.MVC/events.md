---
layout: post
title: Events in ##Platform_Name## OTP Input | Syncfusion
description: Learn about ##Platform_Name## OTP Input events, including Created, Focus, Blur, Input, and ValueChanged, to handle user interactions effectively.
platform: ej2-asp-core-mvc
control: OTP Input
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## OTP Input

This section describes the OTP Input events that will be triggered when appropriate actions are performed. The following events are available in the OTP Input control.

## created

The OTP Input control triggers the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Created) event when the control rendering is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/events/created/default.cs %}
{% endhighlight %}
{% endtabs %}

## focus 

The OTP Input control triggers the [Focus](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Focus) event when the OTP Input is focused. The `OtpFocusEventArgs ` passed as an event argument provides the details of the focus event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/events/focus/default.cs %}
{% endhighlight %}
{% endtabs %}

## blur

The OTP Input control triggers the [Blur](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Blur) event when the OTP Input is focused out. The `OtpFocusEventArgs ` passed as an event argument provides the details of the blur event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/blur/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/events/blur/default.cs %}
{% endhighlight %}
{% endtabs %}

## input

The OTP Input control triggers the [Input](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_Input) event when the value of each OTP Input is changed. The `OtpInputEventArgs` passed as an event argument provides the details of the each value is changed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/input/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/events/input/default.cs %}
{% endhighlight %}
{% endtabs %}

## valueChanged

The OTP Input control triggers the [ValueChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.OtpInput.html#Syncfusion_EJ2_Inputs_OtpInput_ValueChanged) event when the value of the OTP Input is changed and matching the Otp input length. The `OtpChangedEventArgs` passed as an event argument provides the details when value is changed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/otp-input/events/valueChanged/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/otp-input/events/valueChanged/default.cs %}
{% endhighlight %}
{% endtabs %}
