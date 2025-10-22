---
layout: post
title: Speech-to-Text With ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about configuration of Speech-to-Text with Azure OpenAI in ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Azure Open AI
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Speech-to-Text in ASP.NET Core Chat UI

The Syncfusion ASP.NET Core Chat UI control integrates `Speech-to-Text` functionality through the browser's [Web Speech API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API). This enables the conversion of spoken words into text using the device's microphone, allowing users to interact with the Chat UI through voice input.

## Prerequisites

Before integrating `Speech-to-Text`, install the [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core) NuGet package to use ASP.NET Core controls in the application.

## Set Up the Chat UI control

Follow the Syncfusion Chat UI [Getting Started](./getting-started) guide to configure and render the Chat UI control in the application.

## Configure Speech-to-Text

To enable Speech-to-Text functionality in the Angular Chat UI control, update the `index.cshtml` file to incorporate the Web Speech API.

The [SpeechToText](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/getting-started) control listens to audio input from the device’s microphone, transcribes spoken words into text, and updates the Chat UI’s editable footer with the recognized text. Once the transcription appears in the footer, users can send it as a message to others.

### Configuration Options

* **[`lang`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_Lang)**: Specifies the language for speech recognition. For example:

    * `en-US` for American English
    * `fr-FR` for French

* **[`allowInterimResults`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_AllowInterimResults)**: Set to `true` to receive real-time (interim) recognition results, or `false` to receive only final results.
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chatui/stt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gemini.cs" %}
{% include code-snippet/chatui/stt/speechtotext.cs %}
{% endhighlight %}
{% endtabs %}
 
![Integrating Speech-to-Text with Chat UI](images/chatui-stt.png)

## Error Handling

The `SpeechToText` control provides events to handle errors that may occur during speech recognition. For more information, refer to the [Error Handling](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/speech-recognition#error-handling) section in the documentation.

## Browser Compatibility

The `SpeechToText` control relies on the [Speech Recognition API](https://developer.mozilla.org/en-US/docs/Web/API/SpeechRecognition), which has limited browser support. Refer to the [Browser Compatibility](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/speech-recognition#browser-support) section for detailed information.
