---
layout: post
title: Response actions in ##Platform_Name## Inline AI Assist Control | Syncfusion
description: Checkout and learn about Response items in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Response settings
publishingplatform: ##Platform_Name##
documentation: ug
---

# Response actions in ##Platform_Name## Inline AI Assist control

You can render response action popup by using [items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistResponseSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistResponseSettings_Items) property in the `e-inlineaiassist-responsesettings` tag helper.

## Built-in response items

By default, the response popup displays the built-in `accept` and `discard` items, allowing users to accept or discard the response. The response action popup is shown after a response is generated. This feature enables users to accept, discard, or perform custom actions on AI-generated responses.

Built-in items appear by default and cannot be removed, but custom items can be added alongside them.

## Custom response item configuration

You can use the `responseSettings` property to add custom items for the response popup in Inline AI Assist. The custom items will be added with the existing built-in items in the response popup. The custom items will be displayed together with the existing built-in items in the response popup.

Each response item object can include the following properties:

| Property    | Type    | Default | Description                                                      |
|-------------|---------|---------|------------------------------------------------------------------|
| label       | string  | ''      | Specifies the display label of the response item.                |
| iconCss     | string  | ''      | Specifies the CSS class for the item's icon.                     |
| disabled    | boolean | false   | Specifies whether the response item is disabled and unselectable.|
| groupBy     | string  | ''      | Specifies the group category for organizing related items.       |
| id          | string  | ''      | Specifies a unique identifier for the response item.             |
| tooltip     | string  | ''      | Specifies the tooltip text displayed on hover.                   |

## Response interactions

The [itemSelect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistResponseSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistResponseSettings_ItemSelect) event is triggered when an item is selected from the response popup in the Inline AI Assist control.

The below example demonstrates the `ResponseSettings` property

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/response-settings/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseSettings](images/response-settings.png)

## See Also

- [Command Settings](./command-settings.md)
- [Inline Toolbar](./inline-toolbar.md)
- [Events Documentation](./events.md)
