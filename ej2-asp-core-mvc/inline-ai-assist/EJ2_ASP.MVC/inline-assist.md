---
layout: post
title: Inline assist in ##Platform_Name## InlineAIAssist Control | Syncfusion
description: Checkout and learn about Inline assist in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Inline assist
publishingplatform: ##Platform_Name##
documentation: ug
---

# Inline assist configurations in ##Platform_Name## Inline AI Assist control

## Setting prompt text

You can use the [Prompt](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_Prompt) property to define the prompt text for the Inline AI Assist control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/inline-assist/prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="prompt.cs" %}
{% include code-snippet/inline-ai-assist/inline-assist/prompt/prompt.cs %}
{% endhighlight %}
{% endtabs %}

![Prompt](images/prompt.png)

## Prompt-response collection

You can use the [Prompts](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_Prompts) property to retrieve the responses for the associated prompts.

> The `prompts` collection stores all the prompts and responses generated.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/inline-assist/prompts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="prompts.cs" %}
{% include code-snippet/inline-ai-assist/inline-assist/prompts/prompts.cs %}
{% endhighlight %}
{% endtabs %}

![Prompts](images/prompts.png)

## Setting prompt placeholder

You can use the [Placeholder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_Placeholder) property to set the placeholder text for the prompt textarea. The default value is `Ask or generate AI content..`.

## Setting z-index

You can use the [ZIndex](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_ZIndex) property to set z-index for the Inline AI Assist popup. The default value is `1000`.

## Setting popup width

You can use the [PopupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_PopupWidth) property to set the width of the Inline AI Assist. The default value is `400px`.

## Setting popup height

You can use the [PopupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_PopupHeight) property to set the height of the Inline AI Assist. The default value is `auto`.

## cssClass

You can customize the appearance of the Inline AI Assist control by using the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_CssClass) property.

The below example shows the usecase of the properties such as `Placeholder`, `Zindex`, `PopupWidth`, `PopupHeight` and `CssClass`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/inline-assist/inline-assist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="inline-assist.cs" %}
{% include code-snippet/inline-ai-assist/inline-assist/inline-assist/inline-assist.cs %}
{% endhighlight %}
{% endtabs %}

![Inline-Assist](images/inline-assist.png)
