---
layout: post
title: Toolbar items in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Toolbar items in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Toolbar items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Toolbar items in ##Platform_Name## AI AssistView control

You can render the AI AssistView toolbar items by using the [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewToolbarSettings_Items) property in the [ToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewToolbarSettings.html), [ResponseToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html) & [PromptToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewPromptToolbarSettings.html) properties.

## Adding header toolbar items

### Items

The AI AssistView toolbar's can be rendered by defining an array of items. Items can be constructed with the following built-in command types or item template.

#### Adding iconCss

You can customize the toolbar icons by using the `IconCss` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/align/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Align.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/align/align.cs %}
{% endhighlight %}
{% endtabs %}

![Align](images/align.png)

#### Setting item type

You can change the toolbar item type by using the `Type` property. The `Type` supports three types of items such as `Button`, `Separator` and `Input`. By default, the type is `Button`.

In the following example, toolbar item type is set as `Button`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/itemtype/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtype.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/itemtype/itemtype.cs %}
{% endhighlight %}
{% endtabs %}

![Itemtype](images/align.png)

#### Setting text

You can use the `Text` property to set the text for toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/text/text.cs %}
{% endhighlight %}
{% endtabs %}

![Text](images/text.png)

#### Show or hide toolbar item

You can use the `Visible` property to specify whether to show or hide the toolbar item. By default, its value is `True`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/visible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Visible.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/visible/visible.cs %}
{% endhighlight %}
{% endtabs %}

![Visible](images/visible.png)

#### Setting disabled

You can use the `Disabled` property to disable the toolbar item. By default, its value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

![Disabled](images/disabled.png)

#### Setting tooltip text

You can use the `Tooltip` property to specify the tooltip text to be displayed on hovering the toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

![Tooltip](images/tooltip.png)

#### Setting cssClass

You can use the `CssClass` property to customize the toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/cssClass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/cssClass/cssClass.cs %}
{% endhighlight %}
{% endtabs %}

![CssClass](images/cssClass.png)

#### Setting alignment

You can change the alignment of toolbar item by using the `Align` property. It supports three types of alignments such as `Left`, `Center` and `Right`. By default, the value is `Left`.

In the following example, toolbar item type is set with `Right`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/align/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Align.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/align/align.cs %}
{% endhighlight %}
{% endtabs %}

![Align](images/align.png)

#### Enabling tab key navigation in toolbar

The `TabIndex` property of a Toolbar item is used to enable tab key navigation for the item. By default, the user can switch between items using the arrow keys, but the `TabIndex` property allows you to switch between items using the Tab and Shift+Tab keys as well.

To use the `TabIndex` property, you need to set it for each Toolbar item that you want to enable tab key navigation. The `TabIndex` property should be set to a positive integer value. A value of 0 or a negative value will disable tab key navigation for the item.

For example, to enable tab key navigation for two Toolbar items, you can use the following code:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

 @Html.EJS().AIAssistView("aiAssistView").ToolbarSettings(new AIAssistViewToolbarSettings() { Items = ViewBag.ToolbarItems }).Render()
....

