---
layout: post
title: Methods in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Methods in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Methods
publishingplatform: ##Platform_Name##
documentation: ug
---

# Methods in ##Platform_Name## AI AssistView control

## Adding prompt response

You can use the `addPromptResponse` public method to add the prompts and responses to the AI AssistView. You can add the it either as a `string` or `object` collection.

### Adding responses as string.

You can add string response, by passing it as argument for the `addPromptResponse('Response')` method which adds as the response of last added prompt.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/methods/response-string/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseString](images/response-string.png)

### Adding responses as object.

You can add object response, by passing the prompt and response as a collection as argument for the `addPromptResponse({prompt: 'Prompt text', response: 'Response text'})` method which adds as a new prompt and response in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/methods/response-object/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseObject](images/response-object.png)

## Executing prompt

You can use the `executePrompt` method to execute the prompts dynamically in the AI AssistView. It accepts prompts as string values, which triggers the `promptRequest` event and performs the callback actions.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/methods/execute-prompt/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ExecutePrompt](images/execute-prompt.png)
