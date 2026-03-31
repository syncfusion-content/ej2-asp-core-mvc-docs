---
layout: post
title: Inline toolbar in ##Platform_Name## InlineAIAssist Control | Syncfusion
description: Checkout and learn about inline toolbar in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Inline toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Toolbar configuration in ##Platform_Name## Inline AI Assist control

You can render the inline toolbar items by using the [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistInlineToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistInlineToolbarSettings_Items) property in the [InlineToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistInlineToolbarSettings.html) property.

## Configure the toolbar and positioning

You can use the `ToolbarPosition` property to customize footer toolbar position. It has two modes such as `Inline`, and `Bottom`. By default, the toolbarPosition is `Inline`.

By settings toolbarPosition as `Bottom`, footer items will be rendered at the bottom with a dedicated footer area.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/inline-toolbar/toolbar-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="toolbar-position.cs" %}
{% include code-snippet/inline-ai-assist/inline-toolbar/toolbar-position/toolbar-position.cs %}
{% endhighlight %}
{% endtabs %}

![ToolbarPosition](images/toolbar-position.png)

## Built-in toolbar items

By default, the inline toolbar renders the `send` item which allows users to send the prompt text.

## Adding custom items

You can use the `InlineToolbarSettings` property to add custom items for the inline toolbar in the Inline AI Assist. The custom items will be added with the existing built-in items in the inline toolbar.

Each toolbar item object can include the following properties:

| Property    | Type    | Default  | Description                                                        |
|-------------|---------|----------|--------------------------------------------------------------------|
| `iconCss`   | string  | ''       | Specifies the CSS class for the item's icon.                       |
| `type`      | string  | 'Button' | Supports three types of items: `Button`, `Separator`, and `Input`. |
| `text`      | string  | ''       | Specifies the text label for the toolbar item.                     |
| `template`  | string  | ''       | Specifies a custom template for the toolbar item.                  |
| `visible`   | boolean | true     | Specifies whether to show or hide the toolbar item.                |
| `id`        | string  | ''       | Specifies a unique identifier for the toolbar item.                |
| `disabled`  | boolean | false    | Specifies whether the toolbar item is disabled and unselectable.   |
| `tooltip`   | string  | ''       | Specifies the tooltip text displayed on hover.                     |
| `cssClass`  | string  | ''       | Specifies custom CSS classes for styling the toolbar item.         |
| `align`     | string  | 'Left'   | Specifies the alignment of the toolbar item (Left, Center, Right). |
| `tabIndex`  | number  | -1       | Specifies the tab order for keyboard navigation.                   |

Below sample demonstrates the usage of custom toolbar items in Inline Assist control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/inline-ai-assist/inline-toolbar/toolbar-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="toolbar-settings.cs" %}
{% include code-snippet/inline-ai-assist/inline-toolbar/toolbar-settings/toolbar-settings.cs %}
{% endhighlight %}
{% endtabs %}

![InlineToolbarSettings](images/toolbar-settings.png)

## Toolbar itemClick event

The [ItemClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssistInlineToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssistInlineToolbarSettings_ItemClick) event is triggered when the inline toolbar item is clicked.

```cshtml

<div id='inline-assist'>
    @Html.EJS().InlineAIAssist("inline-assist").InlineToolbarSettings(new Syncfusion.EJ2.InteractiveChat.InlineAIAssistInlineToolbarSettings { ItemClick = "onToolbarItemClick" }).Render()
</div>

<script>
    function onToolbarItemClick() {
        // Your required actions here
    }
</script>

```
