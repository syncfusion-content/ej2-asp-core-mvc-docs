---
layout: post
title: Appearance in ##Platform_Name## InlineAIAssist Control | Syncfusion
description: Checkout and learn about Appearance and styling in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Inline assist
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance and styling in ##Platform_Name## Inline AI Assist control

## Component Dimensions

### Popup width

You can use the [popupWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_PopupWidth) property to set the width of the Inline AI Assist. The default value is `400px`.

### Popup height

You can use the [popupHeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_PopupHeight) property to set the height of the Inline AI Assist. The default value is `auto`.

### Z-index

You can use the [zIndex](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_ZIndex) property to set z-index for the Inline AI Assist popup. The default value is `1000`.

## Custom styling using cssClass

You can customize the appearance of the Inline AI Assist control by using the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_CssClass) property.

The below example shows the use case of the properties such as `Zindex`, `PopupWidth`, `PopupHeight` and `CssClass`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/inline-assist/inline-assist/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Inline-Assist](images/inline-assist.png)
