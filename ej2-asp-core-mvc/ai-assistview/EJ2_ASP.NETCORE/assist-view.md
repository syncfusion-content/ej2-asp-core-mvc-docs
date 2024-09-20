---
layout: post
title: Assist view in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Assist view in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Assist view
publishingplatform: ##Platform_Name##
documentation: ug
---

# Assist view in ##Platform_Name## AI AssistView control

## Setting prompt text

You can use the `prompt` property to define the prompt text for the AI AssistView control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptText/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptText](images/promptText.png)

## Setting prompt placeholder

You can use the `promptPlaceholder` property to set the placeholder text for the prompt textarea. The default value is `Type prompt for assistance...`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptPlaceholder/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptPlaceholder](images/promptPlaceholder.png)

## Prompt-response collection

By using the `prompts`, you can specify the collection of prompts and responses, allowing you to load pre-defined pairs or individual entries ensuring the AI AssistView control is initialized with the configured data.

> The `prompts` collection stores all the prompts and responses generated.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/prompts/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Prompts](images/prompts.png)

## Adding prompt suggestions

By using the `promptSuggestions` property, you can configure the list of suggested prompts in the AI AssistView. Users can choose from these suggestions to use as their prompts.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptSuggestions/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptSuggestions](images/promptSuggestions.png)

### Adding suggestion headers

You can use the `promptSuggestionsHeader` property to set the header text for the prompt suggestions in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/suggestionsHeader/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SuggestionsHeader](images/suggestionsHeader.png)

## Adding prompt iconCSS

You can customize the appearance of the prompter avatar by using the `promptIconCss` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptIconCss/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptIconCss](images/promptIconCss.png)

## Adding response iconCSS

You can use the `responseIconCss` property to customize the appearance of the responder avatar. By default, the `e-assistview-icon` class is added as the built-in AI AssistView response icon.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/responseIconCss/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseIconCss](images/responseIconCss.png)

## Show or hide clear button

You can use the `showClearButton` property to show or hide the clear button. By default, its value is `false`, when the clear button is clicked, the prompt text entered will be cleared.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/showClearButton/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ShowClearButton](images/showClearButton.png)
