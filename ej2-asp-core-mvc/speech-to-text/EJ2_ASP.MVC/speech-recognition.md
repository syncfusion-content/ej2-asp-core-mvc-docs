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

You can use the transcript property to retrieve the transcribed text from the spoken input. The text updates dynamically as the speech recognition process progresses. This property allows developers to display the transcribed text to users or use it for further processing.

## Setting language

You can use the lang property to specify the language for speech recognition. Setting this property ensures that the recognition engine interprets the spoken words correctly based on the specified locale such as 'en-US' for American English, 'fr-FR' for French, and more.

## Allowing interim results

You can use the allowInterimResults property to enable or disable interim results. When set to true, the recognized speech will be displayed in real time as words are spoken. When set to false, only final results will be displayed after recognition is complete.

## Managing listening state

You can use the listeningState property to manage the listening state of the microphone.

The listening states of Speech-to-text are as follows:

Inactive

The control is not listening for speech input.

Listening

The control is actively listening and transcribing speech.

Stopped

Speech recognition has ended, and no further input is being processed.

## Show or hide tooltip

You can use the showTooltip property to specify the tooltip text to be displayed on hovering the speech-to-text button. By default, the showTooltip property is true.

## Setting disabled

You can use the disabled property to disable a speech-to-text, preventing user interaction when set to true. By default, the value is false.

## Setting html attributes

You can use the htmlAttributes property to assign custom attributes to the speech-to-text control's HTML element.
