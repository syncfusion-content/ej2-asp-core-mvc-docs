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

The Ribbon effectively resizes the ribbon elements while being resized. It extends when the ribbon size is increased and collapses when the ribbon size is decreased. The resizing can be performed in both the classic and simplified modes.

By default, the ribbon elements are resized based on the group size with larger groups collapsing first, later the medium and small sized items.

## Defining items allowed size

The [allowedSizes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_AllowedSizes) property is used to maintain a constant size for an item when being resized. You can limit an items size by specifying its `allowedSizes` which keeps the size constant even when the Ribbon is being resized.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item allowedSizes=Large type="Button">
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

## Defining items active size

The [activeSize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_ActiveSize) read-only property is used to set the size of the item which is displayed intially before it is being resized.

> On resizing, the items size will be changed based on the available width of the tab content from the order of Large-> Medium-> Small and viceversa.