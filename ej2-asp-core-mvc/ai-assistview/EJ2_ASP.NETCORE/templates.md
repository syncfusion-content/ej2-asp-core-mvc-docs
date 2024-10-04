---
layout: post
title: Templates in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Templates in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in ##Platform_Name## AI AssistView control

The AI AssistView provides several template options to customize the banner, prompt, response, suggestions and footer items.

## Banner template

You can use the [bannerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_BannerTemplate) property to display additional information, such as a welcome note, and more in the AI AssistView. This banner is positioned at the top of the prompt and response conversation area within the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/banner-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![BannerTemplate](images/banner-template.png)

## Prompt item template

You can use the [promptItemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptItemTemplate) property to customize the prompt items in the AI AssistView. The template context includes `prompt`, `toolbarItems` and `index` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/prompt-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptTemplate](images/prompt-template.png)

## Response item template

You can use the [responseItemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_ResponseItemTemplate) property to customize response items within the AI AssistView. The template context includes the `prompt`, `response`, `index`, `toolbarItems` and `output` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/response-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseTemplate](images/response-template.png)

## Prompt suggestion item template

You can use the [promptSuggestionItemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_PromptSuggestionItemTemplate) property to customize the prompt suggestion items in the AI AssistView. The template context includes the `index` and `promptSuggestion`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/suggestion-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SuggestionTemplate](images/suggestion-template.png)

## Footer template

You can use the [footerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_FooterTemplate) property to customize the default footer area and manage prompt request actions in the AI AssistView. This allows users to create unique footers that meet their specific needs.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/footer-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![FooterTemplate](images/footer-template.png)