---
layout: post
title: Response actions in ##Platform_Name## Inline AI Assist Control | Syncfusion
description: Checkout and learn about response items in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Response settings
publishingplatform: ##Platform_Name##
documentation: ug
---

# Response actions in ##Platform_Name## Inline AI Assist control

You can render response action popup by using `Items` property in the [responseSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistResponseSettings.html) property.

## Built-in response items

By default, the response popup displays the built-in `accept` and `reject` items, allowing users to accept or reject the response. The response action popup is shown after a response is generated.

In the following example, the Inline AI Assist component is rendered with built-in response settings items such as `accept` and `reject`.

## Adding custom items

You can use the [ResponseSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistResponseSettings.html) property to add custom items for the response popup in Inline AI Assist. The custom items will be added with the existing built-in items in the response popup.

### Setting id

You can use the `Id` property to assign a unique identifier to response items and perform actions based on the selected item.

### Adding iconCss

Include icons by using `IconCss` property on a response item to show an icon alongside the label.

### Setting disabled

You can use the `Disabled` property to disable an item, preventing it from being selected in the response popup. By default, its value is `false`.

### Setting label

You can use the `Label` property to specify the visible text for an item in the response popup; this text describes the action that will be performed when selected.

### Configure groupby

To visually group response items, use `GroupBy` property. The popup will group items by the `GroupBy` value and render group headers in response action popup.

### Setting tooltip text

You can use the `Tooltip` property to specify the tooltip text to be displayed on hovering the response item in the popup.

## Configure item select

The [ItemSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistResponseSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistResponseSettings_ItemSelect) event is triggered when an item is selected from the response popup in the Inline AI Assist control.

The below example demonstrates the `ResponseSettings` property

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/response-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="response-settings.cs" %}
{% include code-snippet/inline-ai-assist/response-settings/response-settings.cs %}
{% endhighlight %}
{% endtabs %}

![ResponseSettings](images/response-settings.png)
