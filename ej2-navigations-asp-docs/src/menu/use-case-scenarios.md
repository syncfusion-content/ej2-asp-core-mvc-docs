---
title: "Menu use case scenarios"
component: "Menu"
description: "Menu how to section, toolbar menu, mobile menu, custom menu, scrollable menu."
---

# Use case scenarios

## Scrollable menu

The menu component supports horizontal and vertical scrolling to render large menus and submenus in an adaptive way. This can be achieved by enabling the [`enableScrolling`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~EnableScrolling.html) property and by restricting the corresponding menu/submenu size.

{% aspTab template="menu/use-cases/scrollable", sourceFiles="Scrollable.cs" %}

{% endaspTab %}

## Menu in toolbar

The following example demonstrates how to integrate Menu with Toolbar component.

{% aspTab template="menu/use-cases/toolbar", sourceFiles="ToolBar.cs" %}

{% endaspTab %}

## Hamburger menu

The following example demonstrates the use case of menu with Accordion component integrated in SideBar.

{% aspTab template="menu/use-cases/sidebar", sourceFiles="SideBar.cs" %}

{% endaspTab %}

## Mobile view

The following example demonstrates the use case of Menu in Mobile mode by using ListView component with hamburger.

{% aspTab template="menu/use-cases/listview", sourceFiles="ListView.cs" %}

{% endaspTab %}