{% endhighlight %}
{% highlight C# tabtitle="Tabkeynavigation.cs" hl_lines="3 11" %}

public List<ToolbarItem> Items = new List<ToolbarItem>();

public ActionResult Index()
{
    Items.Add(new ToolbarItem { Text = "Item 1", TabIndex = 1 });
    Items.Add(new ToolbarItem { Text = "Item 2", TabIndex = 2 });
    ViewBag.ToolbarItems = Items;
}
....

{% endhighlight %}
{% endtabs %}

With the above code, the user can switch between the two Toolbar items using the Tab and Shift+Tab keys, in addition to using the arrow keys. The items will be navigated in the order specified by the `TabIndex` values.

If you set the `TabIndex` value to 0 for all Toolbar items, tab key navigation will be based on the element order rather than the `TabIndex` values. For example:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

 @Html.EJS().AIAssistView("aiAssistView").ToolbarSettings(new AIAssistViewToolbarSettings() { Items = ViewBag.ToolbarItems }).Render()
....

{% endhighlight %}
{% highlight C# tabtitle="Tabkeynavigation.cs" hl_lines="3 11" %}

public List<ToolbarItem> Items = new List<ToolbarItem>();

public ActionResult Index()
{
    Items.Add(new ToolbarItem { Text = "Item 1", TabIndex = 0 });
    Items.Add(new ToolbarItem { Text = "Item 2", TabIndex = 0 });
    ViewBag.ToolbarItems = Items;
}
....

{% endhighlight %}
{% endtabs %}

In this case, the user can switch between the two Toolbar items using the Tab and Shift+Tab keys, and the items will be navigated in the order in which they appear in the DOM.

#### Setting template

You can use the `Template` property to add custom toolbar item in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/template/template.cs %}
{% endhighlight %}
{% endtabs %}

![Template](images/template.png)

### Item clicked

The [ItemClicked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewToolbarSettings_ItemClicked) event is triggered when the header toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/itemClicked/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemClicked.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/itemClicked/itemClicked.cs %}
{% endhighlight %}
{% endtabs %}

## Built-in toolbar items

### Prompt

By default, the prompt toolbar renders the built-in items such as `edit` and `copy` items. These allow users to edit the prompt text or copy as needed.

In the following example, AI AssistView control rendered with built-in toolbar items such as `edit` and `copy` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prompt.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/prompt/prompt.cs %}
{% endhighlight %}
{% endtabs %}

![Prompt](images/prompt.png)

#### Setting width

You can use the [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewPromptToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewPromptToolbarSettings_Width) property to set the width of the prompt toolbar in the AI AssistView.

#### Item clicked

The [ItemClicked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewPromptToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewPromptToolbarSettings_ItemClicked) event is triggered when the prompt toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/promptItemClick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PromptItemClick.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/promptItemClick/promptItemClick.cs %}
{% endhighlight %}
{% endtabs %}

### Response

By default, the response toolbar renders the built-in items like `copy`, `like`, and `dislike` items to perform response copy and perform rating actions.

In the following example, AI AssistView renders with built-in toolbar items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/response/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Response.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/response/response.cs %}
{% endhighlight %}
{% endtabs %}

![Response](images/response.png)

#### Setting width

You can use the [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewResponseToolbarSettings_Width) property to set the width of the response toolbar in the AI AssistView.

#### Item clicked

The [ItemClicked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewResponseToolbarSettings_ItemClicked) event is triggered when the response toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/responseItemClick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ResponseItemClick.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/responseItemClick/responseItemClick.cs %}
{% endhighlight %}
{% endtabs %}

## Adding custom toolbar items

You can also add custom toolbar items in the AI AssistView by using the [ToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewToolbarSettings.html), [ResponseToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html) & [PromptToolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewPromptToolbarSettings.html) properties.

### Prompt

You can use the `PromptToolbarSettings` property to add custom items for the prompt toolbar in the AI AssistView.

> To know more about the items, please refer to the [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewPromptToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewPromptToolbarSettings_Items) section.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/custom-prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomPrompt.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/custom-prompt/custom-prompt.cs %}
{% endhighlight %}
{% endtabs %}

![CustomPrompt](images/custom-prompt.png)

### Response

You can use the `ResponseToolbarSettings` property to add custom response toolbar in the AI AssistView.

> To know more about the items, please refer to the [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistViewResponseToolbarSettings.html#Syncfusion_EJ2_InteractiveChat_AIAssistViewResponseToolbarSettings_Items) section.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/custom-response/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomResponse.cs" %}
{% include code-snippet/ai-assistview/toolbar-items/custom-response/custom-response.cs %}
{% endhighlight %}
{% endtabs %}

![CustomResponse](images/custom-response.png)

#### Item clicked

The `ItemClicked` event is triggered when the custom toolbar item is clicked.
