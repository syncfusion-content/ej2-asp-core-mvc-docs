---
layout: post
title: Style and Appearance in ##Platform_Name## Context Menu | Syncfusion
description: Override Syncfusion ##Platform_Name## Context Menu CSS classes to customize the wrapper, items, and caret icon, or build a custom theme with Theme Studio.
platform: ej2-asp-core-mvc
control: Style And Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Style and Appearance in ##Platform_Name## Context Menu

To modify the ContextMenu appearance, you need to override the default CSS of the ContextMenu control. The following table lists the CSS classes and the corresponding sections they target in the ContextMenu control. You also have the option to create your own custom theme for the controls using our [`Theme Studio`](https://ej2.syncfusion.com/themestudio/?theme=material).

| CSS Class | Purpose of Class |
| ----- | ----- |
| .e-contextmenu-wrapper | To customize the context menu wrapper |
| .e-contextmenu-wrapper .e-menu-parent | To customize the context menu items |
| .e-contextmenu-wrapper ul .e-menu-item.e-selected .e-caret::before | To customize the context menu caret icon |
| .e-contextmenu-wrapper ul .e-menu-item .e-menu-icon::before | To customize the icons of the context menu |