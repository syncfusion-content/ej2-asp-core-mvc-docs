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

The Syncfusion TypeScript AI AssistView control integrates `Text-to-Speech` (TTS) functionality using the browser's Web Speech API, specifically the [SpeechSynthesisUtterance](https://developer.mozilla.org/en-US/docs/Web/API/SpeechSynthesisUtterance) interface. This allows AI-generated responses to be converted into spoken audio, enhancing accessibility and user interaction.

## Prerequisites

Before integrating `Text-to-Speech`, ensure the following:

1. The Syncfusion AI AssistView control is properly set up in your ASP.NET MVC application.
    - [ASP.NET MVC Getting Started Guide](../getting-started)

2. The AI AssistView control is integrated with [Azure OpenAI](https://microsoft.github.io/PartnerResources/skilling/ai-ml-academy/resources/openai).
    - [Integration of Azure OpenAI With ASP.NET MVC AI AssistView control](../ai-integrations/openai-integration)

## Configure Text-to-Speech

To enable Text-to-Speech functionality, modify the `Index.cshtml` file to incorporate the Web Speech API. A custom `Read Aloud` button is added to the response toolbar using the [ResponseToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html) property. When clicked, the [ItemClicked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewResponseToolbarSettings_ItemClicked) event extracts plain text from the generated AI response and use the browser SpeechSynthesis API to read it aloud.
 
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/speech/tts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SpeechToText.cs" %}
{% include code-snippet/ai-assistview/speech/tts/texttospeechmvc.cs %}
{% endhighlight %}
{% endtabs %}

![Integrating Text-to-Speech with AI AssistView](images/aiassist-tts.png)

## See Also

* [Speech-to-Text](./speech-to-text)
