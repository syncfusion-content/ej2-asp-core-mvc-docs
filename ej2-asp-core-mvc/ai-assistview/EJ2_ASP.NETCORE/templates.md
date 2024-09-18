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

You can use the `bannerTemplate` property to customize the banner view in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/banner-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![BannerTemplate](images/banner-template.png)

## Prompt item template

You can use the `promptItemTemplate` property to customize the prompt items in the AI AssistView. The template context includes `prompt`, `toolbarItems` and `index` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/prompt-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptTemplate](images/prompt-template.png)

## Response item template

You can use the `responseItemTemplate` property to customize response items within the AI AssistView. The template context includes the `prompt`, `response`, `index`, `toolbarItems` and `output` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/response-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseTemplate](images/response-template.png)

## Prompt suggestion item template

You can use the `promptSuggestionItemTemplate` property to customize the prompt suggestion items in the AI AssistView. The template context includes the `index` and `promptSuggestion`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/suggestion-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![SuggestionTemplate](images/suggestion-template.png)

## Footer template

You can use the `footerTemplate` property to customize the footer items in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/templates/footer-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![FooterTemplate](images/footer-template.png)