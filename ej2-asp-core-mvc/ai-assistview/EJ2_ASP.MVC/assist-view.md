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

You can use the [Prompt](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Prompt) property to define the prompt text for the AI AssistView control.

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

You can use the [PromptPlaceholder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptPlaceholder) property to set the placeholder text for the prompt textarea. The default value is `Type prompt for assistance...`.

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

You can use the [Prompts](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Prompts) property to initialize the control with the configured data as a collection of prompts and responses or individual entries.

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

## Update response as markdown

The AI AssistView supports rendering responses as **Markdown** content, which is automatically converted to HTML using the built-in [Markdown Converter](https://ej2.syncfusion.com/aspnetmvc/documentation/markdown-editor/markdown-preview). When you pass markdown-formatted text in the response, it will be displayed as formatted HTML in the AI AssistView. The streaming of markdown content happens seamlessly with built-in support for dynamic rendering.

You can use markdown syntax like **bold**, *italic*, headings, lists, code blocks, and links to format your responses.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/markdown-prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MarkdownPrompts.cs" %}
{% include code-snippet/ai-assistview/assistview/markdown-prompt/markdownPrompt.cs %}
{% endhighlight %}
{% endtabs %}

![Markdown Response](images/markdown-prompt.png)

## Adding prompt suggestions

You can use the [PromptSuggestions](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptSuggestions) property, to add the suggestions in both initial and on-demand which help users to refine their prompts. Additionally, custom header can be set for suggestions further enhancing the user experience.

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

You can use the [PromptSuggestionsHeader](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptSuggestionsHeader) property to set the header text for the prompt suggestions in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/suggestionsHeader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SuggestionsHeader.cs" %}
{% include code-snippet/ai-assistview/assistview/suggestionsHeader/suggestionsHeader.cs %}
{% endhighlight %}
{% endtabs %}

![SuggestionsHeader](images/suggestionsHeader.png)

## Adding prompt iconCss

You can customize the appearance of the prompter avatar by using the [PromptIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptIconCss) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/promptIconCss/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptIconCss.cs" %}
{% include code-snippet/ai-assistview/assistview/promptIconCss/promptIconCss.cs %}
{% endhighlight %}
{% endtabs %}

![PromptIconCss](images/promptIconCss.png)

## Adding response iconCss

You can use the [ResponseIconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_ResponseIconCss) property to customize the appearance of the responder avatar. By default, the `e-assistview-icon` class is added as the built-in AI AssistView response icon.

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

You can use the [ShowClearButton](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_ShowClearButton) property to show or hide the clear button. By default, its value is `false`, when the clear button is clicked, the prompt text entered will be cleared.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/showClearButton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowClearButton.cs" %}
{% include code-snippet/ai-assistview/assistview/showClearButton/showClearButton.cs %}
{% endhighlight %}
{% endtabs %}

![ShowClearButton](images/showClearButton.png)

## Enable scroll to bottom icon

You can use the [EnableScrollToBottom](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Enablescrolltobottom) property to show or hide the scroll-to-bottom indicator. By default, this property is `true`. When enabled, a floating icon/button appears when the user scrolls away from the bottom of the conversation. Clicking this icon smoothly scrolls the view to the bottom to display the latest response.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/assistview/scroll-to-bottom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ScrollToBottom.cs" %}
{% include code-snippet/ai-assistview/assistview/scroll-to-bottom/scrollToBottom.cs %}
{% endhighlight %}
{% endtabs %}

![EnableScrollToBottom](images/scroll-to-bottom.png)
