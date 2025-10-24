---
layout: post
title: Speech-to-Text With ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about configuration of Speech-to-Text with Azure OpenAI in ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Azure Open AI
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Speech-to-Text in ASP.NET Core AI AssistView

The Syncfusion ASP.NET Core AI AssistView control integrates `Speech-to-Text` functionality through the browser's [Web Speech API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API). This enables the conversion of spoken words into text using the device's microphone, allowing users to interact with the AI AssistView through voice input.

## Prerequisites

Before integrating `Speech-to-Text`, ensure the following:

1. The Syncfusion AI AssistView control is properly set up in your ASP.NET Core application.
    - [ASP.NET Core Getting Started Guide](../getting-started)

2. The AI AssistView control is integrated with [Azure OpenAI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai).
    - [Integration of Azure OpenAI With ASP.NET Core AI AssistView control](../ai-integrations/openai-integration)

## Configure Speech-to-Text

To enable Speech-to-Text functionality in the ASP.NET Core AssistView control, update the `index.cshtml` file to incorporate the Web Speech API.

The [SpeechToText](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/getting-started) control listens to audio input from the device’s microphone, transcribes spoken words into text, and updates the AssistView’s editable footer using the [footerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_FooterTemplate) property to display the transcribed text. The transcribed text is then sent as a prompt to the Azure OpenAI service via the AI AssistView component.

### Configuration Options

* **[`lang`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_Lang)**: Specifies the language for speech recognition. For example:

    * `en-US` for American English
    * `fr-FR` for French

* **[`allowInterimResults`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_AllowInterimResults)**: Set to `true` to receive real-time (interim) recognition results, or `false` to receive only final results.
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/stt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gemini.cs" %}
{% include code-snippet/ai-assistview/speech/stt/speechtotextcore.cs %}
{% endhighlight %}
{% endtabs %}
 
![Integrating Speech-to-Text with AI AssistView](images/aiassist-stt.png)

## Error Handling

The `SpeechToText` control provides events to handle errors that may occur during speech recognition. For more information, refer to the [Error Handling](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/speech-recognition#error-handling) section in the documentation.

## Browser Compatibility

The `SpeechToText` control relies on the [Speech Recognition API](https://developer.mozilla.org/en-US/docs/Web/API/SpeechRecognition), which has limited browser support. Refer to the [Browser Compatibility](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/speech-recognition#browser-support) section for detailed information.

## See Also

* [Text-to-Speech](./text-to-speech)
