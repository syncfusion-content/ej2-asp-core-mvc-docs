---
layout: post
title: Commands in ##Platform_Name## InlineAIAssist Control | Syncfusion
description: Checkout and learn about command items in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Commands settings
publishingplatform: ##Platform_Name##
documentation: ug
---

# Commands configuration in ##Platform_Name## InlineAIAssist control

You can render and use the command action popup by using the `Commands` property in the [CommandSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html) property. This property helps to supply commands, control popup dimensions, and customize behavior.

## Configure command items

You can use the [CommandSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html) property to add commands that populate the command popup. Each command item can perform a quick request based on the configured `Prompt`.

Each command item object can include the following properties:

| Property    | Type    | Default | Description                                                  |
|-------------|---------|---------|--------------------------------------------------------------|
| label       | string  | ''      | Specifies the display label of the command item.             |
| prompt      | string  | ''      | Specifies the prompt text executed when the item is selected.|
| iconCss     | string  | ''      | Specifies the CSS class for the item's icon.                 |
| disabled    | boolean | false   | Specifies whether the command is disabled and unselectable.  |
| groupBy     | string  | ''      | Specifies the group category for organizing related commands.|
| id          | string  | ''      | Specifies a unique identifier for the command item.          |
| tooltip     | string  | ''      | Specifies the tooltip text displayed on hover.               |

## Command interactions

The [ItemSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistCommandSettings_ItemSelect) event is triggered when a command item is selected from the command popup in the Inline AI Assist control.

## Customization of AI commands popup

### Setting popup width

Control the popup width with [PopupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistCommandSettings_PopupWidth) property in the commandSettings. Accepts CSS values or number (px).

### Setting popup height

Control the popup height with [PopupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistCommandSettings_PopupHeight) property in the commandSettings. Use this to enable scrollable lists when many commands exist.

The below sample demonstrates the `CommandSettings` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/command-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="command-settings.cs" %}
{% include code-snippet/inline-ai-assist/command-settings/command-settings.cs %}
{% endhighlight %}
{% endtabs %}

![CommandSettings](images/command-settings.png)

## See Also

- [Response Settings](./response-settings.md)
- [Inline Toolbar](./inline-toolbar.md)
- [Events Documentation](./events.md)
