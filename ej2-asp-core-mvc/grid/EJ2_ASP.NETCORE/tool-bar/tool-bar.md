---
layout: post
title: Tool Bar in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Tool Bar in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tool Bar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Toolbar in ASP.NET CORE Grid component

The toolbar in the Syncfusion ASP.NET CORE Grid component offers several general use cases to enhance data manipulation and overall experience. Actions such as adding, editing, and deleting records within the grid can be performed, providing efficient data manipulation capabilities. The toolbar also facilitates data export and import functionality, allowing you to generate downloadable files in formats like Excel, CSV, or PDF. 

The toolbar can be customized with built-in toolbar items or custom toolbar items using the [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Toolbar) property. The `toolbar` property accepts an array of strings representing the built-in toolbar items or an array of `ItemModel` objects for custom toolbar items.

The following example demonstrates how to enable toolbar items in the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="toolbar.cs" %}
{% include code-snippet/grid/toolbar/toolbar/toolbar.cs %}
{% endhighlight %}
{% endtabs %}

![Toolbar](../images/toolbar/toolbar.png)

## Enable or disable toolbar items

Enabling or disabling toolbar items dynamically in Syncfusion ASP.NET CORE Grid is to provide control over the availability of specific functionality based on application logic. This feature allows you to customize the toolbar based on various conditions or individuals interactions. 

You can enable or disable toolbar items dynamically by using the `enableToolbarItems` method. This method allows you to control the availability of specific toolbar items based on your application logic.

In the following example, the [EJ2 Toggle Switch Button component](https://ej2.syncfusion.com/aspnetcore/documentation/switch/getting-started) is added to enable and disable the toolbar items using `enableToolbarItems` method. When the switch is toggled, the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Switch.html#Syncfusion_EJ2_Buttons_Switch_Change) event is triggered and the toolbar items are updated accordingly.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/enable-disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="enable-disable.cs" %}
{% include code-snippet/grid/toolbar/enable-disable/enable-disable.cs %}
{% endhighlight %}
{% endtabs %}

![Enable or disable toolbar items](../images/toolbar/toolbar-enable-disable.gif)

## Add toolbar at the bottom of grid

By adding the toolbar at the bottom of the Syncfusion ASP.NET CORE Grid, important actions and functionality remain consistently visible and easily accessible, providing easy access to actions and operations without the need for scrolling.

To add the toolbar at the bottom of the Grid, you can utilize the [created](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Created) event. By handling this event, you can dynamically insert the toolbar items at the desired position in the grid layout.

The following example shows how to add the toolbar items at the bootom using `created` event of the grid.
 
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/toolbar-bottom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="toolbar-bottom.cs" %}
{% include code-snippet/grid/toolbar/toolbar-bottom/toolbar-bottom.cs %}
{% endhighlight %}
{% endtabs %}

![Add toolbar at the bottom of grid](../images/toolbar/toolbar-add-bottom.png)

## Customize toolbar buttons using CSS

Customizing toolbar buttons in Syncfusion ASP.NET CORE Grid using CSS involves modifying the appearance of built-in toolbar buttons by applying CSS styles. This provides a flexible and customizable way to enhance the visual presentation of the toolbar and create a cohesive interface.

The appearance of the built-in toolbar buttons can be modified by applying the following CSS styles.

```css
.e-grid .e-toolbar .e-tbar-btn .e-icons,
.e-grid .e-toolbar .e-toolbar-items .e-toolbar-item .e-tbar-btn {
    background: #add8e6;   
}
```

The following example demonstrates how to change the background color of the `Add`, `Edit`, `Delete`, `Update` and `Cancel` toolbar buttons by applying CSS styles

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/toolbar/customize-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="toolbar-bottom.cs" %}
{% include code-snippet/grid/ttoolbar/customize-toolbar/toolbar-bottom.cs %}
{% endhighlight %}
{% endtabs %}

![Customize toolbar buttons using CSS](../images/toolbar/toolbar-customize.png)