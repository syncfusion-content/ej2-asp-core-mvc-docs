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

You can use `showHeader` property to enable or disable the chat header. It contains the following options `headerText` and `headerIconCss`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/showHeader/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ShowHeader](images/show-header.png)

### Setting header text

You can use the `headerText` property to display the text that appears in the header, which indicates the current username or the group name providing the context for the conversation.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/headerText/tagHelper %}
{% endhighlight %}
{% endtabs %}

![HeaderText](images/header-text.png)

### Setting header icon CSS

You can use the `headerIconCss` property to customize the styling of the header icon.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/headerIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![HeaderIcon](images/header-icon.png)

## Toolbar

You can render the Chat UI toolbar items by using the `items` property in the, `<e-chatui-headertoolbar>` tag helpers.

### Setting items

Items can be constructed with the following built-in command types or item template.

#### Adding icon CSS

You can customize the header toolbar icons by using the `iconCss` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ToolbarIcon](images/toolbar-icon.png)

#### Setting item type

You can change the header toolbar item type by using the `type` property. The `type` supports three types of items such as `Button`, `Separator` and `Input`. By default, the type is `Button`.

In the following example, header toolbar item type is set as `Button`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarType/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ToolbarType](images/toolbar-type.png)

#### Setting text

You can use the `text` property to set the text for the header toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarText/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ToolbarText](images/toolbar-text.png)

#### Show or hide toolbar item

You can use the `visible` property to specify whether to show or hide the header toolbar item. By default, its value is `true`.

#### Setting disabled

You can use the `disabled` property to disable the header toolbar item. By default, its value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarDisable/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ToolbarDisable](images/toolbar-disable.png)

#### Setting tooltip text

You can use the `tooltip` property to specify the tooltip text to be displayed on hovering the header toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarTooltip/tagHelper %}
{% endhighlight %}
{% endtabs %}

#### Setting CSS Class

You can use the `cssClass` property to customize the header toolbar item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarCss/tagHelper %}
{% endhighlight %}
{% endtabs %}

![CssClass](images/toolbarCss.png)

#### Setting alignment

You can change the alignment of toolbar item by using the `align` property. It supports three types of alignments such as `Left`, `Center` and `Right`. By default, the value is `Left`.

In the following example, toolbar item type is set with `Right`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ToolbarIcon](images/toolbar-icon.png)

#### Enabling tab key navigation in toolbar

The `tabIndex` property of a Toolbar item is used to enable tab key navigation for the item. By default, the user can switch between items using the arrow keys, but the `tabIndex` property allows you to switch between items using the Tab and Shift+Tab keys as well.

To use the `tabIndex` property, you need to set it for each Toolbar item that you want to enable tab key navigation. The `tabIndex` property should be set to a positive integer value. A value of 0 or a negative value will disable tab key navigation for the item.

For example, to enable tab key navigation for two Toolbar items, you can use the following code:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

<ejs-chatui id="chatUser">
    <e-chatui-headertoolbar items="@Model.Items"></e-chatui-headertoolbar>
</ejs-chatui>
....

{% endhighlight %}
{% highlight C# tabtitle="Tabkeynavigation.cs" hl_lines="3 11" %}

public List<ToolbarItem> Items = new List<ToolbarItem>();

public ActionResult Index()
{
    Items.Add(new ToolbarItem { text = "Item 1", tabIndex = 1 });
    Items.Add(new ToolbarItem { text = "Item 2", tabIndex = 2 });
    ViewBag.ToolbarItems = Items;
}
....

{% endhighlight %}
{% endtabs %}

With the above code, the user can switch between the two Toolbar items using the Tab and Shift+Tab keys, in addition to using the arrow keys. The items will be navigated in the order specified by the `tabIndex` values.

If you set the `tabIndex` value to 0 for all Toolbar items, tab key navigation will be based on the element order rather than the `tabIndex` values. For example:

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

<ejs-chatui id="chatUser">
    <e-chatui-headertoolbar items="@Model.Items"></e-chatui-headertoolbar>
</ejs-chatui>
....

{% endhighlight %}
{% highlight C# tabtitle="Tabkeynavigation.cs" hl_lines="3 11" %}

public List<ToolbarItem> Items = new List<ToolbarItem>();

public ActionResult Index()
{
    Items.Add(new ToolbarItem { text = "Item 1", tabIndex = 0 });
    Items.Add(new ToolbarItem { text = "Item 2", tabIndex = 0 });
    ViewBag.ToolbarItems = Items;
}
....

{% endhighlight %}
{% endtabs %}

In this case, the user can switch between the two Toolbar items using the Tab and Shift+Tab keys, and the items will be navigated in the order in which they appear in the DOM.

#### Setting template

You can use the `template` property to add custom toolbar item in the Chat UI.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/toolbarTemplate/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ToolbarTemplate](images/toolbar-template.png)

### Item clicked

The `itemClicked` event is triggered when the header toolbar item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/header/itemClicked/tagHelper %}
{% endhighlight %}
{% endtabs %}
