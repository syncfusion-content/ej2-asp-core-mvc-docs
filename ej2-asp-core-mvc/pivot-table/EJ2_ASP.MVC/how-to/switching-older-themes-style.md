---
layout: post
title: Switching Older Themes Style in ##Platform_Name## Pivot Table Component
description: Learn here all about Switching Older Themes Style in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Switching Older Themes Style
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD009 -->

# Switching to older themes style

Since Volume 1, 2020, Syncfusion<sup style="font-size:70%">&reg;</sup> has revised the theming and layout of the Pivot Table. If you prefer the appearance of the earlier theme, you can revert to it by making specific changes. This guide explains how to restore the older theme's style by modifying the CSS to adjust cell background colors and set the row height to match the previous layout.

## CSS Selectors

In the current theme, cells are differentiated by their background colors. To avoid this, you need to override these background colors via simple CSS adjustments within your application. The following CSS selectors allow achieving the same for Material, Fabric, Bootstrap, and Bootstrap v4 themes:


```html      
    <!-- Codes here... -->
    <style>
        .e-pivotview .e-rowsheader, 
        .e-pivotview .e-columnsheader,
        .e-pivotview .e-gtot,
        .e-pivotview .e-content,
        .e-pivotview .e-gridheader,
        .e-pivotview .e-headercell {
            background-color:#fff !important;
        }
    </style>

```

Meanwhile for high contrast theme, we need to set the following CSS.

```html      
    <!-- Codes here... -->
    <style>
        .e-pivotview .e-rowsheader, 
        .e-pivotview .e-columnsheader,
        .e-pivotview .e-gtot,
        .e-pivotview .e-content,
        .e-pivotview .e-gridheader,
        .e-pivotview .e-headercell {
            background-color:#000 !important;
        }
    </style>

```

## Adjusting Row Height

In the current theme, the height of each Pivot Table row has been reduced to make the component more compact. Users can reset the height of the Pivot Table rows using the [`RowHeight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html). In the older theme, this property was typically set to 36 pixels for desktop layouts and 48 pixels for mobile layouts. To replicate the older theme style, reset the [`RowHeight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) accordingly.

The following code sample demonstrates how to replicate the older theme style:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/switch-theme/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SwitchTheme.cs" %}
{% include code-snippet/pivot-table/switch-theme/SwitchTheme.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/switch-theme/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SwitchTheme.cs" %}
{% include code-snippet/pivot-table/switch-theme/SwitchTheme.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Adjusting Row Height](../images/row-height.png)
