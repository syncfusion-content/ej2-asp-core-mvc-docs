---
layout: post
title: Events in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Events in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## AI AssistView control

This section describes the AI AssistView events that will be triggered when appropriate actions are performed. The following events are available in the AI AssistView control.

## created

The AI AssistView control triggers the `Created` event when the control rendering is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Created.cs" %}
{% include code-snippet/ai-assistview/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}

## promptRequest

The `PromptRequest` event is triggered when the prompt request is made in the AI AssistView control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/events/promptRequest/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptRequest.cs" %}
{% include code-snippet/ai-assistview/events/promptRequest/promptRequest.cs %}
{% endhighlight %}
{% endtabs %}

## promptChanged

The `PromptChanged` event is triggered when the prompt text is changed in the AI AssistView control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/events/promptChanged/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptChanged.cs" %}
{% include code-snippet/ai-assistview/events/promptChanged/promptChanged.cs %}
{% endhighlight %}
{% endtabs %}
