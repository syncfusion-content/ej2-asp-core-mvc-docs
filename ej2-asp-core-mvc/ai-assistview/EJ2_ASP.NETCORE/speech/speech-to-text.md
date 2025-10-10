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

The Syncfusion ASP.NET Core AI AssistView control supports `Speech-to-Text` functionality through the browser's [Web Speech API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API), enabling conversion of spoken words into text using the device's microphone.

## Prerequisites

Before integrating `Speech-to-Text`, ensure the following:

1. The Syncfusion AI AssistView control is properly set up in your ASP.NET Core application.
    - [ASP.NET Core Getting Started Guide](../getting-started)

2. The AI AssistView control is integrated with [Azure OpenAI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai).
    - [Integration of Azure OpenAI With ASP.NET Core AI AssistView control](../ai-integrations/openai-integration)

## Configure Speech-to-Text

To enable Speech-to-Text functionality, modify the `Index.cshtml` file to incorporate the Web Speech API. The [SpeechToText](https://ej2.syncfusion.com/aspnetcore/documentation/speech-to-text/getting-started) control listens for microphone input, transcribes spoken words, and updates the AI AssistView's editable footer with the transcribed text. The transcribed text is then sent as a prompt to the Azure OpenAI service via the AI AssistView control.
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/stt/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gemini.cs" %}
{% include code-snippet/ai-assistview/speech/stt/speechtotextcore.cs %}
{% endhighlight %}
{% endtabs %}
 
![Integrating Speech-to-Text with AI AssistView](images/aiassist-stt.png)

## See Also

* [Text-to-Speech](./text-to-speech)
