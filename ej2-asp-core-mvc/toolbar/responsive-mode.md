---
layout: post
title: Responsive Mode in ##Platform_Name## Toolbar | Syncfusion
description: Display the Syncfusion ##Platform_Name## Toolbar in Scrollable or Popup mode when commands exceed the viewable area width.
platform: ej2-asp-core-mvc
control: Responsive Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Responsive Mode in ##Platform_Name## Toolbar

This section explains the supported display modes of the Toolbar when the content exceeds the viewing area. Possible modes are:

* Scrollable
* Popup

## Scrollable

The default overflow mode of the Toolbar is `Scrollable`. Scrollable display mode supports display of commands in a single line with horizontal scrolling enabled when commands overflow to available space.

* The right and left navigation arrows are added to the start and end of the Toolbar to navigate to hidden commands.
* You can also see the hidden commands using touch swipe action.
* By default, if the left navigation icon is disabled, you can see the hidden commands by moving to the `right`.
* By clicking or continuously holding the navigation arrow, hidden commands will become visible.
* If device navigation arrows are not available, swipe to view the hidden commands of the Toolbar.

![Scrollable](./images/scrolling.gif)

* Once the Toolbar reaches the last or first command, the corresponding navigation icon will be disabled and you can move to the opposite direction.

![Touch scroll](./images/scrolling_touch.gif)

![Swipe scroll](./images/scrolling_swipe.gif)

* You can continuously scroll the Toolbar content by holding the navigation icon.

![Long press scroll](./images/scrolling_long_press.gif)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/scrollable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollable.cs" %}
{% include code-snippet/toolbar/responsive-mode/scrollable/scrollable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/scrollable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollable.cs" %}
{% include code-snippet/toolbar/responsive-mode/scrollable/scrollable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Popup

`Popup` is another type of `OverflowMode` in which the Toolbar container holds the commands that can be placed in the available space. The rest of the overflowing commands that do not fit within the viewing area moves to the overflow popup container.

The commands placed in the popup can be viewed by opening the popup using the drop down icon given at the end of the Toolbar.

![Toolbar popup](./images/popup.gif)

N> If the popup content overflows the height of the page, then the rest of the commands will be hidden.

### Priority of commands

Default popup priority is set as `none`, and when the commands of the Toolbar overflow, the ones listed last will be moved to the popup.

You can customize the priority of commands to be displayed on the Toolbar and popup by using the `Overflow` property on individual toolbar items. Set the `Overflow` property to control whether each command appears on the Toolbar first or in the popup:

Property     | Description
------------ | -------------
  `show`       | Always shows items on the `Toolbar with primary` priority.
  `hide`       | Always shows items in the `popup with secondary` priority.
  `none`       | No priority display, commands are moved to the popup in normal order when content exceeds viewing area.

If primary priority commands also exceed available space, they are moved to the popup container at the top and placed before the secondary priority commands.

N> You can maintain a toolbar item in the popup always by using the [ShowAlwaysInPopup](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html#Syncfusion_EJ2_Navigations_ToolbarItem_ShowAlwaysInPopup) property, and this behavior is not applicable for toolbar items with [Overflow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html#Syncfusion_EJ2_Navigations_ToolbarItem_Overflow) property as 'show'.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/toolbar/responsive-mode/popup/popup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/popup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/toolbar/responsive-mode/popup/popup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Text mode for buttons

The `ShowTextOn` property is used to decide button text display area on the Toolbar, popup, or both. This is useful for customization of both text and image representation of commands.

For example, you can show icon only button on the Toolbar, and in the popup container display more information about the commands with icon and text.

Possible values are,

  Property   | Description
------------ | -------------
  `Both`     | Button text is visible in both `Toolbar` and `Popup`.
  `Overflow` | Button text is visible only in the `Popup`.
  `Toolbar`  | Button text is visible only on the `Toolbar`.

In the following code sample, text is visible only in the popup container and not on the Toolbar:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textbutton.cs" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/textbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textbutton.cs" %}
{% include code-snippet/toolbar/responsive-mode/textbutton/textbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
