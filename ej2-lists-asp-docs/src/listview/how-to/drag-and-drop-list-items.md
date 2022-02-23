# Drag and Drop List Items

In ListView component, we don't have drag and drop support. But we can achieve this requirement using [`TreeView`](https://ej2.syncfusion.com/aspnetcore/documentation/treeview/getting-started/) component with ListView appearance.

Drag and Drop in TreeView component was enabled by setting [`allowDragAndDrop`](https://ej2.syncfusion.com/documentation/api/treeview#allowdraganddrop) to `true`.

```typescript

@Html.EJS().TreeView("element").Fields(ViewBag.TreeViewFields).AllowDragAndDrop(true).Render()

```

The TreeView component is used to represent hierarchical data in a tree like structure. So, list items in TreeView can be dropped to child of target element. we can prevent this behaviour by cancelling the [`nodeDragStop`](https://ej2.syncfusion.com/documentation/api/treeview#nodedragstop) and [`nodeDragging`](https://ej2.syncfusion.com/documentation/api/treeview#nodedragging) events.

```typescript

@Html.EJS().TreeView("element").Fields(ViewBag.TreeViewFields).AllowDragAndDrop(true).NodeDragging("onDragStop").NodeDragStop("onDragStop").Render()

function onDragStop(args) {
    //Block the Child Drop operation in TreeView
   var  draggingItem = document.getElementsByClassName("e-drop-in");
    if (draggingItem.length == 1) {
        draggingItem[0].classList.add('e-no-drop');
        args.cancel = true;
    }
}

```

In the below sample, we have rendered draggable list items.

{% aspTab template="listview/treeview", sourceFiles="list.cs" %}

{% endaspTab %}