---
layout: post
title: Methods in ##Platform_Name## Inline AI Assist Control | Syncfusion
description: Checkout and learn about Methods in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Methods
publishingplatform: ##Platform_Name##
documentation: ug
---

# Methods in ##Platform_Name## Inline AI Assist control

## Adding response

You can use the `addResponse` public method to add the response to the Inline AI Assist.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/methods/add-response/razor %}
{% endhighlight %}
{% highlight c# tabtitle="add-response.cs" %}
{% include code-snippet/inline-ai-assist/methods/add-response/add-response.cs %}
{% endhighlight %}
{% endtabs %}

![AddResponse](./../images/add-response.png)

## Executing prompt

You can use the `executePrompt` method to execute the prompts dynamically in the Inline AI Assist. It accepts prompts as string values, which triggers the `promptRequest` event and performs the callback actions.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/methods/execute-prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="execute-prompt.cs" %}
{% include code-snippet/inline-ai-assist/methods/execute-prompt/execute-prompt.cs %}
{% endhighlight %}
{% endtabs %}

![ExecutePrompt](./../images/execute-prompt.png)

## Showing popup

You can use `showPopup` method to open the Inline AI Assist popup and optionally position it at specified coordinates.

## Hiding popup

You can use `hidePopup` method to close the Inline AI Assist popup.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/methods/show-hide-componentpopup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="show-popup.cs" %}
{% include code-snippet/inline-ai-assist/methods/show-hide-componentpopup/show-popup.cs %}
{% endhighlight %}
{% endtabs %}

![Show-hide-componentpopup](./../images/show-hide-componentpopup.png)

## Showing command popup

Use `showCommandPopup` to open the command action popup; it only opens when the Inline AI Assist popup is already opened.

## Hiding command popup

You can use `hideCommandPopup` to close the command action popup in the Inline AI Assist control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/methods/show-hide-commandpopup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="show-popup.cs" %}
{% include code-snippet/inline-ai-assist/methods/show-hide-commandpopup/show-popup.cs %}
{% endhighlight %}
{% endtabs %}

![show-hide-commandpopup](./../images/show-hide-commandpopup.png)
