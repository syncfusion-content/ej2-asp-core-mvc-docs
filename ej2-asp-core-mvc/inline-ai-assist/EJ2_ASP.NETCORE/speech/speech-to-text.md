---
layout: post
title: Speech To Text in ##Platform_Name## Inline AI Assist | Syncfusion®
description: Checkout and learn about configuration of Speech-to-Text with Azure OpenAI in ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Inline AI Assist
publishingplatform: ##Platform_Name##
documentation: ug
---

# Speech-to-Text in ##Platform_Name## Inline AI Assist

The Syncfusion ASP.NET Core Inline AI Assist control integrates `Speech-to-Text` functionality through the browser's [Web Speech API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API). This enables the conversion of spoken words into text using the device's microphone, allowing users to provide voice input directly in the Inline AI Assist prompt area.

When content is selected, the recognized speech can be used as a prompt along with the selected content to provide contextual AI assistance. The generated response is displayed inline, where users can review and either accept or discard the suggestion.

## Prerequisites

Before integrating `Speech-to-Text`, ensure the following:

1. The Syncfusion Inline AI Assist control is properly set up in your ASP.NET Core application.
    - [ASP.NET Core Getting Started Guide](../getting-started)

2. The Inline AI Assist control is integrated with [Azure OpenAI](https://azure.microsoft.com/en-us/products/ai-foundry/models/openai).
    - [Integration of Azure OpenAI With ASP.NET Core Inline AI Assist control](../ai-integrations/openai-integration)

## Enable built-in speech-to-text

You can enable speech-to-text support using the [speechToTextSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_SpeechToTextSettings) property. Set the `Enable` property to `true` within the `speechToTextSettings` configuration to activate this feature.

Once enabled, a microphone button appears in the Inline AI Assist prompt area. The recognized speech is converted into prompt text and passed through the `PromptRequest` event when the prompt is submitted.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/stt/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SpeechToText](images/speech-to-text.webp)

## Configure speech recognition language

The [Lang](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_SpeechToTextSettings) property allows you to set the language code for speech recognition. By default, it uses the browser's language settings, but you can specify a custom language code (e.g., 'en-US', 'es-ES', 'fr-FR', etc.). This ensures that the speech recognition engine recognizes and transcribes speech in the specified language accurately.

## Configure speech button settings

The [ButtonSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_SpeechToTextSettings) property lets you customize the microphone button's appearance and text content by configuring the `Content` (text displayed when idle), `StopContent` (text displayed while recording), `IconCss` (icon shown when idle), and `StopIconCss` (icon shown while recording). This allows you to tailor the UI to match your application's design and provide clear visual feedback while speech recognition is active.

## Enable interim results

The [AllowInterimResults](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_SpeechToTextSettings) property enables real-time transcription results while the user is still speaking. When set to `true`, the speech recognition engine returns interim transcripts (partial results) as it processes the audio. This provides immediate feedback to users, allowing them to see their speech being recognized in real-time before the final transcript is generated.

This example demonstrates how to set up the Inline AI Assist with all these speech recognition features enabled:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/speech-configuration/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SpeechToTextConfig](images/speech-config.webp)

## Configure tooltip settings

You can customize the tooltips for the microphone button using the [TooltipSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_SpeechToTextSettings) property. The tooltip can provide different information based on whether speech recognition is idle or active.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/tooltip-settings/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SpeechToTextTooltip](images/tooltip-settings.webp)

## Speech-to-text events

The speech-to-text functionality provides events like `OnStart` (when recognition starts), `OnStop` (when it stops), `TranscriptChanged` (when the transcript is updated), and `OnError` (when errors occur). The recognized transcript is updated in the Inline AI Assist prompt area. When the prompt is submitted, both typed and speech-recognized input are available through the `Prompt` property of the `PromptRequest` event arguments.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/speech-events/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SpeechToText Events](images/speech-events.webp)

## Combine speech input with predefined commands

Speech input can be used with the predefined commands configured through the [CommandSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_CommandSettings) property. Users can select commands such as **Improve Content**, **Shorten**, **Elaborate**, or **Summarize**, and use the microphone to provide additional instructions for the selected content.

The predefined command supplies the intended action, while the speech input allows the user to add specific requirements. The selected content is included as context when the prompt is submitted to the AI service.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/predefined-commands/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PredefinedCommands](images/predefined-commands.webp)

## Review the generated response inline

When the [ResponseMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_ResponseMode) property is set to `Inline`, the response generated from the speech prompt is displayed within the selected content area. This allows users to review the generated content in its original context before applying it.

The [ResponseSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_ResponseSettings) property can be used to handle the response actions. Selecting **Accept** retains the generated content, while selecting **Discard** removes the suggestion and restores the original selected content.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/inline-response/tagHelper %}
{% endhighlight %}
{% endtabs %}

![InlineResponse](images/inline-response.webp)

## Browser compatibility

The speech-to-text functionality in Inline AI Assist relies on the browser's [Speech Recognition API](https://developer.mozilla.org/en-US/docs/Web/API/SpeechRecognition), which has limited browser support. Refer to the [Browser Compatibility](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/speech-recognition#browser-support) section for detailed information.

The browser may request permission to access the device's microphone when speech recognition starts. Speech-to-text functionality is available only when microphone permission is granted and the browser supports the Speech Recognition API.

## See Also

* [Getting Started with ASP.NET Core Inline AI Assist](../getting-started)
* [Azure OpenAI Integration with ASP.NET Core Inline AI Assist](../ai-integrations/openai-integration)