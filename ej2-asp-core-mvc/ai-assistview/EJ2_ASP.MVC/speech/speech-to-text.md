---
layout: post
title: Speech-to-Text With ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about configuration of Speech-to-Text with Azure OpenAI in ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: AI AssistView
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Speech-to-Text in ASP.NET MVC AI AssistView

The Syncfusion ASP.NET MVC AI AssistView control integrates `Speech-to-Text` functionality through the browser's [Web Speech API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API). This enables the conversion of spoken words into text using the device's microphone, allowing users to interact with the AI AssistView through voice input.

## Prerequisites

Before integrating `Speech-to-Text`, ensure the following:

1. The Syncfusion AI AssistView control is properly set up in your ASP.NET MVC application.
    - [ASP.NET MVC Getting Started Guide](../getting-started)

2. The AI AssistView control is integrated with [Azure OpenAI](https://azure.microsoft.com/en-us/products/ai-foundry/models/openai).
    - [Integration of Azure OpenAI With ASP.NET MVC AI AssistView control](../ai-integrations/openai-integration)

## Enable built-in speech-to-text

You can enable speech-to-text support using the [SpeechToTextSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Speechtotextsettings) property. Set the `enable` property to `true` within the speechToTextSettings configuration to activate this feature.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/stt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SpeechToText.cs" %}
{% include code-snippet/ai-assistview/speech/stt/speechtotextmvc.cs %}
{% endhighlight %}
{% endtabs %}

![Speech-to-Text with AI AssistView](./../../images/speech-to-text.png)

## Configure speech recognition language

The [Lang](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Speechtotextsettings) property allows you to set the language code for speech recognition. By default, it uses the browser's language settings, but you can specify a custom language code (e.g., 'en-US', 'es-ES', 'fr-FR', etc.). This ensures that the speech recognition engine recognizes and transcribes speech in the specified language accurately.

## Configure speech button settings

The [ButtonSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Speechtotextsettings) property lets you customize the microphone button's appearance and text content by configuring the `content` (text displayed when idle), `stopContent` (text displayed when recording), `iconCss` (icon when idle), and `stopIconCss` (icon when recording). This allows you to tailor the UI to match your application's design and provide clear visual feedback to users.

## Enable interim results

The [AllowInterimResults](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Speechtotextsettings) property enables real-time transcription results while the user is still speaking. When set to `true`, the speech recognition engine returns interim transcripts (partial results) as it processes the audio. This provides immediate feedback to users, allowing them to see their speech being recognized in real-time before the final transcript is generated.

This example demonstrates how to set up the AI AssistView with all these speech recognition features enabled:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/speech-configuration/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SpeechToText.cs" %}
{% include code-snippet/ai-assistview/speech/speech-configuration/speechtotextmvc.cs %}
{% endhighlight %}
{% endtabs %}

![AllowInterimResults](./../../images/speech-config.png)

## Configure tooltip settings

You can customize the tooltips to the microphone button using the [TooltipSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Speechtotextsettings) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/tooltip-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SpeechToText.cs" %}
{% include code-snippet/ai-assistview/speech/tooltip-settings/speechtotextmvc.cs %}
{% endhighlight %}
{% endtabs %}

![TooltipSettings](./../../images/tooltip-settings.png)

## Speech to text events

The speech-to-text functionality provides events like `onStart` (when recognition starts), `onStop` (when it stops), `transcriptChanged` (when transcript updates), and `onError` (when errors occur).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/speech-events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SpeechToText.cs" %}
{% include code-snippet/ai-assistview/speech/speech-events/speechtotextmvc.cs %}
{% endhighlight %}
{% endtabs %}

## Browser Compatibility

The `SpeechToText` control relies on the [Speech Recognition API](https://ej2.syncfusion.com/aspnetmvc/documentation/speech-to-text/speech-recognition#browser-support), which has limited browser support. Refer to the [Browser Compatibility](https://ej2.syncfusion.com/aspnetmvc/documentation/speech-to-text/speech-recognition#browser-support) section for detailed information.

## See Also

* [Text-to-Speech](./text-to-speech)
