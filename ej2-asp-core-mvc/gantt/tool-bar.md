---
layout: post
title: Tool Bar in ##Platform_Name## Gantt Component
description: Learn here all about Tool Bar in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Toolbar

The Gantt control provides the toolbar support to handle Gantt actions. The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) property accepts the collection of built-in toolbar items and [`ItemModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html) objects for custom toolbar items.

## Built-in toolbar items

Built-in toolbar items execute standard actions of the Gantt control, and these items can be added to toolbar by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) as a collection of built-in items. It renders the button with icon and text.

The following table shows built-in toolbar items and its actions.

| Built-in Toolbar Items | Actions |
|------------------------|---------|
| Add | Adds a new record. |
| Cancel | Cancels the edit state. |
| CollapseAll | Collapses all the rows. |
| Delete | Deletes the selected record. |
| Edit | Edits the selected record. |
| Indent | Indent the selected record to one level.|
| Outdent | Outdent the elected record to one level.|
| ExpandAll | Expands all the rows. |
| NextTimeSpan | Navigate the Gantt timeline to next time span. |
| PrevTimeSpan | Navigate the Gantt timeline to previous time span. |
| Search | Searches the records by the given key. |
| Update | Updates the edited record. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/defaultItems/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/toolbar/defaultItems/defaultItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/defaultItems/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultItems.cs" %}
{% include code-snippet/gantt/toolbar/defaultItems/defaultItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) has options to define both built-in and custom toolbar items.

## Custom toolbar items

Custom toolbar items can be added to the toolbar by defining the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) property as a collection of [`ItemModels`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html).
Actions for this customized toolbar items are defined in the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ToolbarClick) event.

By default, the custom toolbar items are at left position. You can change the position by using the [`Align`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarItem.html#Syncfusion_EJ2_Navigations_ToolbarItem_Align) property. In the following sample, the `Quick Filter` toolbar item is positioned at right.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/customItems/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CustomItems.cs" %}
{% include code-snippet/gantt/toolbar/customItems/customItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/customItems/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CustomItems.cs" %}
{% include code-snippet/gantt/toolbar/customItems/customItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> * The [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Toolbar) has options to define both built-in and custom toolbar items.
> * If a toolbar item does not match the built-in items, it will be treated as a custom toolbar item.

## Built-in and custom items in toolbar

The Gantt control has an option to use both built-in and custom toolbar items at the same time.

In the following example, the `ExpandAll` and `CollapseAll` are built-in toolbar items and `Test` is the custom toolbar item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/defaultandCustomItems/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultandCustomItems.cs" %}
{% include code-snippet/gantt/toolbar/defaultandCustomItems/defaultandCustomItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/defaultandCustomItems/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DefaultandCustomItems.cs" %}
{% include code-snippet/gantt/toolbar/defaultandCustomItems/defaultandCustomItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Enable/disable toolbar items

You can enable or disable the toolbar items by using the `enableItems` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/enable-disabletoolbarItems/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-disabletoolbarItems.cs" %}
{% include code-snippet/gantt/toolbar/enable-disabletoolbarItems/enable-disabletoolbarItems.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/toolbar/enable-disabletoolbarItems/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enable-disabletoolbarItems.cs" %}
{% include code-snippet/gantt/toolbar/enable-disabletoolbarItems/enable-disabletoolbarItems.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

