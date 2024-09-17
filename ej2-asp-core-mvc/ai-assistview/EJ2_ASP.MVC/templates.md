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

You can use the `BannerTemplate` property to customize the banner view in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/banner-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BannerTemplate.cs" %}
{% include code-snippet/ai-assistview/templates/banner-template/banner-template.cs %}
{% endhighlight %}
{% endtabs %}

![BannerTemplate](images/banner-template.png)

## Prompt item template

You can use the `PromptItemTemplate` property to customize the prompt items in the AI AssistView. The template context includes `Prompt`, `ToolbarItems` and `Index` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/prompt-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptTemplate.cs" %}
{% include code-snippet/ai-assistview/templates/prompt-template/prompt-template.cs %}
{% endhighlight %}
{% endtabs %}

![PromptTemplate](images/prompt-template.png)

## Response item template

You can use the `ResponseItemTemplate` property to customize response items within the AI AssistView. The template context includes the `Prompt`, `Response`, `Index`, `ToolbarItems` and `Output` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/response-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ResponseTemplate.cs" %}
{% include code-snippet/ai-assistview/templates/response-template/response-template.cs %}
{% endhighlight %}
{% endtabs %}

![ResponseTemplate](images/response-template.png)

## Prompt suggestion item template

You can use the `PromptSuggestionItemTemplate` property to customize the prompt suggestion items in the AI AssistView. The template context includes the `Index` and `PromptSuggestion`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/suggestion-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SuggestionTemplate.cs" %}
{% include code-snippet/ai-assistview/templates/suggestion-template/suggestion-template.cs %}
{% endhighlight %}
{% endtabs %}

![SuggestionTemplate](images/suggestion-template.png)

## Footer template

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/footer-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FooterTemplate.cs" %}
{% include code-snippet/ai-assistview/templates/footer-template/footer-template.cs %}
{% endhighlight %}
{% endtabs %}

![FooterTemplate](images/footer-template.png)