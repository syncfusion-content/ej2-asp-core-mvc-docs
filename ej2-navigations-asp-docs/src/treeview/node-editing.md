---
title: "Node Editing"
component: "TreeView"
description: "Editing nodes in treeview"
---

# Node Editing

The TreeView allows you to edit nodes by setting the [allowEditing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TreeView~AllowEditing.html) property to **true**.
To directly edit the nodes in place, **double click** the TreeView node or **select** the node and press **F2** key.

When editing is completed by focus out or by pressing the **Enter** key, the modified node’s text saves automatically. If you do not want to save the modified node’s text in TreeView node, press **Escape** key. It does not save the edited text to the TreeView node.

* Node editing can also be performed programmatically by using the `beginEdit` method. On passing the node ID or element through this method, the edit textbox will be created for the particular node thus allowing us to edit it.

* If you need to validate or prevent editing, the [`nodeEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TreeView~NodeEditing.html) event can be used which is triggered before the TreeView node is renamed. On successfully renaming a node the [`nodeEdited`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TreeView~NodeEdited.html) event will be triggered.

In the following example, the first level node’s text cannot be changed, but all other level nodes' text can be changed.

{% aspTab template="treeview/nodeediting", sourceFiles="nodeediting.cs" %}

{% endaspTab %}

Output be like the below.

![TreeView Sample](./images/node-editing.PNG)

## See Also

* [How to validate the text when renaming the tree node](./how-to/validate-the-text-when-renaming-the-tree-node)
* [How to process the tree node operations using context menu](./how-to/process-the-tree-node-operations-using-context-menu)