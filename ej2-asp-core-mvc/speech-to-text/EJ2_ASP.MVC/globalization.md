---
layout: post
title: Globalization in ##Platform_Name## SpeechToText Control | Syncfusion
description: Checkout and learn about Globalization in ##Platform_Name## SpeechToText control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: SpeechToText
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ##Platform_Name## SpeechToText control

## Localization

The SpeechToText can be localized to any culture by defining the text in the corresponding culture. The default locale of the SpeechToText is `en-US` (English). The following table represents the default text of the SpeechToText in `en-US` culture.

|KEY|Text|
|----|----|
|abortedError|Speech recognition was aborted.|
|audioCaptureError|No microphone detected. Ensure your microphone is connected.|
|defaultError|An unknown error occurred.|
|networkError|Network error occurred. Check your internet connection.|
|noSpeechError|No speech detected. Please speak into the microphone.|
|notAllowedError|Microphone access denied. Allow microphone permissions.|
|serviceNotAllowedError|Speech recognition service is not allowed in this context.|
|unsupportedBrowserError|The browser does not support the SpeechRecognition API.|
|startAriaLabel|Press to start speaking and transcribe your words|
|stopAriaLabel|Press to stop speaking and end transcription|
|startTooltipText|Start listening|
|stopTooltipText|Stop listening|

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/globalization/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/speech-to-text/globalization/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

![Localization](images/localization.png)

## RTL

RTL provides an option to switch the text direction and layout of the SpeechToText control from right to left by setting the [EnableRtl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_EnableRtl) property to true.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/globalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/speech-to-text/globalization/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

![RTL](images/rtl.png)
