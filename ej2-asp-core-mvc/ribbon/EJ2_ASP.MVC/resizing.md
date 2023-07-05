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

By extending or collapsing groups, the Ribbon effectively controls available space, with larger groups collapsing first during resizing. Users can create a unique Ribbon by altering the grouping order to suit their needs.

## Defining items allowed size

The [AllowedSizes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_AllowedSizes) property is used to maintain a constant size for an item when being resized. You can limit an items size by specifying its `AllowedSizes` which keeps the size constant even when the Ribbon is being resized.

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

The [ActiveSize](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_ActiveSize) read-only property is used to set the size of the item which is displayed intially before it is being resized.

> On resizing, the items size will be changed based on the available width of the tab content from the order of Large-> Medium-> Small and viceversa.