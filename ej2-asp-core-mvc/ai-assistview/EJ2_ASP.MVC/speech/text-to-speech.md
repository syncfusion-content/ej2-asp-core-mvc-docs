---
layout: post
title: Text-to-Speech With ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about configuration of Text-to-Speech with Azure OpenAI in ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Azure Open AI
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Text-to-Speech in ASP.NET MVC AI AssistView

The Syncfusion ASP.NET MVC AI AssistView control provides built-in `Text-to-Speech` (TTS) support using the browser's Web Speech API, specifically the [SpeechSynthesisUtterance](https://developer.mozilla.org/en-US/docs/Web/API/SpeechSynthesisUtterance) interface. This allows AI-generated responses into spoken audio, enhancing accessibility and user interaction.

## Prerequisites

Before integrating `Text-to-Speech`, ensure the following:

1. The Syncfusion AI AssistView control is properly set up in your ASP.NET MVC application.
    - [ASP.NET MVC Getting Started Guide](../getting-started)

2. The AI AssistView control is integrated with [Azure OpenAI](https://azure.microsoft.com/en-us/products/ai-foundry/models/openai).
    - [Integration of Azure OpenAI With ASP.NET MVC AI AssistView control](../ai-integrations/openai-integration)

## Configure text to speech

To enable the built-in Text-to-Speech functionality, add the `e-assist-audio` icon to the [ResponseToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html) property. When clicked, it fetches the text from the generated AI response and uses the browser's SpeechSynthesis API to read it aloud.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/tts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextToSpeech.cs" %}
{% include code-snippet/ai-assistview/speech/tts/texttospeechmvc.cs %}
{% endhighlight %}
{% endtabs %}

![Integrating Text-to-Speech with AI AssistView](../images/aiassist-tts.png)

## Configuring the speech settings

You can use the [TextToSpeechSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_TextToSpeechSettings) property to customize the speech synthesis behavior using the following available properties such as [Language](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewTextToSpeechSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewTextToSpeechSettings_Language), [SpeechPitch](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewTextToSpeechSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewTextToSpeechSettings_SpeechPitch), [SpeechRate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewTextToSpeechSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewTextToSpeechSettings_SpeechRate), [Volume](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewTextToSpeechSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewTextToSpeechSettings_Volume) and [Voice](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewTextToSpeechSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewTextToSpeechSettings_Voice).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/tts-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TextToSpeechSettings.cs" %}
{% include code-snippet/ai-assistview/speech/tts-settings/texttospeechsettingsmvc.cs %}
{% endhighlight %}
{% endtabs %}

![Text To Speech](../images/text-to-speech.png)

## See Also

* [Speech-to-Text](./speech-to-text)
