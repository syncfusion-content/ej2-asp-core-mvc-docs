---
layout: post
title: Resizing in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Resizing in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ribbon Resizing

When resizing the Ribbon, you have control over how the items behave in terms of their size preservation.

## Defining items allowed size

You can utilize the [allowedSizes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_AllowedSizes) property to maintain a specific size for an item regardless of resizing. By configuring `allowedSizes` for an item, you restrict its size to the specified option, preserving its size even when the Ribbon is being resized.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).AllowedSizes(RibbonItemSize.Large).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

## Defining items active size

You can make use of the [activeSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_ActiveSize) read-only property to retrieve the size at which the item is currently being displayed.