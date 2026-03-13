---
layout: post
title: Commands configuration in ##Platform_Name## Inline AI Assist Control | Syncfusion
description: Checkout and learn about command items in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Commands settings
publishingplatform: ##Platform_Name##
documentation: ug
---

# Commands configuration in ##Platform_Name## Inline AI Assist control

You can render and use the command action popup by using the `Commands` property in the [CommandSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html) property. This property helps to supply commands, control popup dimensions, and customize behavior.

## Configure command items

You can use the [CommandSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html) property to add commands that populate the command popup. Each command item can perform a quick request based on the configured `Prompt`.

### Setting id

You can use the `Id` property to assign a unique identifier to each command item; detect the selected command and perform the corresponding action.

### Adding iconCss

Include icons by using `IconCss` property on a command item to show an icon alongside the label.

### Setting disabled

You can use the `Disabled` property to disable a command, preventing it from being selected. By default, its value is `false`.

### Configure prompt

You can use the `Prompt` property to execute a prompt when the command is selected in the command action popup.

### Setting label

You can use the `Label` property to specify the visible text for a command; this text appears in the command popup and describes the action that will be performed when selected.

### Configure groupBy

To visually group commands, use the `GroupBy` property on command items. The popup will group items by the `GroupBy` value and render group headers.

### Setting tooltip text

You can use the `Tooltip` property to specify the tooltip text to be displayed on hovering the command item in the popup.

## Setting popup width

Control the popup width with [PopupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistCommandSettings_PopupWidth) property in the commandSettings. Accepts CSS values or number (px).

## Setting popup height

Control the popup height with [PopupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistCommandSettings_PopupHeight) property in the commandSettings. Use this to enable scrollable lists when many commands exist.

## Configure item select

The [ItemSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistCommandSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistCommandSettings_ItemSelect) event is triggered when a command item is selected from the command popup in the Inline AI Assist control.
