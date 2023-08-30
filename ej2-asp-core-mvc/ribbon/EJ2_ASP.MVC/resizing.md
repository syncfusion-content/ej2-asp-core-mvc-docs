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

The Ribbon effectively resizes the ribbon elements while being resized. It extends when the ribbon size is increased and collapses when the ribbon size is decreased. The resizing can be performed in both the classic and simplified modes. Also, we have an option to resize the ribbon elements in the custom order.

In classic mode on resizing, the items size will be changed based on the available width of the tab content from the order of Large-> Medium-> Small and viceversa.

In simplified mode on resizing, the items size will be changed based on the available width of the tab content from the order of Medium-> Small and viceversa.

## Defining items allowed size

You can use the [AllowedSizes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_AllowedSizes) property to maintain a constant size for an item. If `AllowedSizes` is set, it keeps the size constant even when being resized.

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

You can use the [ActiveSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_ActiveSize) property to define the item size intially, before it is being resized. When resized the `ActiveSize` property is updated based on the ribbon's overflow state, which is determined by the `AllowedSizes` property being configured. By default, the value is `Medium`.