---
title: "Context Menu"
component: "Diagram"
description: "Diagram context menu describes how to execute frequently used commands by using context menu items."
---

# Context Menu

<!-- markdownlint-disable MD010 -->

In graphical user interface (GUI), a context menu is a type of menu that appears when you perform right-click operation. Nested level of context menu items can be created.
Diagram provides some in-built context menu items and allows to define custom menu items through the [`contextMenuSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramContextMenuSettings.html) property.

## Customize context menu

The [`show`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramContextMenuSettings.html#Syncfusion_EJ2_Diagrams_DiagramContextMenuSettings_Show) property helps you to enable/disable the context menu. Diagram provides some default context menu items to ease the execution of some frequently used commands.
The following code illustrates how to enable the default context menu items.

{% aspTab template="diagram/contextmenu/default", sourceFiles="default.cs" %}

{% endaspTab %}

Context menu can be defined for individual node with the desired context menu items.

* Apart from the default context menu items, define some additional context menu items. Those additional items have to be defined and added to the [`items`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramContextMenuSettings.html#Syncfusion_EJ2_Diagrams_DiagramContextMenuSettings_Items) property of the context menu.

* Set text and ID for context menu item using the context menu [`text`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramContextMenuSettings.html) and [`ID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramContextMenuSettings.html) properties respectively.

* Set an image for the context menu item using the context menu url property.

* The `iconCss` property defines the class/multiple classes separated by a space for the menu item that is used to include an icon. Menu item can include font icon and sprite image.

* The `target` property used to set the target to show the menu item.

* The `separator` property defines the horizontal lines that are used to separate the menu items. You cannot select the separators. You can enable separators to group the menu items using the separator property.

The following code example illustrates how to add custom context menu items.

{% aspTab template="diagram/contextmenu/item", sourceFiles="item.cs" %}

{% endaspTab %}

To display the custom context menu items alone, set  the `showCustomMenuOnly` property to true.

## Template Support for Context menu

* Diagram provides template support for context menu. The context menu items can be customized by using the `contextMenuBeforeItemRender` event. The contextMenuBeforeItemRender event triggers while rendering each menu item.

* In the following sample, the menu item is rendered with key code for specified action in ContextMenu using the template. Here, the key code is specified for the cut and copy at right corner of the menu items by adding a span element in the `contextMenuBeforeItemRender` event.

{% aspTab template="diagram/contextmenu/events", sourceFiles="events.cs" %}

{% endaspTab %}

## Context menu events

You would be notified with events, when you try to open the context menu items `contextMenuOpen` and when you click the menu items `contextMenuClick`.
The following code example illustrates how to define those events.

{% aspTab template="diagram/contextmenu/events", sourceFiles="events.cs" %}

{% endaspTab %}

```javascript

function contextMenuOpen() {
    for (var item of args.items) {
                if (item.text === 'delete') {
                    var diagram = document.getElementById("container").ej2_instances[0];
                    if (!diagram.selectedItems.nodes.length && !diagram.selectedItems.connectors.length) {
                        args.hiddenItems.push(item.text);
                    }
                }
            }
    }

function contextMenuClick() {
    if (args.item.id === 'delete') {
                var diagram = document.getElementById("container").ej2_instances[0];
                if ((diagram.selectedItems.nodes.length + diagram.selectedItems.connectors.length) > 0) {
                    diagram.cut();
                }
            }

}

```