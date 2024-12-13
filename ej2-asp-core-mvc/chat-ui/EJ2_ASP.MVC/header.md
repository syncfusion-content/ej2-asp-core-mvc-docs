---
layout: post
title: Header in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Header in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Header
publishingplatform: ##Platform_Name##
documentation: ug
---

# Header in ##Platform_Name## Chat UI control

## Show or hide header

You can use `ShowHeader` property to enable or disable the chat header. It contains the following options `HeaderText` and `HeaderIconCss`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/showHeader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowHeader.cs" %}
{% include code-snippet/chat-ui/header/showHeader/showHeader.cs %}
{% endhighlight %}
{% endtabs %}

![ShowHeader](images/show-header.png)

### Setting header text

You can use the `HeaderText` property to display the text that appears in the header, which indicates the current username or the group name providing the context for the conversation.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/headerText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderText.cs" %}
{% include code-snippet/chat-ui/header/headerText/headerText.cs %}
{% endhighlight %}
{% endtabs %}

![HeaderText](images/header-text.png)

### Setting header icon CSS

You can use the `HeaderIconCss` property to customize the styling of the header icon.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/headerIcon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderIcon.cs" %}
{% include code-snippet/chat-ui/header/headerIcon/headerIcon.cs %}
{% endhighlight %}
{% endtabs %}

![HeaderIcon](images/header-icon.png)

## Toolbar

You can render the Chat UI toolbar items by using the `Items` property in the, `ChatUIToolbarSettings` property.

### Setting items

Items can be constructed with the following built-in command types or item template.

#### Adding icon CSS

You can customize the header toolbar icons by using the `IconCss` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarIcon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarIcon.cs" %}
{% include code-snippet/chat-ui/header/toolbarIcon/toolbarIcon.cs %}
{% endhighlight %}
{% endtabs %}

![ToolbarIcon](images/toolbar-icon.png)

#### Setting item type

You can change the header toolbar item type by using the `Type` property. The `Type` supports three types of items such as `Button`, `Separator` and `Input`. By default, the type is `Button`.

In the following example, header toolbar item type is set as `Button`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarType/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarType.cs" %}
{% include code-snippet/chat-ui/header/toolbarType/toolbarType.cs %}
{% endhighlight %}
{% endtabs %}

![ToolbarType](images/toolbar-type.png)

#### Setting text

You can use the `Text` property to set the text for the header toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarText.cs" %}
{% include code-snippet/chat-ui/header/toolbarText/toolbarText.cs %}
{% endhighlight %}
{% endtabs %}

![ToolbarText](images/toolbar-text.png)

#### Show or hide toolbar item

You can use the `Visible` property to specify whether to show or hide the header toolbar item. By default, its value is `true`.

#### Setting disabled

You can use the `Disabled` property to disable the header toolbar item. By default, its value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarDisable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarDisable.cs" %}
{% include code-snippet/chat-ui/header/toolbarDisable/toolbarDisable.cs %}
{% endhighlight %}
{% endtabs %}

![ToolbarDisable](images/toolbar-disable.png)

#### Setting tooltip text

You can use the `Tooltip` property to specify the tooltip text to be displayed on hovering the header toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarTooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarTooltip.cs" %}
{% include code-snippet/chat-ui/header/toolbarTooltip/toolbarTooltip.cs %}
{% endhighlight %}
{% endtabs %}

#### Setting CSS Class

You can use the `CssClass` property to customize the header toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarCss/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarCss.cs" %}
{% include code-snippet/chat-ui/header/toolbarCss/toolbarCss.cs %}
{% endhighlight %}
{% endtabs %}

![CssClass](images/toolbarCss.png)

#### Setting alignment

You can change the alignment of toolbar item by using the `Align` property. It supports three types of alignments such as `Left`, `Center` and `Right`. By default, the value is `Left`.

In the following example, toolbar item type is set with `Right`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarIcon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarIcon.cs" %}
{% include code-snippet/chat-ui/header/toolbarIcon/toolbarIcon.cs %}
{% endhighlight %}
{% endtabs %}

![Align](images/toolbar-icon.png)

#### Enabling tab key navigation in toolbar

The `TabIndex` property of a Toolbar item is used to enable tab key navigation for the item. By default, the user can switch between items using the arrow keys, but the `TabIndex` property allows you to switch between items using the Tab and Shift+Tab keys as well.

To use the `TabIndex` property, you need to set it for each Toolbar item that you want to enable tab key navigation. The `TabIndex` property should be set to a positive integer value. A value of 0 or a negative value will disable tab key navigation for the item.

For example, to enable tab key navigation for two Toolbar items, you can use the following code:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

 @Html.EJS().ChatUI("chatUser").HeaderToolbar(new ChatUIToolbarSettings() { Items = ViewBag.HeaderToolbar }).Render()
....

{% endhighlight %}
{% highlight C# tabtitle="Tabkeynavigation.cs" hl_lines="3 11" %}

public List<ToolbarItem> Items = new List<ToolbarItem>();

public ActionResult Index()
{
    Items.Add(new ToolbarItem { Text = "Item 1", TabIndex = 1 });
    Items.Add(new ToolbarItem { Text = "Item 2", TabIndex = 2 });
}
....

{% endhighlight %}
{% endtabs %}

With the above code, the user can switch between the two Toolbar items using the Tab and Shift+Tab keys, in addition to using the arrow keys. The items will be navigated in the order specified by the `TabIndex` values.

If you set the `TabIndex` value to 0 for all Toolbar items, tab key navigation will be based on the element order rather than the `TabIndex` values. For example:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

 @Html.EJS().ChatUI("chatUser").HeaderToolbar(new ChatUIToolbarSettings() { Items = ViewBag.HeaderToolbar }).Render()
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

You can use the `Template` property to add custom toolbar item in the Chat UI.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarTemplate.cs" %}
{% include code-snippet/chat-ui/header/toolbarTemplate/toolbarTemplate.cs %}
{% endhighlight %}
{% endtabs %}

![ToolbarTemplate](images/toolbar-template.png)

### Item clicked

The `ItemClicked` event is triggered when the header toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/itemClicked/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemClicked.cs" %}
{% include code-snippet/chat-ui/header/itemClicked/itemClicked.cs %}
{% endhighlight %}
{% endtabs %}
