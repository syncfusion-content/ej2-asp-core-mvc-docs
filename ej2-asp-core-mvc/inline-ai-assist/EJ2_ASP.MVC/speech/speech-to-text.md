---
layout: post
title: Speech To Text in ##Platform_Name## Inline AI Assist | Syncfusion®
description: Learn how to enable and configure speech-to-text in the ##Platform_Name## Inline AI Assist control using the browser Web Speech API.
platform: ej2-asp-core-mvc
control: Inline AI Assist
publishingplatform: ##Platform_Name##
documentation: ug
---

# Speech-to-Text in ASP.NET MVC Inline AI Assist

The Syncfusion ASP.NET MVC Inline AI Assist control supports `Speech-to-Text` through the browser's [Web Speech API](https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API). This converts spoken words into text in the Inline AI Assist prompt, allowing users to submit voice prompts while working with selected content.

When content is selected, the recognized speech can be used as a prompt along with the selected content to provide contextual AI assistance. The generated response can be displayed inline, where users can review and accept or discard the suggestion.

For AI-generated responses, integrate the Inline AI Assist control with [Azure OpenAI](https://azure.microsoft.com/en-us/products/ai-foundry/models/openai).
	- [Azure OpenAI integration with ASP.NET MVC Inline AI Assist](../ai-integrations/openai-integration)
## Prerequisites

Before enabling `Speech-to-Text`, ensure that the [ASP.NET MVC Inline AI Assist](../getting-started) control is configured in your application and that the browser supports the [Speech Recognition API](https://developer.mozilla.org/en-US/docs/Web/API/SpeechRecognition).

## Enable built-in speech-to-text

Use the [SpeechToTextSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html) property and set `Enable` to `true` to display the microphone button in the Inline AI Assist prompt.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/enable/razor %}
{% endhighlight %}
{% endtabs %}

Once enabled, a microphone button appears in the Inline AI Assist prompt area. The recognized speech is converted into prompt text and is available through the `PromptRequest` event when the prompt is submitted.

## Configure speech recognition language

Use the `Lang` property to set the language used by speech recognition. If it is not specified, the browser's default language is used. For example, set `Lang` to `en-US`, `es-ES`, or `fr-FR` to recognize speech in a specific language.

## Configure speech button settings

Use `ButtonSettings` to customize the microphone button. You can set `Content` and `StopContent` for the idle and recording states, and `IconCss` and `StopIconCss` for their icons.

## Enable interim results

Set `AllowInterimResults` to `true` to show partial transcription results while the user is speaking. This provides immediate feedback before the final transcript is added to the prompt.

The following example enables speech-to-text and configures the language, button, and interim result settings:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/configuration/razor %}
{% endhighlight %}
{% endtabs %}

## Configure tooltip settings

Use `TooltipSettings` to customize the tooltip text displayed for the microphone button in its idle and recording states.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/tooltip-settings/razor %}
{% endhighlight %}
{% endtabs %}

## Speech-to-text events

Speech-to-text provides events that let you respond when recognition starts, stops, updates the transcript, or encounters an error. Use `OnStart`, `OnStop`, `TranscriptChanged`, and `OnError` to handle these states in your application.

```cshtml

<div id='inline-assist'>
	@Html.EJS().InlineAIAssist("inline-assist").SpeechToTextSettings(new Syncfusion.EJ2.InteractiveChat.InlineAIAssistSpeechToTextSettings
	{
		Enable = true,
		OnStart = "onSpeechStart",
		OnStop = "onSpeechStop",
		TranscriptChanged = "onTranscriptChanged",
		OnError = "onSpeechError"
	}).Render()
</div>

<script>
	function onSpeechStart() {
		console.log('Speech recognition started.');
	}

	function onSpeechStop() {
		console.log('Speech recognition stopped.');
	}

	function onTranscriptChanged(args) {
		console.log(args);
	}

	function onSpeechError(args) {
		console.error(args);
	}
</script>

```

The recognized transcript is updated in the Inline AI Assist prompt area. When the prompt is submitted, both typed and speech-recognized input are available through the `Prompt` property of the `PromptRequest` event arguments.

## Combine speech input with predefined commands

Speech input can be used with predefined commands configured through the [CommandSettings](../command-settings) property. Users can select commands such as **Summarize**, **Shorten**, **Translate**, or **Make professional**, and use the microphone to provide additional instructions for the selected content.

The predefined command supplies the intended action, while speech input allows the user to add specific requirements. The selected content is included as context when the prompt is submitted to the AI service.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/predefined-commands/razor %}
{% endhighlight %}
{% endtabs %}

## Review the generated response inline

When the [ResponseMode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_ResponseMode) property is set to `Inline`, the response generated from the speech prompt is displayed within the selected content area. This allows users to review the generated content in its original context before applying it.

The [ResponseSettings](../response-settings) property can be used to handle response actions. Selecting **Accept** retains the generated content, while selecting **Discard** removes the suggestion and restores the original selected content.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/speech/inline-response/razor %}
{% endhighlight %}
{% endtabs %}

## Browser compatibility

The `SpeechToText` feature relies on the [Speech Recognition API](https://ej2.syncfusion.com/aspnetmvc/documentation/speech-to-text/speech-recognition#browser-support), which has limited browser support. See the [browser support](https://ej2.syncfusion.com/aspnetmvc/documentation/speech-to-text/speech-recognition#browser-support) section for details.

The browser may request permission to access the device microphone when speech recognition starts. Speech-to-text is available only when microphone permission is granted and the browser supports the Speech Recognition API.

## See Also

* [Getting Started](../getting-started)
* [Inline Toolbar Configuration](../inline-toolbar)
