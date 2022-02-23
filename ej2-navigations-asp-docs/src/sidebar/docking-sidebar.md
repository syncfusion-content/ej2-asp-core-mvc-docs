---
title: "Docking Sidebar"
component: "Sidebar"
description: "Docking lets the sidebar occupy a small vertical area in a page always and typically contains shortened view of navigation options."
---

# Dock

Dock state of the Sidebar reserves some space on the page that always remains in a visible state when the Sidebar is collapsed. It is used to show the short term of a content like icons alone instead of lengthy text. To achieve this , set [`EnableDock`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnableDock.html) as true along with required [`DockSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~DockSize.html).

In the following sample, the list item has icon with text representation. On dock state only the icon listed out to interact. It can be achieved by using [`EnableDock`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnableDock.html) property.

{% aspTab template="sidebar/docking-sidebar/", sourceFiles="dock.cs" %}

{% endaspTab %}

In Collapsed state,the output be like the below

![Sidebar Sample](./images/dock.png)

In Expanded state, the output be like the below

![Sidebar Sample](./images/dock_expanded.png)

## See Also

* [How to add sidebar navigation](./how-to/layout-page-sidebar-with-treeview)
