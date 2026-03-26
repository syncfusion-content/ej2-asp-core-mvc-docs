---
layout: post
title: Templates in ##Platform_Name## InlineAIAssist Control | Syncfusion
description: Checkout and learn about Templates in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template customization in ##Platform_Name## Inline AI Assist control

The Inline AI Assist provides several template options to customize the response and footer items.

## Editor template

You can use the [EditorTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_EditorTemplate) property to customize the default footer area and manage prompt request actions in the Inline AI Assist. This allows users to create unique footers that meet their specific needs.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/templates/editor-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="editor-template.cs" %}
{% include code-snippet/inline-ai-assist/templates/editor-template/editor-template.cs %}
{% endhighlight %}
{% endtabs %}

![EditorTemplate](images/editor-template.png)

## Response template

You can use the [ResponseTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_ResponseTemplate) property to customize response items within the Inline AI Assist. The template context includes the `response` and `toolbarItems` values.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/templates/response-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="response-template.cs" %}
{% include code-snippet/inline-ai-assist/templates/response-template/response-template.cs %}
{% endhighlight %}
{% endtabs %}

![EditorTemplate](images/response-template.png)
