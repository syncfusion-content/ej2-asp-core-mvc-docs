---
layout: post
title: Assist view in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Assist view in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Assist view
publishingplatform: ##Platform_Name##
documentation: ug
---

# Assist view in ##Platform_Name## AI AssistView control

## Setting prompt text

You can use the `Prompt` property to define the prompt text for the AI AssistView control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptText.cs" %}
{% include code-snippet/ai-assistview/assistview/promptText/promptText.cs %}
{% endhighlight %}
{% endtabs %}

![PromptText](images/promptText.png)

## Setting prompt placeholder

You can use the `PromptPlaceholder` property to set the placeholder text for the prompt textarea. The default value is `Type prompt for assistance...`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptPlaceholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptPlaceholder.cs" %}
{% include code-snippet/ai-assistview/assistview/promptPlaceholder/promptPlaceholder.cs %}
{% endhighlight %}
{% endtabs %}

![PromptPlaceholder](images/promptPlaceholder.png)

## Prompt-response collection

By using the `Prompts`, you can specify the collection of prompts and responses, allowing you to load pre-defined pairs or individual entries ensuring the AI AssistView control is initialized with the configured data.

> The `Prompts` collection stores all the prompts and responses generated.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/prompts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prompts.cs" %}
{% include code-snippet/ai-assistview/assistview/prompts/prompts.cs %}
{% endhighlight %}
{% endtabs %}

![Prompts](images/prompts.png)

## Adding prompt suggestions

By using the `PromptSuggestions` property, you can configure the list of suggested prompts in the AI AssistView. Users can choose from these suggestions to use as their prompts.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptSuggestions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptSuggestions.cs" %}
{% include code-snippet/ai-assistview/assistview/promptSuggestions/promptSuggestions.cs %}
{% endhighlight %}
{% endtabs %}

![PromptSuggestions](images/promptSuggestions.png)

### Adding suggestion headers

You can use the `PromptSuggestionsHeader` property to set the header text for the prompt suggestions in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/suggestionsHeader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SuggestionsHeader.cs" %}
{% include code-snippet/ai-assistview/assistview/suggestionsHeader/suggestionsHeader.cs %}
{% endhighlight %}
{% endtabs %}

![SuggestionsHeader](images/suggestionsHeader.png)

## Adding prompt iconCSS

You can customize the appearance of the prompter avatar by using the `PromptIconCss` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptIconCss/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptIconCss.cs" %}
{% include code-snippet/ai-assistview/assistview/promptIconCss/promptIconCss.cs %}
{% endhighlight %}
{% endtabs %}

![PromptIconCss](images/promptIconCss.png)

## Adding response iconCSS

You can use the `ResponseIconCss` property to customize the appearance of the responder avatar. By default, the `e-assistview-icon` class is added as the built-in AI AssistView response icon.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/responseIconCss/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ResponseIconCss.cs" %}
{% include code-snippet/ai-assistview/assistview/responseIconCss/responseIconCss.cs %}
{% endhighlight %}
{% endtabs %}

![ResponseIconCss](images/responseIconCss.png)

## Show or hide clear button

You can use the `ShowClearButton` property to show or hide the clear button. By default, its value is `false`, when the clear button is clicked, the prompt text entered will be cleared.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/showClearButton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowClearButton.cs" %}
{% include code-snippet/ai-assistview/assistview/showClearButton/showClearButton.cs %}
{% endhighlight %}
{% endtabs %}

![ShowClearButton](images/showClearButton.png)
