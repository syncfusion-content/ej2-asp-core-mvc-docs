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

You can use the [prompt](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Prompt) property to define the prompt text for the AI AssistView control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptText/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptText](images/promptText.png)

## Setting prompt placeholder

You can use the [promptPlaceholder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptPlaceholder) property to set the placeholder text for the prompt textarea. The default value is `Type prompt for assistance...`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptPlaceholder/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptPlaceholder](images/promptPlaceholder.png)

## Prompt-response collection

You can use the [prompts](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Prompts) property to initialize the control with the configured data as a collection of prompts and responses or individual entries.

> The `prompts` collection stores all the prompts and responses generated.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/prompts/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Prompts](images/prompts.png)

## Adding prompt suggestions

You can use the [promptSuggestions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptSuggestions) property, to add the suggestions in both initial and on-demand which help users to refine their prompts. Additionally, custom header can be set for suggestions further enhancing the user experience.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptSuggestions/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptSuggestions](images/promptSuggestions.png)

### Adding suggestion headers

You can use the [promptSuggestionsHeader](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptSuggestionsHeader) property to set the header text for the prompt suggestions in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/suggestionsHeader/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SuggestionsHeader](images/suggestionsHeader.png)

## Adding prompt iconCss

You can customize the appearance of the prompter avatar by using the [promptIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptIconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptIconCss/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptIconCss](images/promptIconCss.png)

## Adding response iconCss

You can use the [responseIconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_ResponseIconCss) property to customize the appearance of the responder avatar. By default, the `e-assistview-icon` class is added as the built-in AI AssistView response icon.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/responseIconCss/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseIconCss](images/responseIconCss.png)

## Show or hide clear button

You can use the [showClearButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_ShowClearButton) property to show or hide the clear button. By default, its value is `false`, when the clear button is clicked, the prompt text entered will be cleared.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/showClearButton/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ShowClearButton](images/showClearButton.png)
