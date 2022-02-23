---
title: "Switching to older themes style"
component: "Pivot Table"
description: "This section allows the user to switch the older theme"
---

<!-- markdownlint-disable MD012 -->
<!-- markdownlint-disable MD009 -->

# Switching to older themes style

From Volume 1, 2020 onwards Syncfusion has revised the theming and layout of the Pivot Table. So, to inherit the older theme style and layout please do the necessary changes in CSS and pivot table height.

## CSS Selectors

In current theme, the cells can be differentiated by their background colors. To avoid it, you need to override its background colors via simple CSS coding within your application. The below CSS selectors allow to achieve the same for material, fabric, bootstrap and bootstrap v4 themes.

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

In current theme, to make the component compact we have reduced the height of each pivot table rows. But user can reset the height of the pivot table using the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) property in [`PivotViewGridSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html). In older theme, the property was set to 36 pixels for desktop layout and 48 pixels for mobile layout. So reset the [`RowHeight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewGridSettings.html#Syncfusion_EJ2_PivotView_PivotViewGridSettings_RowHeight) accordingly to visualize the older theme style.

In the below code sample, we replicate the older theme style.

{% aspTab template="pivot-table/switch-theme", sourceFiles="SwitchTheme.cs" %}

{% endaspTab %}

![output](images/row-height.png)
