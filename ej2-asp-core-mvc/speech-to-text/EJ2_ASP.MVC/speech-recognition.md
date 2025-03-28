---
layout: post
title: Speech recognition in ##Platform_Name## SpeechToText Control | Syncfusion
description: Checkout and learn about Speech recognition in ##Platform_Name## SpeechToText control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: SpeechToText
publishingplatform: ##Platform_Name##
documentation: ug
---

# Speech recognition in ##Platform_Name## SpeechToText control

## Retrieving transcripts

You can use the [Transcript](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_Transcript) property to retrieve the transcribed text from the spoken text. This property allows to display the transcribed text once the speech recognition process is started.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/speechRecognition/transcript/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Transcript.cs" %}
{% include code-snippet/speech-to-text/speechRecognition/transcript/transcript.cs %}
{% endhighlight %}
{% endtabs %}

![Transcript](images/transcript.png)

## Setting language

You can use the [Lang](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_Lang) property to specify the language for speech recognition. Setting this property ensures that the recognition engine interprets the spoken words correctly based on the specified locale such as `en-US` for American `English`, `fr-FR` for `French`, and more.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/speechRecognition/language/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Language.cs" %}
{% include code-snippet/speech-to-text/speechRecognition/language/language.cs %}
{% endhighlight %}
{% endtabs %}

![Language](images/language.png)

## Allowing interim results

You can use the [AllowInterimResults](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_AllowInterimResults) property to enable or disable interim results. When set to `true`, the recognized speech will be displayed in real time as words are spoken. When set to `false`, only final results will be displayed after recognition is complete. By default, the value is `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/speechRecognition/interimResults/razor %}
{% endhighlight %}
{% highlight c# tabtitle="InterimResults.cs" %}
{% include code-snippet/speech-to-text/speechRecognition/interimResults/interimResults.cs %}
{% endhighlight %}
{% endtabs %}

![InterimResults](images/interimResults.png)

## Managing listening state

You can use the [ListeningState](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_ListeningState) property to manage the listening state of the control. The possible values are [Inactive](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToTextState.html#Syncfusion_EJ2_Inputs_SpeechToTextState_Inactive), [Listening](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToTextState.html#Syncfusion_EJ2_Inputs_SpeechToTextState_Listening) and [Stopped](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToTextState.html#Syncfusion_EJ2_Inputs_SpeechToTextState_Stopped). By default, the value is `Inactive`.

### Inactive

The control is in idle state with no active speech recognition.

### Listening

It is actively listening which captures and transcribes speech with a stop icon and blinking animation.

### Stopped

Denotes the speech recognition has ended, and no further speech is being processed.

Below sample demonstrates the usage of [ListeningState](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_ListeningState) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/speechRecognition/listeningState/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListeningState.cs" %}
{% include code-snippet/speech-to-text/speechRecognition/listeningState/listeningState.cs %}
{% endhighlight %}
{% endtabs %}

![ListeningState](images/listening.png)

## Show or hide tooltip

You can use the [ShowTooltip](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_ShowTooltip) property to specify the tooltip text to be displayed on hovering the SpeechToText button. By default, the value is `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/speechRecognition/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/speech-to-text/speechRecognition/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

![Tooltip](images/tooltip.png)

## Setting disabled

You can use the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_Disabled) property to disable the SpeechToText, preventing user interaction when set to `true`. By default, the value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/speechRecognition/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/speech-to-text/speechRecognition/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

![Disabled](images/disabled.png)

## Setting html attributes

You can use the [HtmlAttributes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_HtmlAttributes) property to assign custom attributes to the SpeechToText control for the button element.

## Error handling

The SpeechToText control handles various errors that may occur during speech recognition. The following table lists the possible errors and their causes:

| Error                | Cause                                                                                        |
|----------------------|----------------------------------------------------------------------------------------------|
| `no-speech`            | The microphone did not detect any speech input.                                              |
| `aborted`              | The speech recognition process was intentionally terminated.                                 |
| `audio-capture`        | The system was unable to detect a microphone device.                                         |
| `not-allowed`          | Access to the microphone was denied by the user or browser settings.                         |
| `service-not-allowed`  | The current context does not permit the use of the speech recognition service.               |
| `network`              | A network issue is preventing the speech recognition service from functioning.               |
| `unsupported-browser`  | The browser being used does not support the SpeechRecognition API.                           |
| `default`              | An unidentified error occurred during the speech recognition process.                        |

## Browser support

The SpeechToText control relies on the `Speech Recognition API` for processing the speech input. Ensure that the browser supports this API before implementation.

|    Browser    |    Supported versions    |
|--------------|---------------|
|    Chrome     |    25+    |
|    Edge     |    79+    |
|    Firefox     |    Not Supported    |
|    Safari     |    12+    |
|    Opera     |    30+    |
