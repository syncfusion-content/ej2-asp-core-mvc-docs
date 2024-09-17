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

You can render the AI AssistView toolbar items by using the `items` property in the `toolbarSettings`, `responseToolbarSettings` & `promptToolbarSettings` properties.

## Adding header toolbar items

### Items

The AI AssistView toolbar's can be rendered by defining an array of items. Items can be constructed with the following built-in command types or item template.

#### Adding iconCSS

You can customize the toolbar icons by using the `iconCss` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/align/tagHelper %}
{% endhighlight %}
{% endtabs %}

![IconCss](images/align.png)

#### Setting item type

You can change the toolbar item type by using the `type` property. The `type` supports three types of items such as `Button`, `Separator` and `Input`. By default, the type is `Button`.

In the following example, toolbar item type is set as `Button`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/itemtype/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Itemtype](images/align.png)

#### Setting text

You can use the `text` property to set the text for toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/text/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Text](images/text.png)

#### Show or hide toolbar item

You can use the `visible` property to specify whether to show or hide the toolbar item. By default, its value is `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/visible/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Visible](images/visible.png)

#### Setting disabled

You can use the `disabled` property to disable the toolbar item. By default, its value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/disabled/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Disabled](images/disabled.png)

#### Setting tooltip text

You can use the `tooltip` property to specify the tooltip text to be displayed on hovering the toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/tooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Tooltip](images/tooltip.png)

#### Setting cssClass

You can use the `cssClass` property to customize the toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/cssClass/tagHelper %}
{% endhighlight %}
{% endtabs %}

![CssClass](images/itemCssClass.png)

#### Setting alignment

You can change the alignment of toolbar item by using the `align` property. It supports three types of alignments such as `Left`, `Center` and `Right`. By default, the value is `Left`.

In the following example, toolbar item type is set with `Right`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/align/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Align](images/align.png)

#### Enabling tab key navigation in toolbar

The `tabIndex` property of a Toolbar item is used to enable tab key navigation for the item. By default, the user can switch between items using the arrow keys, but the `tabIndex` property allows you to switch between items using the Tab and Shift+Tab keys as well.

To use the `tabIndex` property, you need to set it for each Toolbar item that you want to enable tab key navigation. The `tabIndex` property should be set to a positive integer value. A value of 0 or a negative value will disable tab key navigation for the item.

For example, to enable tab key navigation for two Toolbar items, you can use the following code:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

<ejs-aiassistview id="aiAssistView">
    <e-aiassistview-toolbarsettings items="@Model.ToolbarItems"></e-aiassistview-toolbarsettings>
</ejs-aiassistview>
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

With the above code, the user can switch between the two Toolbar items using the Tab and Shift+Tab keys, in addition to using the arrow keys. The items will be navigated in the order specified by the `tabIndex` values.

If you set the `tabIndex` value to 0 for all Toolbar items, tab key navigation will be based on the element order rather than the `tabIndex` values. For example:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

<ejs-aiassistview id="aiAssistView">
    <e-aiassistview-toolbarsettings items="@Model.ToolbarItems"></e-aiassistview-toolbarsettings>
</ejs-aiassistview>
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

You can use the `template` property to add custom toolbar item in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Template](images/template.png)

### Item clicked

The `itemClicked` event is triggered when the header toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/itemClicked/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ItemClicked](images/itemClicked.png)

## Built-in toolbar items

### Prompt

By default, the prompt toolbar renders the built-in items such as `edit` and `copy` items. These allow users to edit the prompt text or copy as needed.

In the following example, AI AssistView control rendered with built-in toolbar items such as `edit` and `copy` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/prompt/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Prompt](images/prompt.png)

#### Setting width

You can use the `width` property to set the width of the prompt toolbar in the AI AssistView.

#### Item clicked

The `itemClicked` event is triggered when the prompt toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/promptItemClick/tagHelper %}
{% endhighlight %}
{% endtabs %}

![PromptItemClick](images/promptItemClick.png)

### Response

By default, the response toolbar renders the built-in items like `copy`, `like`, and `dislike` items to perform response copy and perform rating actions.

In the following example, AI AssistView renders with built-in toolbar items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/response/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Response](images/response.png)

#### Setting width

You can use the `width` property to set the width of the response toolbar in the AI AssistView.

#### Item clicked

The `itemClicked` event is triggered when the response toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/responseItemClick/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ResponseItemClick](images/responseItemClick.png)

## Adding custom toolbar items

You can also add custom toolbar items in the AI AssistView by using the `toolbarSettings`, `responseToolbarSettings` & `promptToolbarSettings` properties.

### Prompt

You can use the `promptToolbarSettings` property to add custom items for the prompt toolbar in the AI AssistView.

> To know more about the items, please refer to the [items](./toolbar-items#items) section.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/custom-prompt/tagHelper %}
{% endhighlight %}
{% endtabs %}

![CustomPrompt](images/custom-prompt.png)

### Response

You can use the `responseToolbarSettings` property to add custom response toolbar in the AI AssistView.

> To know more about the items, please refer to the [items](./toolbar-items#items) section.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/toolbar-items/custom-response/tagHelper %}
{% endhighlight %}
{% endtabs %}

![CustomResponse](images/custom-response.png)

#### Item clicked

The `itemClicked` event is triggered when the custom toolbar item is clicked.