---
layout: post
title: Events in ##Platform_Name## SpeechToText Control | Syncfusion
description: Checkout and learn about events in Syncfusion Essential ##Platform_Name## SpeechToText control, its elements, and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## SpeechToText control

This section describes the SpeechToText events that will be triggered when appropriate actions are performed. The following events are available in the SpeechToText control.

|Name|Args|Description|
|---|---|---|
|[Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_Created)|-|Triggers when the SpeechToText control's rendering is fully completed|
|[OnStart](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_OnStart)|StartListeningEventArgs|Triggers when the speech recognition begins|
|[OnStop](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_OnStop)|StopListeningEventArgs|Triggers when the speech recognition stops|
|[OnError](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_OnError)|ErrorEventArgs|Triggers when an error occurs during speech recognition or while listening. For list of possible errors, refer to the [Error handling](./speech-recognition#error-handling) section|
|[TranscriptChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Inputs.SpeechToText.html#Syncfusion_EJ2_Inputs_SpeechToText_TranscriptChanged)|TranscriptChangedEventArgs|Triggers when an transcription change occurs during the speech recognition|

The following example demonstrates how to configure the SpeechToText events.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speech-to-text/events/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Events.cs" %}
{% include code-snippet/speech-to-text/events/events.cs %}
{% endhighlight %}
{% endtabs %}
